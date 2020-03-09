using System;
using EstructurasDeDatos.ListaEnlazada;

namespace InvertirListaEnlazada
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Console.Write("Digite la cantidad de ITEMS: ");
            int cantidad = int.Parse(Console.ReadLine());
            int item, searchItem;

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Item #{ i + 1}: ");
                item = int.Parse(Console.ReadLine());
                linkedList.AddItem(item);
            }
            Console.Write("ITEM a buscar: ");
            searchItem = int.Parse(Console.ReadLine());

            Node node = linkedList.Head;

            while (node != null)
            {
                Console.Write(node.Value + " -> ");
                node = node.Next;
            }
            Console.WriteLine("");
            LinkedList linkedList1 = new LinkedList();
            linkedList1.AddItem(searchItem);
            int x = 0;
            node = linkedList.Head;

            while (node != null)
            {
                if (node.Value != searchItem)
                {
                    x++;
                    node = node.Next;
                }
                else
                {
                    node = null;
                }
            }

            int restante = cantidad - x;
            int[] arreglo1 = new int[x];
            int[] arreglo2 = new int[restante];
            node = linkedList.Head;
            x = 0;
            restante = 0;

            while (node != null)
            {
                if (node.Value != searchItem)
                {
                    if (x < arreglo1.Length)
                    {
                        arreglo1[x] = node.Value;
                        x++;
                    }
                    else
                    {
                        arreglo2[restante] = node.Value;
                        restante++;
                    }
                }
                node = node.Next;
            }
            int z = arreglo1.Length;
            for (int i = 0; i < cantidad; i++)
            {
                if (i < arreglo2.Length - 1)
                {
                    linkedList1.AddItem(arreglo2[i]);
                }
                else if (z >= 1)
                {
                    z--;
                    linkedList1.AddItem(arreglo1[z]);
                }

            }

            node = linkedList1.Head;
            while (node != null)
            {
                Console.Write(node.Value + " -> ");
                node = node.Next;
            }
        }
    }
}
