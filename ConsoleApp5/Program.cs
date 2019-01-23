using System;
using System.Collections.Generic;
using ConsoleApp5.Helper;
using ConsoleApp5.Model;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataFromAPI da = new DataFromAPI();
            IList<Product> product= da.getProduct();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
