using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Change_Tiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дължина на страна на полощадката           
            int n = int.Parse(Console.ReadLine());
            // Широчината на една плочка            
            double w = double.Parse(Console.ReadLine());
            // Дължината на една плочка         
            double l = double.Parse(Console.ReadLine());
            // Широчината на пейката
            int m = int.Parse(Console.ReadLine());
            // Дължината на пейката
            int o = int.Parse(Console.ReadLine());

            // Обща площ
            int ОбщаПлощ = n * n;
            // Площ на пейката
            int ПлощНаПейката = m * o;
            // Площ за покриване
            int ПлощЗаПокриване = ОбщаПлощ - ПлощНаПейката;
            // Площ на плочките
            double ПлощНаПлочките = w * l;
            // Необходими плочки 
            double НеобходимиПлочки = ПлощЗаПокриване / ПлощНаПлочките;
            // Необходимо време
            double НеобходимоВреме = НеобходимиПлочки * 0.2;

            // Отпечатване със различен цвят 
            Console.ForegroundColor = ConsoleColor.Green;
            // Отпечатване на необходимите плочки и време 
            Console.WriteLine(НеобходимиПлочки);
            Console.WriteLine(НеобходимоВреме);
            Console.Read();

            // https://pastebin.com/ikdLJQ8D
        }
    }
}
