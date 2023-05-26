using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Product Added! Product Name : " + product.name + " - " + "Product Description : " + product.description + " - " + "Product Price : " + product.price + " - " + "Product Stock Quantity : " + product.stockQuantity);
        }
    }
}
