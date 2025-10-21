using Common;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Serverr
{
    public class ClientHandler
    {
        private JsonNetworkSerializer serializer;
        private Socket socket;
        private readonly Server server;

        public ClientHandler(Socket socket, Server server)
        {
            this.socket = socket;
            this.server = server;
            serializer = new JsonNetworkSerializer(socket);
        }

        public void HandleRequest()
        {
            try
            {
                while (true)
                {
                    Request req = serializer.Receive<Request>();
                    Response r = ProcessRequest(req);
                    serializer.Send(r);
                }
            }
            catch (SocketException)
            {
                Debug.WriteLine("Komunikacija sa klijentom je prekinuta");
            }
            catch (IOException)
            {
                Debug.WriteLine("Komunikacija sa klijentom je prekinuta");
            }
            finally
            {
                if (socket.Connected)
                {
                    socket.Close();
                }
                server.RemoveClient(this);
            }
        }

        private Response ProcessRequest(Request req)
        {
            Response r = new Response();
            try
            {
                switch (req.Operation)
                {
                    // ---------------- LOGIN ----------------
                    case Operation.Login:
                        r.Result = Controller.Instance.Login(serializer.ReadType<Inzenjer>(req.Argument));
                        break;

                    // ---------------- GENERIC ----------------
                    case Operation.GetTableData:
                        r.Result = Controller.Instance.GetTableData(serializer.ReadType<TableName>(req.Argument));
                        break;
                    case Operation.GetTableSupportData:
                        r.Result = Controller.Instance.GetTableSupportData(serializer.ReadType<TableName>(req.Argument));
                        break;
                    case Operation.GetNextFreeId:
                        r.Result = Controller.Instance.GetNextFreeId(serializer.ReadType<TableName>(req.Argument));
                        break;
                    case Operation.AddTableMember:
                        r.Result = Controller.Instance.AddTableMember(serializer.ReadType<TableDataMember>(req.Argument));
                        break;
                    case Operation.DeleteTableMember:
                        r.Result = Controller.Instance.DeleteTableMember(serializer.ReadType<TableDataMember>(req.Argument));
                        break;

                    // ---------------- INZENJER ----------------
                    case Operation.GetTableDataInzenjer:
                        r.Result = Controller.Instance.GetTableDataInzenjer();
                        break;
                    case Operation.GetTableSupportDataInzenjer:
                        r.Result = Controller.Instance.GetTableSupportDataInzenjer();
                        break;
                    case Operation.AddTableMemberInzenjer:
                        r.Result = Controller.Instance.AddTableMemberInzenjer(serializer.ReadType<TableDataMember>(req.Argument));
                        break;
                    case Operation.DeleteTableMemberInzenjer:
                        r.Result = Controller.Instance.DeleteTableMemberInzenjer(serializer.ReadType<TableDataMember>(req.Argument));
                        break;
                    case Operation.ChangeTableMemberInzenjer:
                        r.Result = Controller.Instance.ChangeTableMemberInzenjer(serializer.ReadType<TableDataMember>(req.Argument));
                        break;


                    // ---------------- KLIJENT ----------------
                    case Operation.GetTableDataKlijent:
                        r.Result = Controller.Instance.GetTableDataKlijent();
                        break;
                    case Operation.GetTableSupportDataKlijent:
                        r.Result = Controller.Instance.GetTableSupportDataKlijent();
                        break;
                    case Operation.AddTableMemberKlijent:
                        r.Result = Controller.Instance.AddTableMemberKlijent(serializer.ReadType<TableDataMember>(req.Argument));
                        break;
                    case Operation.DeleteTableMemberKlijent:
                        r.Result = Controller.Instance.DeleteTableMemberKlijent(serializer.ReadType<TableDataMember>(req.Argument));
                        break;
                    case Operation.ChangeTableMemberKlijent:
                        r.Result = Controller.Instance.ChangeTableMemberKlijent(serializer.ReadType<TableDataMember>(req.Argument));
                        break;

                    // ---------------- MESTO ----------------
                    case Operation.GetTableDataMesto:
                        r.Result = Controller.Instance.GetTableDataMesto();
                        break;
                    case Operation.AddTableMemberMesto:
                        r.Result = Controller.Instance.AddTableMemberMesto(serializer.ReadType<TableDataMember>(req.Argument));
                        break;
                    case Operation.DeleteTableMemberMesto:
                        r.Result = Controller.Instance.DeleteTableMemberMesto(serializer.ReadType<TableDataMember>(req.Argument));
                        break;
                    case Operation.ChangeTableMemberMesto:
                        r.Result = Controller.Instance.ChangeTableMemberMesto(serializer.ReadType<TableDataMember>(req.Argument));
                        break;

                    // ---------------- TEHNIČKA DOKUMENTACIJA ----------------
                    case Operation.GetTableDataTD:
                        r.Result = Controller.Instance.GetTableDataTD();
                        break;
                    case Operation.GetTableSupportDataTD:
                        r.Result = Controller.Instance.GetTableSupportDataTD();
                        break;
                    case Operation.AddTableMemberTD:
                        r.Result = Controller.Instance.AddTableMemberTD(serializer.ReadType<TableDataMember>(req.Argument));
                        break;
                    case Operation.DeleteTableMemberTD:
                        r.Result = Controller.Instance.DeleteTableMemberTD(serializer.ReadType<TableDataMember>(req.Argument));
                        break;
                    case Operation.ChangeTableMemberTD:
                        r.Result = Controller.Instance.ChangeTableMemberTD(serializer.ReadType<TableDataMember>(req.Argument));
                        break;
                    case Operation.GetAdditionalTableDataForTD:
                        r.Result = Controller.Instance.GetAdditionalDataTD(serializer.ReadType<int>(req.Argument));
                        break;
                    // ---------------- STAVKA TEHNIČKE DOK ----------------
                    case Operation.GetTableDataSTD:
                        r.Result = Controller.Instance.GetTableDataSTD();
                        break;
                    case Operation.AddTableMemberSTD:
                        r.Result = Controller.Instance.AddTableMemberSTD(serializer.ReadType<TableDataMember>(req.Argument));
                        break;
                    case Operation.DeleteTableMemberSTD:
                        r.Result = Controller.Instance.DeleteTableMemberSTD(serializer.ReadType<TableDataMember>(req.Argument));
                        break;
                    case Operation.ChangeTableMemberSTD:
                        r.Result = Controller.Instance.ChangeTableMemberSTD(serializer.ReadType<TableDataMember>(req.Argument));
                        break;
                    case Operation.BackupDatabase:
                        r.Result = Controller.Instance.BackupDatabase();
                        break;
                    case Operation.RestoreDatabase:
                        r.Result = Controller.Instance.RestoreDatabase();
                        break;


                    default:
                        r.ExceptionMessage = $"Nepoznata operacija: {req.Operation}";
                        break;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(r.ExceptionMessage);
                r.ExceptionMessage = ex.Message;
            }
            return r;
        }

        internal void CloseSocket()
        {
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }
    }
}
