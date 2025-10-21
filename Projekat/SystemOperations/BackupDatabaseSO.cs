using DBBroker;
using System;
using System.Diagnostics;
using System.IO;

namespace Server.SystemOperations
{
    public class BackupDatabaseSO : SystemOperationBase
    {
        public string BackupFilePath { get; private set; }

        public new void ExecuteTemplate()
        {
            try
            {
                broker.OpenConnection();
                ExecuteOperation();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>> Greška u BackupDatabaseSO: " + ex.Message);
                throw new Exception("Backup nije uspešno izvršen: " + ex.Message);
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public override void ExecuteOperation()
        {
            string dbName = broker.GetDatabaseNameFromConfig();

            // 🔹 Automatski pronađi najbezbedniju dostupnu putanju za backup
            string backupDir = GetSafeBackupPath();

            // 🔹 Kreiraj folder ako ne postoji
            if (!Directory.Exists(backupDir))
                Directory.CreateDirectory(backupDir);

            // 🔹 Formiraj jedinstven naziv fajla
            string backupFile = Path.Combine(backupDir, $"{dbName}_{DateTime.Now:yyyyMMdd_HHmmss}.bak");

            // escape za SQL string
            string sqlPath = backupFile.Replace(@"\", @"\\");

            // 🔹 SQL komanda
            string query = $@"
                BACKUP DATABASE [{dbName}]
                TO DISK = N'{sqlPath}'
                WITH FORMAT, INIT, SKIP, NAME = 'Full Backup of {dbName}';";

            Debug.WriteLine($">>> SQL upit: {query}");
            broker.ExecuteNonQuery(query);

            // 🔹 Proveri da li fajl zaista postoji
            FileInfo fi = new FileInfo(backupFile);
            if (!fi.Exists || fi.Length == 0)
                throw new Exception("Backup nije uspešno napravljen – fajl nije pronađen ili je prazan.");

            BackupFilePath = backupFile;
            Debug.WriteLine($">>> Backup uspešno kreiran: {backupFile}");
        }

        private string GetSafeBackupPath()
        {
            // 1️⃣ Ako koristiš LocalDB → koristi lokalni AppData
            string localDbPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                @"Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\Backup");

            if (Directory.Exists(localDbPath))
            {
                Debug.WriteLine($">>> Detektovan LocalDB, koristi: {localDbPath}");
                return localDbPath;
            }

            // 2️⃣ Ako koristiš SQL Express → koristi njegov AppData folder
            string expressPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                @"Microsoft\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\Backup");

            if (Directory.Exists(expressPath))
            {
                Debug.WriteLine($">>> Detektovan SQLEXPRESS, koristi: {expressPath}");
                return expressPath;
            }

            // 3️⃣ Ako ništa od toga ne postoji → koristi fallback folder u AppData
            string fallback = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "SQLBackups");

            Debug.WriteLine($">>> Koristi fallback folder: {fallback}");
            return fallback;
        }
    }
}
