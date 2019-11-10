using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO
{
    public enum ProductType { Digitaal, Fysiek };
    abstract class Product
    {
        public string naam;
        public enum ProductType { Digitaal, Fysiek };
        public double price;
        public string beschrijving;
    }
}
