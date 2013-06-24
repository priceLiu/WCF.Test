using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using CN100.EnterprisePlatform.Wcf.Core;
using CN100.EnterprisePlatform.Wcf.Core.Config;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                CN100WCF(1);
                WCFHosts(1);
                System.Threading.Thread.Sleep(10000);
            }
            
            

            CN100WCF(10);
            WCFHosts(10);
            CN100WCF(10);
            WCFHosts(10);
            CN100WCF(10);
            WCFHosts(10);
            CN100WCF(10);
            WCFHosts(10);
            CN100WCF(10);
            WCFHosts(10);
            Console.ReadLine();
        }

        static void CN100WCF(int count)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            for (int i = 0; i < count; i++)
            {
                using (WcfTcpClient<CN100WCF.ILog> client = WcfClients.Default.CreateClient<CN100WCF.ILog>())
                {

                    //client.Channel.GetAll();

                }
            }
            sw.Stop();
            System.Console.WriteLine("CN100WCF:{0}",(sw.Elapsed.TotalMilliseconds));

        }

        static void WCFHosts(int count)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            for (int i = 0; i < count; i++)
            {
                using (ChannelFactory<WCFStyle.ILog> factory = new ChannelFactory<WCFStyle.ILog>("SOAService"))
                {
                    //WCFStyle.ILog log = factory.CreateChannel();
                    //log.GetAll();

                }
            }
            sw.Stop();
            System.Console.WriteLine("Wcf Base Host:{0}",(sw.Elapsed.TotalMilliseconds));
        }

    }
}
