using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Product
    {
        public Product()
        {
            Totalcount++;
            No = Totalcount;
        }
        static int Totalcount;
        public int No { get;}
        public string Name { get; set; }
        public double Price { get; set; }
        public ProductType Type { get; set; }
        public override string ToString()
        {
            return $"mehsulun nomresi: {No} - adi: {Name} - qiymeti: {Price} - tipi: {Type}";
        }

    }
}
