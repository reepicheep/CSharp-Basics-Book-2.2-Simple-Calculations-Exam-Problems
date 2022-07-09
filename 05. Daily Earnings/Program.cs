using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Daily_Earnings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double dolar = double.Parse(Console.ReadLine());

            double total = n * m * (12 + 2.5);
            double danak = 0.25 * total;
            double ostatak = (total - danak) * dolar;
            double den = ostatak / 365;

            Console.WriteLine("{0:f2}", den);

        // https://github.com/Tuscann/Coding-101/blob/master/34.Programming%20Basics%20Exam%20-%2028%20August%202016/01.00%20-%20%D0%94%D0%BD%D0%B5%D0%B2%D0%BD%D0%B0%20%D0%BF%D0%B5%D1%87%D0%B0%D0%BB%D0%B1%D0%B0/Program.cs
        }
    }
}
