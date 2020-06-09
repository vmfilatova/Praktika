using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void dfs(int v, int [,] Array, int n, int [] Array1)
        {
            Array1[v] = 1;

            for (int i=0;i<n;i++)
            {
                if (Array[v, i] == 1 && Array1[i] == 0)
                    dfs(i, Array, n, Array1);
            }
        }
        static void Main(string[] args)
        {
            
            int n;
            Console.WriteLine("Введите размерность");
            while ( !int.TryParse(Console.ReadLine(),out n))
            {
                Console.WriteLine("Введите целое число");
            }
            int[,] Array = new int[n, n];
            int rebro = 0;
            int [] Array1 = new int[n];
            for (int i=0;i<n;i++)
            {
                for (int j=0;j<n;j++)
                {
                    Array[i, j] = Convert.ToInt32(Console.ReadLine());
                    rebro += Array[i, j];
                }
                Array1[i] = 0;
            }
            rebro = rebro / 2;
            int end=-1;
            dfs(n - 1, Array, n, Array1);
            
            for (int i=0;i<n;i++)
            {
                if (end == -1)
                {
                    if (Array1[i] == 0)
                    {
                        Console.WriteLine("Не является деревом");
                        end = 1;
                    }
                    if ((rebro == n - 1)&&(end!=1))
                    {
                        Console.WriteLine("Является деревом");
                        end = 1;
                    }
                    else
                    { if (end!=1)
                        Console.WriteLine("Не является деревом");
                        end = 1;
                    }
                    
                }
            }
            Console.ReadLine();
        }
    }
}
