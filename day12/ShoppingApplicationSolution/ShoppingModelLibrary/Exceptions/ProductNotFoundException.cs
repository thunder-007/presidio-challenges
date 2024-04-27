﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingModelLibrary.Exceptions
{
    public class ProductNotFoundException : Exception
    {
        string message;
        public ProductNotFoundException()
        {
            message = "Product with the given Id is not present!";
        }
        public ProductNotFoundException(string msg)
        {
            message = msg;
        }
        public override string Message => message;
    }
}
