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
            serializer.Send(req);
            Response response = serializer.Receive<Response>();
            response.Result = serializer.ReadType<TableDataBundle>(response.Result);

            TableDataBundle tdcd = (TableDataBundle)response.Result;
            return tdcd;
        }
        public TableDataBundle GetTableData(TableName tableName)
        {
            Request req = new Request
            {
                Argument = tableName,
                Operation = Operation.GetTableData
            };
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
            serializer.Send(req);

            Response response = serializer.Receive<Response>();

            return serializer.ReadType<TableDataBundle>(response.Result);
        }
    }
}
