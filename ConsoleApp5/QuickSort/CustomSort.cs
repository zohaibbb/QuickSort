using ConsoleApp5.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.QuickSort
{
    class CustomSort
    {
        public IList<Product> quickSort(IList<Product> product, string low, string high)

        {

            if (string.Compare(low,high)<0)
            {
                string pivot = partition(product, low, high);

             

            }






            return product;
        }
        public string partition(IList<Product> product, string low, string high)
        {

            string pivot = high;
            int i = low - 1;
            for (int j = low; j <= high - 1; j++)
            {
                if (string.Compare(product[j].Name, pivot) <= 0)
                {
                    i++;
                    Product temp1 = product[i];
                    product[i] = product[j];
                    product[j] = temp1;
                }
            }
            Product temp = product[i + 1];
            product[i + 1] = product[high-1];
            product[high-1] = temp;



            return (product[i+1].Name);
        }

    }
}
