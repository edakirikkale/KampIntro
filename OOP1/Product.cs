using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet - 2kez tab ( özellikler )
    class Product
    {

        public int Id { get; set; }
        public int CategoryId { get; set; }// dahil olduğu kategori- referans alanları

        public String ProductName  { get; set; } // ÜRÜN ADI
        public double    UnitPrice { get; set; } // ÜRÜN FİYATI
        public int UnitsInStock { get; set; } // stok adedi


    }
}
