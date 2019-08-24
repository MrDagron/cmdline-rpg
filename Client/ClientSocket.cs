// A C# program for Client 
using System; 
using System.Net; 
using System.Net.Sockets; 
using System.Text; 

namespace Client
{
    public class ClientSocket
    {
        private string host = "";
        public string Host
        {
            get { return host; }
            set { host = value; }
        }
         private int port = -1;
        public int Port
        {
            get { return port; }
            set { port = value; }
        }

        public ClientSocket(string host, int port)
        {
            Host = host;
            Port = port;
            try
            {
                string[] tempHost = Host.Split('.');
                byte[] ipHostBytes = new byte[tempHost.Length];
                int index = 0;
                foreach(string hostParts in tempHost)
                {
                    int subsection = Int32.Parse(hostParts);
                    ipHostBytes[index++] = Convert.ToByte(subsection);
                }
                IPAddress ipAddr = new IPAddress(ipHostBytes);
                IPEndPoint localEndPoint = new IPEndPoint(ipAddr, Port);

                Socket sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                sender.Connect(localEndPoint);

                Console.WriteLine("Socket connected to -> {0} ", sender.RemoteEndPoint.ToString());

                byte[] messageSent = Encoding.ASCII.GetBytes("Test Client<EOF>");
                int byteSent = sender.Send(messageSent);
                byte[] messageReceived = new byte[1024];

                int byteRecv = sender.Receive(messageReceived); 
                Console.WriteLine("Message from Server -> {0}", Encoding.ASCII.GetString(messageReceived, 0, byteRecv)); 

                sender.Shutdown(SocketShutdown.Both); 
                sender.Close(); 
            }
            catch(Exception e) //todo, better exception handling
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}