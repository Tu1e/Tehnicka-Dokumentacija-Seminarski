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
            if (socket == null)
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(IPAddress.Parse("127.0.0.1"), 9999);
                serializer = new JsonNetworkSerializer(socket);
            }
        }

        public Response Login(string username, string password)
        {
            Inzenjer inzenjer = new Inzenjer{ Username = username, Password = password};
            Request req = new Request
            {
                Argument = inzenjer,
                Operation = Operation.Login
            };
            serializer.Send(req);
            Response response = serializer.Receive<Response>();

            response.Result = serializer.ReadType<Inzenjer>(response.Result); // deserijalizujemo result u user-a
            
            if (response.ExceptionMessage == null)
            {
                if ((Inzenjer)response.Result == null)
                {
                    response.ExceptionMessage = "Kojisnik sa ovim korisnickim imenom i sifrom nije pornadjen";
                }
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

        public TehDokCmbData LoadOtherTableData(TableName tableName)
        {
            Request req = new Request
            {
                Argument = tableName,
                Operation = Operation.GetTableSupportData,
            };
            serializer.Send(req);
            Response response = serializer.Receive<Response>();
            response.Result = serializer.ReadType<TehDokCmbData>(response.Result);

            TehDokCmbData tdcd = (TehDokCmbData)response.Result;
            return tdcd;
        }
        public Response GetTableData(TableName tableName)
        {
            Request req = new Request
            {
                Argument = tableName,
                Operation = Operation.GetTableData
            };
            serializer.Send(req);

            Response response = serializer.Receive<Response>();
            response.Result = serializer.ReadType<TehDokCmbData>(response.Result);

            return response;

        }
    }
}
