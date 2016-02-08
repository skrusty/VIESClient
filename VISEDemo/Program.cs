using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VISEClient;

namespace VISEDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            Console.Write("Enter Country Code (e.g. GB): ");
            var countryCode = Console.ReadLine();
            Console.Write("Enter VAT Number: ");
            var vatNumber = Console.ReadLine();
            var result = client.CheckVATNumber(countryCode, vatNumber);

            Console.WriteLine($"Check returned {result.IsValid}");
            Console.WriteLine($"Company: {result.Name}");
            Console.WriteLine($"Address: {result.Address}");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
