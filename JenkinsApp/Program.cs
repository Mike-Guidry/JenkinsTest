using System;
using System.Configuration;
using System.Collections.Specialized;

namespace JenkinsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            build error

            Console.WriteLine("Hello World!");

            string sAttr = ConfigurationManager.AppSettings.Get("Env");
            Console.WriteLine($"Env: {sAttr}");

            NameValueCollection sAll;
            sAll = ConfigurationManager.AppSettings;

            foreach (string s in sAll.AllKeys)
                Console.WriteLine("Key: " + s + " Value: " + sAll.Get(s));
            Console.ReadLine();

        }
    }
}
