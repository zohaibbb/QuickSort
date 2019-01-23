using ConsoleApp5.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.QuickSort
{
    class CustomSort
    {
        public IList<Product> quickSort(IList<Product> product, int low, int high)

        {

            if (low < high)
            {
                string pivot = partition(product, low, high);

                quickSort(product, low,)

            }






            return product;
        }
        public string partition(IList<Product> product, int low, int high)
        {

            string pivot = product[high - 1].Name;
            int i = low - 1;
            for (int j = low; j <= high - 1; j++)
            {
                if (string.Compare(product[j].Name, pivot) <= 0)
                {
                    i++;
                    Product temp1 = product[j];
                    product[j] = product[i];
                    product[i] = temp1;
                }
            }
            Product temp = product[i + 1];
            product[i + 1] = product[high];
            product[high] = temp;



            return "";
        }

    }
}
