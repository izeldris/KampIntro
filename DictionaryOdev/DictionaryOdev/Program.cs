using System;
using System.Collections.Generic;

namespace DictionaryOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            OwnDictionary<int, string> cities = new OwnDictionary<int, string>();
            cities.Add(34, "İstanbul");
            cities.Add(50, "Nevşehir");
            cities.Add(06, "Ankara");
            cities.Add(38, "Kayseri");

            cities.ItemShow();

            

        }
    }
}
