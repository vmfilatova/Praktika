using System;

using System.Collections.Generic;


// Узел двоичного дерева

public class Node

{
    public int data;
    public Node left, right;
    public Node(int d)

    {
        data = d;
        left = right = null;
    }
}



public class BinarySearchTree

{
    // Корень BST
    public Node root;
    // Конструктор

    public BinarySearchTree()
    {
        root = null;
    }
// По обходу дерева

    public virtual void inorder()
    {
        inorderUtil(this.root);
    }

    // Сервисная функция для обхода дерева по порядку
    public virtual void inorderUtil(Node node)
    {
        if (node == null)
        {
            return;
        }
        inorderUtil(node.left);
        Console.Write(node.data + " ");
        inorderUtil(node.right);
    }

    // Служебный метод, который хранит обход дерева по порядку

    public virtual List<int> storeInorderUtil(Node node, List<int> list)
    {
        if (node == null)
        {
            return list;
        }
        // возвращаемся слева
        storeInorderUtil(node.left, list);
        // Добавляет данные в список
        list.Add(node.data);
        // вернемся к правильному ребенку
        storeInorderUtil(node.right, list);
        return list;
    }
    // Метод, который хранит обход дерева по порядку

    public virtual List<int> storeInorder(Node node)
    { 
        List<int> list1 = new List<int>();

        List<int> list2 = storeInorderUtil(node, list1);

        return list2;
    }
    // Метод, который объединяет два ArrayLists в один.
    public virtual List<int> merge(List<int> list1, List<int> list2, int m, int n)
    {
        // list3 будет содержать слияние list1 и list2
        List<int> list3 = new List<int>();
        int i = 0;
        int j = 0;
        // Обход через оба ArrayLists
        while (i < m && j < n)
        {
            // Меньший входит в list3
           if (list1[i] < list2[j])
            {
                list3.Add(list1[i]);
                i++;
            }
            else
            {
                list3.Add(list2[j]);
                j++;
            }
        }
        // Добавляет остальные элементы list1 в list3
        while (i < m)
        {
            list3.Add(list1[i]);
            i++;
        }
        // Добавляет остальные элементы list2 в list3
        while (j < n)
        {
            list3.Add(list2[j]);
            j++;
        }
        return list3;
    }

    // Метод, который преобразует ArrayList в BST
    public virtual Node ALtoBST(List<int> list, int start, int end)
    {
        // Базовый вариант
        if (start > end)
        {
            return null;
        }

        // Получить средний элемент и сделать его корневым
        int mid = (start + end) / 2;
        Node node = new Node(list[mid]);
        node.left = ALtoBST(list, start, mid - 1);
        node.right = ALtoBST(list, mid + 1, end);
        return node;
    }

    // Метод, который объединяет два дерева в одно.
    public virtual Node mergeTrees(Node node1, Node node2)
    {
        // Сохраняет порядок дерева tree1 в list1
        List<int> list1 = storeInorder(node1);
        // Сохраняет порядок дерева tree2 в list2
        List<int> list2 = storeInorder(node2);
        // Объединяет list1 и list2 в list3
        List<int> list3 = merge(list1, list2, list1.Count, list2.Count);
        // В конечном итоге преобразует объединенный список в результирующий BST
        Node node = ALtoBST(list3, 0, list3.Count - 1);
        return node;
    }


    public static void Main(string[] args)
    {
        BinarySearchTree tree1 = new BinarySearchTree();
        int n;
        Console.WriteLine("Введите значение узла дерева");
        while (!int.TryParse(Console.ReadLine(),out n) )
        {
            Console.WriteLine("Введите целое число");
        }
        tree1.root = new Node(n);
        tree1.root.left = new Node(50);
        tree1.root.right = new Node(300);
        tree1.root.left.left = new Node(20);
        tree1.root.left.right = new Node(70);
        BinarySearchTree tree2 = new BinarySearchTree();
        tree2.root = new Node(80);
        tree2.root.left = new Node(40);
        tree2.root.right = new Node(120);
        BinarySearchTree tree = new BinarySearchTree();
        tree.root = tree.mergeTrees(tree1.root, tree2.root);
        Console.WriteLine("Объединенное дерево: ");

        tree.inorder();
        Console.ReadLine();

    }

}