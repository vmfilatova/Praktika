using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    
    class Program
    {
        struct Cart 
        {
            public int mouth;
            public int day;
            public int hour;
            public int minute;
        }
            class CartComparer : IComparer<Cart>
            {
                public int Compare(Cart c1, Cart c2)
                {
                if (c1.mouth > c2.mouth)
                    return 1;
                else if (c1.mouth < c2.mouth)
                    return -1;
                else return 0;

                }
            }
        
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите количество карточек");
            while (!int.TryParse(Console.ReadLine(), out n)||(n%2!=0))
            {
                Console.WriteLine("Введите целое положительное четное число");
            }
            Cart c;
            c.mouth = 0;
            int[,] Matrix = new int[n, 1];
            for (int i=0;i<n;i++)
            {
                Console.WriteLine("Введите значение карточки: ");
                string text = Console.ReadLine();
                string[] str = text.Split(new Char[] { ' ',  '.', ':' }, StringSplitOptions.RemoveEmptyEntries);
             
                c.mouth = Convert.ToInt32(String.Format("{0:#0}", str[1]));
                c.day = Convert.ToInt32(String.Format("{0:#0}", str[0]));
                c.hour = Convert.ToInt32(str[2]);
                c.minute = Convert.ToInt32(String.Format("{0:#0}", str[3]));
                
            }
            Console.WriteLine(c.mouth);
            Console.ReadLine();
        }
    }
}
