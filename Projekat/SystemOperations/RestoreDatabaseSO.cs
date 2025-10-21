using DBBroker;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Server.SystemOperations
{
    public class RestoreDatabaseSO : SystemOperationBase
    {
        public new void ExecuteTemplate()
        {
            try
            {
                broker.OpenConnection();
                ExecuteOperation();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>> Greška u RestoreDatabaseSO: " + ex.Message);
                throw new Exception("Restore nije uspešno izvršen: " + ex.Message);
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public override void ExecuteOperation()
        {
            string dbName = broker.GetDatabaseNameFromConfig();
            string backupDir = GetSafeBackupPath();

            if (!Directory.Exists(backupDir))
                throw new Exception($"Backup folder ne postoji: {backupDir}");

            string latestBackup = Directory.GetFiles(backupDir, $"{dbName}_*.bak")
                                           .OrderByDescending(File.GetCreationTime)
                                           .FirstOrDefault();

            if (latestBackup == null)
                throw new Exception("Nema pronađenih backup fajlova.");

            string sqlPath = latestBackup.Replace(@"\", @"\\");

            string query = $@"
                USE master;
                ALTER DATABASE [{dbName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                RESTORE DATABASE [{dbName}]
                FROM DISK = N'{sqlPath}'
                WITH REPLACE;
                ALTER DATABASE [{dbName}] SET MULTI_USER;";

            Debug.WriteLine($">>> SQL Restore upit: {query}");
            broker.ExecuteNonQuery(query);

            Debug.WriteLine($">>> Baza '{dbName}' uspešno vraćena iz fajla: {latestBackup}");
        }

        private string GetSafeBackupPath()
        {
            string localDbPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                @"Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\Backup");

            if (Directory.Exists(localDbPath))
            {
                Debug.WriteLine($">>> Restore koristi LocalDB folder: {localDbPath}");
                return localDbPath;
            }

            string expressPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                @"Microsoft\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\Backup");

            if (Directory.Exists(expressPath))
            {
                Debug.WriteLine($">>> Restore koristi SQLEXPRESS folder: {expressPath}");
                return expressPath;
            }

            string fallback = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "SQLBackups");

            Debug.WriteLine($">>> Restore koristi fallback folder: {fallback}");
            return fallback;
        }
    }
}
