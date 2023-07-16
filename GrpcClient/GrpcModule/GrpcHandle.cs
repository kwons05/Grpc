using Grpc.Net.Client;

namespace GrpcModule
{
    public class GrpcHandle
    {

        private string URL = "http://localhost:5263";

        public GrpcChannel Channel          { get; set; }
        public Greeter.GreeterClient Client { get; set; }

        public GrpcHandle()
        {
            Channel = GrpcChannel.ForAddress(URL);
            Client = new Greeter.GreeterClient(Channel);
        }

    }
}