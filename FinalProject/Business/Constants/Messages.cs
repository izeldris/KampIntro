using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = " Ürün Eklendi ";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductListed = "Ürünler Listelendi";
        public static string ProductCountError = "Ürün Ekleme Sayısı 10 Adetten Fazla Olamaz.";
        public static string ProductNameAlreadyExists = "Bu İsimde Bir Ürün Zaten Var.";
        public static string CategoryLimitExceeded = "Kategori Limiti Aşıldı. Yeni Ürün Eklenemez.";
    }
}
