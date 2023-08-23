using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PocConfigFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valueString1 = System.Configuration.ConfigurationManager.AppSettings["id1"];
            string valueString2 = System.Configuration.ConfigurationManager.AppSettings["id2"];
            Console.WriteLine(valueString1);
            Console.WriteLine(valueString2);

            var valueApp = ConfigurationManager.AppSettings;
            foreach (var keyMade in valueApp.AllKeys) 
            {
                string valueName = valueApp[keyMade];
                Console.WriteLine(keyMade);
                Console.WriteLine(valueName);
                
            }
        }
    }
}
