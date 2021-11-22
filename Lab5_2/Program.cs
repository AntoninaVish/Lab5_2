using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Определение среднего арифметического из семи элементов.");
            const int n = 7;
            int[] array = new int[n];
            float S = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите число: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                S += array[i];
            }
            Console.WriteLine("Среднее арифметическое: {0}", S/n);
            Console.ReadKey();
        }
    }
}
