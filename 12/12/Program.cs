using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void BucketSort(int[] a, int k)
        {
            // Примем, что количество корзин равно количеству элементов в массиве-источнике.
            // Тогда:
            // массив корзин
            List<int>[] aux = new List<int>[a.Length];

            // каждую корзину проинициализировать
            for (int i = 0; i < aux.Length; ++i)
                aux[i] = new List<int>();

            // найти диапазон значений в массиве-источнике
            int minValue = a[0];
            int maxValue = a[0];

            for (int i = 1; i < a.Length; ++i)
            {
                if (a[i] < minValue)
                {
                    minValue = a[i];
                    k++;
                }
                else if (a[i] > maxValue)
                {
                    maxValue = a[i];
                    k++;
                }
            }

            // эта величина будет использоваться a.Length раз, поэтому имеет смысл её сохранить.
            double numRange = maxValue - minValue;

            for (int i = 0; i < a.Length; ++i)
            {
                // вычисление индекса корзины
                int bcktIdx = (int)Math.Floor((a[i] - minValue) / numRange * (aux.Length - 1));

                // добавление элемента в соответствующую корзину
                aux[bcktIdx].Add(a[i]);
            }

            // сортировка корзин. Здесь я использую библиотечную сортировку
            for (int i = 0; i < aux.Length; ++i)
                aux[i].Sort();

            // собираем отсортированные элементы обратно в массив-источник
            int idx = 0;

            for (int i = 0; i < aux.Length; ++i)
            {
                for (int j = 0; j < aux[i].Count; ++j)
                    a[idx++] = aux[i][j];
            }
        }
        //метод для обмена элементов массива
        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        //метод возвращающий индекс опорного элемента
        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        //быстрая сортировка
        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        static int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }

        static void Main()
        {
            int[] arr = new int[15];
            Random rnd = new Random();
            int k1 =0, k2=0;
            for (int i = 0; i < arr.Length; ++i)
                arr[i] = rnd.Next(-99, 100);

            Console.WriteLine(String.Join(" ", arr));
            BucketSort(arr,k1);
            Console.WriteLine("Былочная сортировка: {0}", String.Join(" ", arr));
            Console.WriteLine("Количество пересылок: {0}", k1);
            Console.WriteLine("Быстрая сортировка: {0}", string.Join(" ", QuickSort(arr)));
            Console.ReadLine();
        }
    }
}
