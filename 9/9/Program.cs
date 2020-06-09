﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InputHelper;

namespace _9
{
    class Program
    {
        static void PrintTask()
        {
            Console.WriteLine("Задача 9\n=================");
            Console.WriteLine("Напишите рекурсивный метод создания линейного списка,\n" +
                              "в информационные поля элементов которого последовательно заносятся номера с 1 до N(N водится с клавиатуры).\n" +
                              "Элементы включаются в список в порядке возрастания:\n" +
                              "в информационном поле первого элемента списка должно быть записано минимальное значение, а последнего элемента – максимальное.\n" +
                              "Разработайте рекурсивные методы поиска и удаления элементов списка.\n" +
                              "=================");
        }
        static void Main(string[] args)
        {
            PrintTask();
            int n = Input.ReadInt("Введите целое число, до которого требуется создать список: ", 1);

            Node root = new Node();
            root = Node.CreateList(root, 1, n);
            Menu(root);
        }

        static void Menu(Node root)
        {
            Console.Clear();
            PrintTask();
            Console.WriteLine("Линейный список: ");
            Node.PrintList(root);
            Console.WriteLine("Выберите действие:\n" +
                              "1. Найти элемент в списке\n" +
                              "2. Удалить элемент из списка\n" +
                              "3. Выйти из программы");
            int input = Input.ReadInt(1, 3);
            switch (input)
            {
                case 1:
                    Console.Clear();
                    int numberToSearch = Input.ReadInt("Введите число, которое хотите найти в списке: ", 1);
                    Node foundElement = Node.Search(root, numberToSearch);
                    if (foundElement == null)
                        Console.WriteLine("Элемент не найден.");
                    else
                        Console.WriteLine($"Элемент найден! Число: {foundElement.Data}");

                    Console.ReadLine();
                    Menu(root);
                    break;
                case 2:
                    Console.Clear();
                    int numberToDelete = Input.ReadInt("Введите число, которое хотите удалить из списка: ", 1);
                    Node changedRoot = Node.Remove(root, numberToDelete);
                    Console.WriteLine("Элемент удален, если он был в списке. Иначе, список остался без изменений.");
                    Console.ReadLine();
                    Menu(changedRoot);
                    break;
                case 3:
                    return;
            }
        }
    }
}
