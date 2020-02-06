using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;


namespace is_this_an_API
{
    class Program
    {
        static void Main(string[] args)
        {
            string strurltest = String.Format("https://inara.cz/");
            WebRequest requestObjGet = WebRequest.Create(strurltest);
            string response = requestObjGet.GetResponse().ToString();
            Console.WriteLine(response);
            Console.ReadLine();

        }
    }
}
