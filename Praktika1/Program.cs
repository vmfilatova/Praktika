using System;


namespace Praktika1
{
    class Program
    {
        static void Main(string[] args)
        {
            int chilso = Convert.ToInt32(Console.ReadLine());       // число в десятичной
            int osnov =3;  // основание числа
            string result = "";     // переменная для результата
            int temp;

            if (chilso > 0)     // условие, что число больше 0
                while (chilso > (osnov + 1))   // цикл, пока число больше самого основания
                {
                    if ((chilso % osnov) != 0)
                        temp = chilso % osnov;
                    else temp = osnov;
                    chilso = (chilso - temp) / osnov;
                    result = Convert.ToString(temp) + result;
                }

            result = Convert.ToString(chilso) + result;
            Console.WriteLine(result);
            Console.ReadLine();  // задержка экрана
        }
    }
}
