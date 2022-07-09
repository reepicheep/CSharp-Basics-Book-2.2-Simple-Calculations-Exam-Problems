using System;

namespace Money
{
    class Money
    {
        static void Main(string[] args)
        {
            double bit = double.Parse(Console.ReadLine());
            double cny = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            double leva = bit * 1168 + cny * 0.264;
            double euro = leva / 1.95;

            double commissionUnit = commission / 100 * euro;
            double resultConvert = euro - commissionUnit;

            Console.WriteLine(resultConvert);

            // https://pastebin.com/UmZZSUJL

           /* double bitcoins = double.Parse(Console.ReadLine());
            double yuans = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            double euro = (bitcoins * 1168 + yuans * 0.15 * 1.76) / 1.95 - ((bitcoins * 1168 + yuans * 0.15 * 1.76) / 1.95 * commission);

            Console.WriteLine(euro);
           
            // не работи
            */
        }
    }
}