using Common;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Client
{
    public class ClientCommunication
    {
        private static ClientCommunication instance;
        public static ClientCommunication Instance
        {
            get
            {
                if (instance == null)
                    instance = new ClientCommunication();

                return instance;
            }
        }
        private ClientCommunication() { }

        private Socket socket;
        private JsonNetworkSerializer serializer;
        public void Connect()
        {
            if (socket == null || !socket.Connected)
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(IPAddress.Parse("127.0.0.1"), 9999);
                serializer = new JsonNetworkSerializer(socket);
            }
        }

        private bool IsConnected()
        {
            try
            {
                return socket != null && socket.Connected;
            }
            catch
            {
                return false;
            }
        }

        private void EnsureConnectedOrConnect()
        {
            if (!IsConnected() || serializer == null)
                Connect();
        }

        public Response Login(string username, string password)
        {
            Inzenjer inzenjer = new Inzenjer{ Username = username, Password = password};
            Request req = new Request
            {
                Argument = inzenjer,
                Operation = Operation.Login
            };
            Response response = new Response();
            try
            {
                EnsureConnectedOrConnect();
                serializer.Send(req);
                response = serializer.Receive<Response>();

                if (response.Result is JsonElement)
                    response.Result = serializer.ReadType<Inzenjer>(response.Result);

                if (response.ExceptionMessage == null && response.Result == null)
                    response.ExceptionMessage = "Korisnik sa ovim korisničkim imenom i šifrom nije pronađen.";
            }
            catch (NullReferenceException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
                response.ExceptionMessage = ex.Message;
                return response;
            }
            catch (InvalidOperationException ex)
            {
                Debug.WriteLine(">>>"+ex.Message);
                response.ExceptionMessage = ex.Message;
                return response;
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>"+ex.Message);
                response.ExceptionMessage = ex.Message;
                return response;
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>"+ex.Message);
                response.ExceptionMessage = ex.Message;
                return response;
            }

            return response;
        }


        public int GetNextFreeId(TableName tableName)
        {
            Request req = new Request
            {
                Argument = tableName,
                Operation = Operation.GetNextFreeId
            };
            serializer.Send(req);

            Response response = serializer.Receive<Response>();
            response.Result = serializer.ReadType<int>(response.Result);
            int nextId = (int)response.Result;

            return nextId;
        }

        public TableDataBundle LoadOtherTableData(TableName tableName)
        {
            Request req = new Request
            {
                Argument = tableName,
                Operation = Operation.GetTableSupportData,
            };

            switch (tableName)
            {
                case TableName.TehnickaDokumentacija:
                    req.Operation = Operation.GetTableSupportDataTD;
                    break;
                case TableName.Inzenjer:
                    req.Operation = Operation.GetTableSupportDataInzenjer;
                    break;
                case TableName.Klijent:
                    req.Operation = Operation.GetTableSupportDataKlijent;
                    break;
                case TableName.Mesto:
                    req.Operation = Operation.GetTableSupportDataMesto;
                    break;
                case TableName.StavkaTehnickaDokumentacija:
                    req.Operation = Operation.GetTableSupportDataSTD;
                    break;

            }
            serializer.Send(req);
            Response response = serializer.Receive<Response>();
            response.Result = serializer.ReadType<TableDataBundle>(response.Result);///!!!!ovde ili tavleDataBundle ili promeni da u SO bude dataBUndele

            TableDataBundle tdcd = (TableDataBundle)response.Result;
            return tdcd;
        }
        public TableDataBundle GetTableData(TableName tableName)
        {
            Request req = new Request
            {
                Argument = tableName,
                Operation = Operation.GetTableDataTD
            };

            switch (tableName)
            {
                case TableName.TehnickaDokumentacija:
                    req.Operation = Operation.GetTableDataTD;
                    break;
                case TableName.Inzenjer:
                    req.Operation = Operation.GetTableDataInzenjer;
                    break;
                case TableName.Klijent:
                    req.Operation = Operation.GetTableDataKlijent;
                    break;
                case TableName.Mesto:
                    req.Operation = Operation.GetTableDataMesto;
                    break;
                case TableName.StavkaTehnickaDokumentacija:
                    req.Operation = Operation.GetTableDataSTD;
                    break;
            }
            serializer.Send(req);

            Response response = serializer.Receive<Response>();

            return serializer.ReadType<TableDataBundle>(response.Result);
        }

        public TableDataBundle GetAdditionalMemberData(TableName tableName, int memberID)
        {
            Request req = new Request
            {
                Argument = memberID,
                Operation = Operation.GetTableDataTD
            };

            switch (tableName)
            {
                case TableName.TehnickaDokumentacija:
                    req.Operation = Operation.GetAdditionalTableDataForTD;
                    break;

                default:
                    throw new NotSupportedException();
            }
            serializer.Send(req);

            Response response = serializer.Receive<Response>();

            return serializer.ReadType<TableDataBundle>(response.Result);
        }

        public TableDataBundle AddTableMember(TableDataMember tdm)
        {
            Request req = new Request
            {
                Argument = tdm,
                Operation = Operation.AddTableMember
            };
            switch (tdm.TableName)
            {
                case TableName.TehnickaDokumentacija:
                    req.Operation = Operation.AddTableMemberTD;
                    break;
                case TableName.Inzenjer:
                    req.Operation = Operation.AddTableMemberInzenjer;
                    break;
                case TableName.Klijent:
                    req.Operation = Operation.AddTableMemberKlijent;
                    break;
                case TableName.Mesto:
                    req.Operation = Operation.AddTableMemberMesto;
                    break;
                case TableName.StavkaTehnickaDokumentacija:
                    req.Operation = Operation.AddTableMemberSTD;
                    break;

            }
            serializer.Send(req);

            Response response = serializer.Receive<Response>();
            Debug.WriteLine("[CLIENT] Primljen Response.Result: " + (response.Result == null ? "NULL" : "OK"));
            return serializer.ReadType<TableDataBundle>(response.Result);
        }

        public TableDataBundle DeleteTableMember(TableDataMember tdm)
        {
            Request req = new Request
            {
                Argument = tdm,
                Operation = Operation.DeleteTableMember
            };

            switch (tdm.TableName)
            {
                case TableName.TehnickaDokumentacija:
                    req.Operation = Operation.DeleteTableMemberTD;
                    break;
                case TableName.Inzenjer:
                    req.Operation = Operation.DeleteTableMemberInzenjer;
                    break;
                case TableName.Klijent:
                    req.Operation = Operation.DeleteTableMemberKlijent;
                    break;
                case TableName.Mesto:
                    req.Operation = Operation.DeleteTableMemberMesto;
                    break;
                case TableName.StavkaTehnickaDokumentacija:
                    req.Operation = Operation.DeleteTableMemberSTD;
                    break;

            }
            serializer.Send(req);

            Response response = serializer.Receive<Response>();

            return serializer.ReadType<TableDataBundle>(response.Result);
        }

        internal TableDataBundle ChangeTableMember(TableDataMember tdm)
        {
            Request req = new Request
            {
                Argument = tdm,
                Operation = Operation.ChangeTableMember
            };

            switch (tdm.TableName)
            {
                case TableName.TehnickaDokumentacija:
                    req.Operation = Operation.ChangeTableMemberTD;
                    break;
                case TableName.Inzenjer:
                    req.Operation = Operation.ChangeTableMemberInzenjer;
                    break;
                case TableName.Klijent:
                    req.Operation = Operation.ChangeTableMemberKlijent;
                    break;
                case TableName.Mesto:
                    req.Operation = Operation.ChangeTableMemberMesto;
                    break;
                case TableName.StavkaTehnickaDokumentacija:
                    req.Operation = Operation.ChangeTableMemberSTD;
                    break;
            }

            try
            {
                serializer.Send(req);

                Response response = serializer.Receive<Response>();

                if (!string.IsNullOrEmpty(response.ExceptionMessage))
                {
                    throw new Exception(response.ExceptionMessage);
                }

                TableDataBundle result = serializer.ReadType<TableDataBundle>(response.Result);
                return result ?? new TableDataBundle { OperationSucceeded = false };
            }
            catch (SocketException ex)
            {
                Debug.WriteLine("[CLIENT] SocketException u AlterTableMember: " + ex.Message);
                throw new Exception("Greška u komunikaciji sa serverom: " + ex.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[CLIENT] Greška u AlterTableMember: " + ex.Message);
                throw;
            }
        }

        public Response BackupDatabase()
        {
            Request req = new Request
            {
                Operation = Operation.BackupDatabase
            };
            EnsureConnectedOrConnect();
            serializer.Send(req);
            return serializer.Receive<Response>();
        }

        public Response RestoreDatabase()
        {
            Request req = new Request
            {
                Operation = Operation.RestoreDatabase
            };
            EnsureConnectedOrConnect();
            serializer.Send(req);
            return serializer.Receive<Response>();
        }

    }
}
