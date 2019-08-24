using System; 
using System.Net; 
using System.Net.Sockets; 
using System.Text; 

namespace Server
{
    public class ListenSocket
    {
        private int port = -1;
        public int Port
        {
            get { return port; }
            set { port = value; }
        }

        public ListenSocket(int port)
        {
            Port = port;
            //Get the host running process then return IP addr to listen to 
           // IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            //Establish local end point to listen to
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, Port);
            //Create socket
            Socket listener = new Socket(IPAddress.Any.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                //Bind the network endpoint to our socket listener
                listener.Bind(localEndPoint);
                //Start listening for clients to connect
                listener.Listen(10);

                while(true)
                {
                    Console.WriteLine("Waiting for clients to connect...");
                    //Accept client connections
                    Socket clientSocket = listener.Accept();

                    byte[] dataBuffer = new Byte[1024];
                    string data = null;
                    while(true)
                    {
                        //Recieve data from client and store it in dataBuffer
                        int totalBytesRead = clientSocket.Receive(dataBuffer);
                        data += Encoding.ASCII.GetString(dataBuffer, 0, totalBytesRead);

                        if(data.IndexOf("<EOF>") > -1) break;
                    }
                                
                    Console.WriteLine("Text received -> {0} ", data); 
                    byte[] message = Encoding.ASCII.GetBytes("Test Server"); 
        
                    // Send a message to Client  
                    // using Send() method 
                    clientSocket.Send(message); 
        
                    // Close client Socket using the 
                    // Close() method. After closing, 
                    // we can use the closed Socket  
                    // for a new Client Connection 
                    clientSocket.Shutdown(SocketShutdown.Both); 
                    clientSocket.Close(); 
                }
            }
            catch(SocketException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}