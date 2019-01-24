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
            for (int i =0;i<product.Count;i++)
                Console.Write(product[i].Name+"\n");
            



           
           QS.QuickSort(product, 0, product.Count-1);
            Console.WriteLine("\nAfter sorting");
            for (int i = 0; i < product.Count; i++)
                Console.Write(product[i].Name + "\n");




           
            Console.ReadLine();
         
        }
    }
}
