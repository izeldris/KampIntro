using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        //Ürün Kimliği
        public int  Id { get; set; }
        //Kategori Numarası
        public int CategoryId { get; set; }
        //Ürün Adı
        public string ProductName { get; set; }
        //Birim Fiyat
        public double UnitPrice { get; set; }
        //Stok Adedi
        public int UnitInStock { get; set; }



    }
}
