using Common;
using Common.Domain;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Security.Principal;
using System.Transactions;


namespace DBBroker
{
    public class Broker
    {
        private DbConnection connection;
        public Broker()
        {
            connection = new DbConnection();
        }

        public void Rollback()
        {
            connection.Rollback();
        }

        public void Commit()
        {
            connection.Commit();
        }

        public void BeginTransaction()
        {
            connection.BeginTransaction();
        }

        public void CloseConnection()
        {
           connection.CloseConnection();
        }

        public void OpenConnection()
        {
           connection.OpenConnection();
        }

        public Inzenjer? GetInzenjerByKorisnickoIme(string username, string password)
        {
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = @"
                SELECT IdInzenjer, Ime, Prezime, KorisnickoIme, Sifra, Licenca
                FROM Inzenjer
                WHERE KorisnickoIme = @u;";

                command.Parameters.Add("@u", SqlDbType.NVarChar, 30).Value = username;

                using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow))
                {
                    if (!reader.Read())
                        return null;

                    // poređenje lozinke (napomena: u praksi koristi hash + salt)
                    if ((string)reader["Sifra"] != password)
                        return null;

                    Inzenjer inzenjer = new Inzenjer
                    {
                        IdInzenjer = (int)reader["IdInzenjer"],
                        Ime = (string)reader["Ime"],
                        Prezime = (string)reader["Prezime"],
                        Username = (string)reader["KorisnickoIme"],
                        Password = (string)reader["Sifra"],
                        Licenca = reader["Licenca"] == DBNull.Value ? null : (string)reader["Licenca"]
                    };

                    return inzenjer;
                }
            }
        }

        public int GetNextId(TableName tableName)
        {
            string idColumn = GetTeableIdColumn(tableName);
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = $"SELECT ISNULL(MAX({idColumn}), 0) + 1 FROM {tableName.ToString()}";
                object result = command.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }

        public TableDataBundle GetTableData(TableName tableName)
        {
            TableDataBundle data = new TableDataBundle();

            using (SqlCommand command = connection.CreateCommand())
            {
                switch (tableName)
                {
                    case TableName.Inzenjer:
                        command.CommandText = "SELECT IdInzenjer, Ime, Prezime, KorisnickoIme, Licenca FROM Inzenjer";
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                data.Inzenjeri.Add(new Inzenjer
                                {
                                    IdInzenjer = (int)reader["IdInzenjer"],
                                    Ime = (string)reader["Ime"],
                                    Prezime = (string)reader["Prezime"],
                                    Username = (string)reader["KorisnickoIme"],
                                    Licenca = reader["Licenca"] == DBNull.Value ? null : (string)reader["Licenca"]
                                });
                            }
                        }
                        break;

                    case TableName.Klijent:
                        command.CommandText = "SELECT IdKlijent, Ime, Prezime, Stranac, IdMesto FROM Klijent";
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                data.Klijenti.Add(new Klijent
                                {
                                    IdKlijent = (int)reader["IdKlijent"],
                                    Ime = (string)reader["Ime"],
                                    Prezime = (string)reader["Prezime"],
                                    Stranac = (bool)reader["Stranac"],
                                    IdMesto = (int)reader["IdMesto"]
                                });
                            }
                        }
                        break;

                    case TableName.Mesto:
                        command.CommandText = "SELECT IdMesto, NazivMesta, NazivDrzave FROM Mesto";
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                data.Mesta.Add(new Mesto
                                {
                                    IdMesto = (int)reader["IdMesto"],
                                    NazivMesta = (string)reader["NazivMesta"],
                                    NazivDrzave = (string)reader["NazivDrzave"]
                                });
                            }
                        }
                        break;

                    case TableName.TipInzenjera:
                        command.CommandText = "SELECT IdStrucnaSprema, Naziv FROM TipInzenjera";
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                data.TipoviI.Add(new TipInzenjera
                                {
                                    IdStrucnaSprema = (int)reader["IdStrucnaSprema"],
                                    Naziv = (string)reader["Naziv"]
                                });
                            }
                        }
                        break;

                    case TableName.TehnickaDokumentacija:
                        command.CommandText = "SELECT IdTD, DatumPotpisivanja, DatumZavrsetka, UkupanIznos, IdInzenjer, IdKlijent FROM TehnickaDokumentacija";
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                data.TehnickeDokumentacije.Add(new TehnickaDokumentacija
                                {
                                    IdTehnickaDokumentacija = (int)reader["IdTD"],
                                    DatumPotpisivanja = (DateTime)reader["DatumPotpisivanja"],
                                    DatumZavrsetka = (DateTime)reader["DatumZavrsetka"],
                                    UkupanIznos = (decimal)reader["UkupanIznos"],
                                    IdInzenjer = (int)reader["IdInzenjer"],
                                    IdKlijent = (int)reader["IdKlijent"]
                                });
                            }
                        }
                        break;

                    case TableName.Zadatak:
                        command.CommandText = "SELECT IdZadatak, Naziv, Trajanje, Cena FROM Zadatak";
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                data.Zadaci.Add(new Zadatak
                                {
                                    IdZadatak = (int)reader["IdZadatak"],
                                    Naziv = (string)reader["Naziv"],
                                    Trajanje = (int)reader["Trajanje"],
                                    Cena = (decimal)reader["Cena"]
                                });
                            }
                        }
                        break;
                }
            }

            return data;
        }


        public TableDataBundle GetTableSupportData(TableName tableName)
        {
            TableDataBundle combinedData = new TableDataBundle();

            List<TableName> supportTables = GetSupportTableNames(tableName);

            foreach (var tbl in supportTables)
            {
                TableDataBundle singleTable = GetTableData(tbl);

                if (singleTable.Inzenjeri.Count > 0)
                    combinedData.Inzenjeri.AddRange(singleTable.Inzenjeri);

                if (singleTable.Klijenti.Count > 0)
                    combinedData.Klijenti.AddRange(singleTable.Klijenti);

                if (singleTable.Mesta.Count > 0)
                    combinedData.Mesta.AddRange(singleTable.Mesta);

                if (singleTable.TipoviI.Count > 0)
                    combinedData.TipoviI.AddRange(singleTable.TipoviI);

                if (singleTable.TehnickeDokumentacije.Count > 0)
                    combinedData.TehnickeDokumentacije.AddRange(singleTable.TehnickeDokumentacije);

                if (singleTable.Zadaci.Count > 0)
                    combinedData.Zadaci.AddRange(singleTable.Zadaci);
            }

            return combinedData;
        }



        private string GetTeableIdColumn(TableName tN)
        {
            switch (tN)
            {
                case TableName.Inzenjer:
                    return TableIdColumnName.IdInzenjer.ToString();
                case TableName.TipInzenjera:
                    return TableIdColumnName.IdStrucnaSprema.ToString();
                case TableName.Mesto:
                    return TableIdColumnName.IdMesto.ToString();
                case TableName.Zadatak:
                    return TableIdColumnName.IdZadatak.ToString();
                case TableName.Klijent:
                    return TableIdColumnName.IdKlijent.ToString();
                case TableName.TehnickaDokumentacija:
                    return TableIdColumnName.IdTD.ToString();
            }

            throw new Exception("Uneta tabela za koju generisanje novog IDa nije potrebno!");
        }

        private List<TableName> GetSupportTableNames(TableName tN)
        {
            switch (tN)
            {
                case TableName.TehnickaDokumentacija:
                    return new List<TableName> { TableName.Inzenjer, TableName.Klijent };

                case TableName.Inzenjer:
                    return new List<TableName> { TableName.TipInzenjera };

                case TableName.Klijent:
                    return new List<TableName> { TableName.Mesto };

                case TableName.Zadatak:
                    return new List<TableName>();

                default:
                    return new List<TableName>();
            }
        }

        public TableDataBundle AddTableMember(TableDataMember tdm)
        {
            TableDataBundle updatedBundle = new TableDataBundle();

            using (SqlCommand command = connection.CreateCommand())
            {
                try
                {
                    switch (tdm.TableName)
                    {
                        case TableName.Inzenjer:
                            command.CommandText = @"INSERT INTO Inzenjer (IdInzenjer, Ime, Prezime, KorisnickoIme, Sifra, Licenca)
                                        VALUES (@id, @ime, @prezime, @korisnickoIme, @sifra, @licenca)";
                            command.Parameters.AddWithValue("@id", tdm.Inzenjer.IdInzenjer);
                            command.Parameters.AddWithValue("@ime", tdm.Inzenjer.Ime);
                            command.Parameters.AddWithValue("@prezime", tdm.Inzenjer.Prezime);
                            command.Parameters.AddWithValue("@korisnickoIme", tdm.Inzenjer.Username);
                            command.Parameters.AddWithValue("@sifra", tdm.Inzenjer.Password);
                            command.Parameters.AddWithValue("@licenca", (object?)tdm.Inzenjer.Licenca ?? DBNull.Value);
                            break;

                        case TableName.Klijent:
                            command.CommandText = @"INSERT INTO Klijent (IdKlijent, Ime, Prezime, Stranac, IdMesto)
                                        VALUES (@id, @ime, @prezime, @stranac, @idMesto)";
                            command.Parameters.AddWithValue("@id", tdm.Klijent.IdKlijent);
                            command.Parameters.AddWithValue("@ime", tdm.Klijent.Ime);
                            command.Parameters.AddWithValue("@prezime", tdm.Klijent.Prezime);
                            command.Parameters.AddWithValue("@stranac", tdm.Klijent.Stranac);
                            command.Parameters.AddWithValue("@idMesto", tdm.Klijent.IdMesto);
                            break;

                        case TableName.Mesto:
                            command.CommandText = @"INSERT INTO Mesto (IdMesto, NazivMesta, NazivDrzave)
                                        VALUES (@id, @nazivMesta, @nazivDrzave)";
                            command.Parameters.AddWithValue("@id", tdm.Mesto.IdMesto);
                            command.Parameters.AddWithValue("@nazivMesta", tdm.Mesto.NazivMesta);
                            command.Parameters.AddWithValue("@nazivDrzave", tdm.Mesto.NazivDrzave);
                            break;

                        case TableName.Zadatak:
                            command.CommandText = @"INSERT INTO Zadatak (IdZadatak, Naziv, Trajanje, Cena)
                                        VALUES (@id, @naziv, @trajanje, @cena)";
                            command.Parameters.AddWithValue("@id", tdm.Zadatak.IdZadatak);
                            command.Parameters.AddWithValue("@naziv", tdm.Zadatak.Naziv);
                            command.Parameters.AddWithValue("@trajanje", tdm.Zadatak.Trajanje);
                            command.Parameters.AddWithValue("@cena", tdm.Zadatak.Cena);
                            break;

                        case TableName.TipInzenjera:
                            command.CommandText = @"INSERT INTO TipInzenjera (IdStrucnaSprema, Naziv)
                                        VALUES (@id, @naziv)";
                            command.Parameters.AddWithValue("@id", tdm.TipInzenjera.IdStrucnaSprema);
                            command.Parameters.AddWithValue("@naziv", tdm.TipInzenjera.Naziv);
                            break;

                        case TableName.TehnickaDokumentacija:
                            command.CommandText = @"INSERT INTO TehnickaDokumentacija 
                                        (IdTD, DatumPotpisivanja, DatumZavrsetka, UkupanIznos, IdInzenjer, IdKlijent)
                                        VALUES (@id, @datumP, @datumZ, @iznos, @idInz, @idKl)";
                            command.Parameters.AddWithValue("@id", tdm.TehnickaDokumentacija.IdTehnickaDokumentacija);
                            command.Parameters.AddWithValue("@datumP", tdm.TehnickaDokumentacija.DatumPotpisivanja);
                            command.Parameters.AddWithValue("@datumZ", tdm.TehnickaDokumentacija.DatumZavrsetka);
                            command.Parameters.AddWithValue("@iznos", tdm.TehnickaDokumentacija.UkupanIznos);
                            command.Parameters.AddWithValue("@idInz", tdm.TehnickaDokumentacija.IdInzenjer);
                            command.Parameters.AddWithValue("@idKl", tdm.TehnickaDokumentacija.IdKlijent);
                            break;
                    }

                    Debug.WriteLine($">>> SQL: {command.CommandText}");
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(">>> ERROR u Broker.AddTableMember: " + ex.Message);
                    throw;
                }

            }

            updatedBundle = GetTableData(tdm.TableName);
            return updatedBundle;
        }

        public TableDataBundle DeleteTableMember(TableDataMember tdm)
        {
            TableDataBundle updatedBundle = new TableDataBundle();

            using (SqlCommand command = connection.CreateCommand())
            {
                try
                {
                    switch (tdm.TableName)
                    {
                        case TableName.Inzenjer:
                            command.CommandText = "DELETE FROM Inzenjer WHERE IdInzenjer = @id";
                            command.Parameters.AddWithValue("@id", tdm.Inzenjer.IdInzenjer);
                            break;

                        case TableName.Klijent:
                            command.CommandText = "DELETE FROM Klijent WHERE IdKlijent = @id";
                            command.Parameters.AddWithValue("@id", tdm.Klijent.IdKlijent);
                            break;

                        case TableName.Mesto:
                            command.CommandText = "DELETE FROM Mesto WHERE IdMesto = @id";
                            command.Parameters.AddWithValue("@id", tdm.Mesto.IdMesto);
                            break;

                        case TableName.Zadatak:
                            command.CommandText = "DELETE FROM Zadatak WHERE IdZadatak = @id";
                            command.Parameters.AddWithValue("@id", tdm.Zadatak.IdZadatak);
                            break;

                        case TableName.TipInzenjera:
                            command.CommandText = "DELETE FROM TipInzenjera WHERE IdStrucnaSprema = @id";
                            command.Parameters.AddWithValue("@id", tdm.TipInzenjera.IdStrucnaSprema);
                            break;

                        case TableName.TehnickaDokumentacija:
                            command.CommandText = "DELETE FROM TehnickaDokumentacija WHERE IdTD = @id";
                            command.Parameters.AddWithValue("@id", tdm.TehnickaDokumentacija.IdTehnickaDokumentacija);
                            break;

                        default:
                            throw new Exception("Nepoznata tabela za brisanje: " + tdm.TableName);
                    }

                    Debug.WriteLine($">>> SQL DELETE: {command.CommandText}");
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(">>> Greška prilikom brisanja u Broker.DeleteTableMember: " + ex.Message);
                    throw;
                }
            }

            updatedBundle = GetTableData(tdm.TableName);
            return updatedBundle;
        }

    }
}
