using ConsoleApp5.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ConsoleApp5.Helper
{
    class DataFromAPI
    {
        public IList<Product> getProduct()
        {
            IList<Product> product = null;
            using (var webClient = new WebClient())
            {

                String json = webClient.DownloadString("https://fulda-buyandsell.herokuapp.com/api/products");
                AllProducts data = JsonConvert.DeserializeObject<AllProducts>(json);       //Add newtonsoftJson from nuget package manager



                 product = data.Product;











                Console.Write(product[0].Name);

            }
            return product;

        }
        


    }
}
