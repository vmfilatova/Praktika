using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Praktika4
{
    class Program
    {
        private const double E = 0.001;
        static void Main(string[] args)
        {
            double begin = 1;
            double end = 1.5;
            if (CheckExtreme(F(begin)) || CheckExtreme(F(end)))
                return;

            double dx = end - begin;
            double avg = (begin + end) / 2;
            while (Math.Abs(F(avg)) > E)
            {
                dx /= 2;
                avg = begin + dx;
                if (Math.Sign(F(begin)) == Math.Sign(F(avg)))
                    begin = avg;
            }

            Console.WriteLine(avg);
            Console.ReadLine();
        }

        private static bool CheckExtreme(double value)
        {
            if (Math.Abs(F(value) - 0) < E)
            {
                Console.WriteLine(value);
                return true;
            }
            return false;
        }

        private static double F(double x)
        {
            return x*x*x - 0.2*x*x-0.2*x-1.2;
        }
    }
    }

