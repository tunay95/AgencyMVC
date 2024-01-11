using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Business.Exceptions
{
    public class ProductNullException : Exception
    {

        public ProductNullException() : base("Product should not be null")
        {

        }
        public ProductNullException(string message) : base(message)
        {

        }
    }
}

