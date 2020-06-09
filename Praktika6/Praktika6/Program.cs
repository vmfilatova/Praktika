using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1, a2, a3,aj,M; int n, j;

            Console.WriteLine("Введите элемент a1");
            while (!double.TryParse(Console.ReadLine(), out a1))
            {
                Console.WriteLine("Введите число - первый элемент последовательности");
            }

            Console.WriteLine("Введите элемент a2");
            while (!double.TryParse(Console.ReadLine(), out a2))
            {
                Console.WriteLine("Введите число - второй элемент последовательности");
            }

            Console.WriteLine("Введите элемент a3");
            while (!double.TryParse(Console.ReadLine(), out a3))
            {
                Console.WriteLine("Введите число - третий элемент последовательности");
            }

            Console.WriteLine("Введите количество элементов в последовательности");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Введите целое положительное число");
            }

            Console.WriteLine("Введите значение M");
            while (!double.TryParse(Console.ReadLine(), out M))
            {
                Console.WriteLine("Введите число");
            }
            j = 3;
            aj = 3 / 2 * a3 - 2 / 3 * a2 - 1 / 3 * a1;

            while (Math.Abs( aj)<=M)
            {
                aj = 3 / 2 * a3 - 2 / 3 * a2 - 1 / 3 * a1;
                a1 = a2;
                a2 = a3;
                a3 = aj;

                if (aj == M)
                {
                    Console.WriteLine("|aj| = M");
                }

                j++;
            }
            

            if (j > n)
                Console.WriteLine("j>n");
            else
            {
                if (j < n)
                {
                    Console.WriteLine("j < n");
                }
                else Console.WriteLine("j = n");
            }
            Console.ReadLine();
        }
    }
}
