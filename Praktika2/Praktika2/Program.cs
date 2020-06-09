using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Size = Convert.ToInt32(Console.ReadLine());
            double [,] arr = new double [Size, 4];
            string[] strs = new string[4];
          for (int i=0;i<Size;i++)
            {
                strs = Convert.ToString(Console.ReadLine()).Split(new char[] { ' ', ':', '.' });
                for (int j = 0; j < 4; j++)
                    arr[i, j] = Convert.ToDouble(strs[j]);
            }
          for (int i=0;i<Size;i++)
            {
                for (int j=0;j<4;j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
                


        }
    }
}
