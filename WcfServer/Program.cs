using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WcfLibr;

namespace WcfServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start server");

            var serviceAddress = "127.0.0.1:10000";
            var serviceName = "MyService";

            Console.WriteLine($"serviceAddress = {serviceAddress}, serviceName= {serviceName} ");

            var host = new ServiceHost(typeof(Transfer), new Uri($"net.tcp://{serviceAddress}/{serviceName}"));
            var serverBinding = new NetTcpBinding();
            host.AddServiceEndpoint(typeof(ITransferObject), serverBinding, "");
            host.Open();

            Console.ReadKey();

        }
    }
}
