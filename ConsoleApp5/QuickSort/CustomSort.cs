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

            if (low<high)
            {
                int pivot = partition(product, low, high);
                quickSort(product,low,pivot-1);
                quickSort(product, pivot + 1, high);
            }






            return product;
        }
        public int partition(IList<Product> product, int low, int high)
        {

            int pivot = product.Count - 1;
            int i = low - 1;
            for (int j = low; j <= high - 1; j++)
            {
                if (string.Compare(product[j].Name, product[pivot].Name) > 0)
                {
                    i++;
                    Product temp1 = product[i];
                    product[i] = product[j];
                    product[j] = temp1;
                }
            }
            //Product temp = product[i + 1];
            //product[i + 1] = product[high-1];
            //product[high-1] = temp;



            return i+1;
        }

    }
}
