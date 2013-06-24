using System;
using System.ServiceModel;

namespace WCFHost
{
    class Program
    {
        static void Main(string[] args)
        {
            SOAServiceStart();
        }
        static void SOAServiceStart()
        {
            using (ServiceHost host = new ServiceHost(typeof(WCFStyle.LogServices)))
            {
                Console.Write("SOA服务开启...");
                host.Open();
                Console.ReadLine();
            }
        }
    }
}
