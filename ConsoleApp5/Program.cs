using System;
using System.Collections.Generic;
using ConsoleApp5.Helper;
using ConsoleApp5.Model;
using ConsoleApp5.QuickSort;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataFromAPI da = new DataFromAPI();
            IList<Product> product= da.getProduct();

            Console.Write(product[0].Name+"\n");
            Console.Write(product[1].Name+"\n");
            Console.Write(product[2].Name+"\n");
            Console.Write(product[3].Name+"\n");
            Console.Write(product[4].Name+"\n");



            CustomSort cs = new CustomSort();
            IList<Product> p = cs.quickSort(product, 0, product.Count);
            Console.WriteLine("\n\n\n after sorting");
            Console.Write(product[0].Name + "\n");
            Console.Write(product[1].Name + "\n");
            Console.Write(product[2].Name + "\n");
            Console.Write(product[3].Name + "\n");
            Console.Write(product[4].Name + "\n");
            Console.ReadLine();
        }
    }
}
