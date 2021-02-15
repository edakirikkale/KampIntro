using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {   //encapsulation             // void = git demek - emir kipi  void add = git ekle 
        public void  Add(Product product) // ekleme
        {
            Console.WriteLine(product.ProductName+ " eklendi.");
        }
        public void Update (Product product) // güncellme
        {
            Console.WriteLine(product.ProductName + " güncellendi.");

        }

      
    }
}
