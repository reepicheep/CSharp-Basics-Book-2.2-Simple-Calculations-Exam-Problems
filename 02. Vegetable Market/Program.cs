using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vegetable_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double euro = 1.94;

            double vegPrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());

            double vegPerKg = double.Parse(Console.ReadLine());
            double fruitPerKg = double.Parse(Console.ReadLine());

            double vegTotal = vegPrice * vegPerKg;
            double fruitTotal = fruitPrice * fruitPerKg;

            Console.WriteLine((vegTotal + fruitTotal) / euro);
        }
    }
}
