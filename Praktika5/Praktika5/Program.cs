using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер порядка матрицы");
            int n;
            while(!int.TryParse(Console.ReadLine(),out n))
            {
                Console.WriteLine("Введите целое положительное число");
            }
            int[,] arr = new int[n, n];
            Random rnd = new Random();

            //for (int i=0;i<n;i++)
           // {
            //   for (int j=0;j<n;j++)
             //   {
             //       Console.WriteLine("Введите элемент");
             //       arr[i, j] = Convert.ToInt32(Console.ReadLine());
             //   }
           // }
            for (int i =0; i<n; i++)
            {
                for (int j=0; j<n;j++)
                {
                    arr[i, j] = rnd.Next(-100, 100);
                    Console.Write(arr[i,j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            int maxNumber = -101;
            for (int i=0;i<n;i++)
                for (int j=0;j<n;j++)
                {
                    if ((i>=j) &&(i+j<=n-1))
                    {
                        if (maxNumber<arr[i,j])
                        {
                            maxNumber = arr[i, j];
                        }
                    }

                }
            Console.WriteLine(maxNumber);
            Console.ReadLine();
        }
    }
}
