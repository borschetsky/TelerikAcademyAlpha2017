using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem08ParseURL
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = Console.ReadLine();
            //Protocol
            string[] arrProtocol = url.Split(new string[] {"://"}, StringSplitOptions.RemoveEmptyEntries);

            string protocol = arrProtocol[0];
            string adr = arrProtocol[1];
            int splitIndex = adr.IndexOf("/");
            string site = adr.Substring(0, splitIndex);
            string resource = adr.Substring(splitIndex);
            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", site);
            Console.WriteLine("[resource] = {0}", resource);


        }
    }
}
