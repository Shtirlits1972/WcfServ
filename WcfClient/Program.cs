using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WcfLibr;

namespace WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceAddress = "127.0.0.1:10000";
            var serviceName = "MyService";

            Uri tcpUri = new Uri($"net.tcp://{serviceAddress}/{serviceName}");
            EndpointAddress address = new EndpointAddress(tcpUri);
            NetTcpBinding clientBinding = new NetTcpBinding();
            ChannelFactory<ITransferObject> factory = new ChannelFactory<ITransferObject>(clientBinding, address);
            var service = factory.CreateChannel();


            List<string> list = new List<string>();
            list.Add("zaz");
            list.Add("gaz");
            list.Add("Toyota");

            for (int i=0; i<list.Count;i++)
            {
                string result = service.GetProxiByKey(list[i]);
                Console.WriteLine($"{list[i]} = {result}");
            }

            Console.ReadKey();

        }
    }
}
