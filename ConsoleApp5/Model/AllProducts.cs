using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.Model
{
    class AllProducts
    {
        bool status;
        string message;
        List<Product> product;

        public bool Status { get => status; set => status = value; }
        public string Message { get => message; set => message = value; }
        public List<Product> Product { get => product; set => product = value; }
    }
}
