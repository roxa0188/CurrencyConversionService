using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCUI
{
    class Program
    {
        private static CurrencyConversion.CurrencyConversionClient CC = new CurrencyConversion.CurrencyConversionClient();
        static void Main(string[] args)
        {
            string ask = Console.ReadLine();
            double result = CC.DkkToEur(Double.Parse(ask));

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
