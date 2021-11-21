using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Zadej řetězec:");
            string textRetezce = Console.ReadLine();
            textRetezce = textRetezce.ToLower();
            string hledanyText = "itnetwork";

            Console.WriteLine(textRetezce.Contains(hledanyText));
            Console.ReadKey();
        }
    }
}
