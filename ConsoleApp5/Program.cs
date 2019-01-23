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

            CustomSort cs = new CustomSort();
            IList<Product> p = cs.quickSort(product, 0, product.Count);


            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
