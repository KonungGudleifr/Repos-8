using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChernobylApp3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double result = 0;
                Console.WriteLine("Введите число рядов: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число x: ");
                int x = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    result += (Math.Cos(i * x) / 3);
                }
                Console.WriteLine($"Сумма {n} рядов = {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}