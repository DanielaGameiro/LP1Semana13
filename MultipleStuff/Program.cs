using System;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperList superList = new SuperList();
            superList.AddRange(new double[] { 5.6, 2.1, 8.9, 4.3, 1.2 });

            double minValue1, maxValue1;
            (double minValue2, double maxValue2) = superList.GetMinMax1(out minValue1, out maxValue1);
            (double minValue3, double maxValue3) = superList.GetMinMax3();
            (double minimum4, double maximum4) = superList.GetMinMax4();

            Console.WriteLine("Versão 1:");
            Console.WriteLine($"Mínimo: {minValue1}");
            Console.WriteLine($"Máximo: {maxValue1}");
            Console.WriteLine();

            Console.WriteLine("Versão 2:");
            Console.WriteLine($"Mínimo: {minValue2}");
            Console.WriteLine($"Máximo: {maxValue2}");
            Console.WriteLine();

            Console.WriteLine("Versão 3:");
            Console.WriteLine($"Mínimo: {minValue3}");
            Console.WriteLine($"Máximo: {maxValue3}");
            Console.WriteLine();

            Console.WriteLine("Versão 4:");
            Console.WriteLine($"Mínimo: {minimum4}");
            Console.WriteLine($"Máximo: {maximum4}");
        }
    }
}
