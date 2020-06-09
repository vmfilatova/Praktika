using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool D = false;
            double U =0 ;
            Console.WriteLine("Введите значение x");
            double x;
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Введите число. Десятичные дроби следует записывать с помощью запятой");
            }
            double y;
            Console.WriteLine("Введите значение y");
            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Введите число. Десятичные дроби следует записывать с помощью запятой");
            }

            if ((y <= x * x) && (y < Math.Exp(-x)) && (y < Math.Exp(x)))
            {
                D = true;
            }

            if (D == true)
            {
                U = x + y;
            }
            else
                U = x - y;

            Console.WriteLine("Ответ: ");
            Console.Write(U);
            Console.ReadLine();
        }
    }
}
