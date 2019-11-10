using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO
{
    public enum ProductType { Digitaal, Fysiek };
    public abstract class Product
    {
        public string naam;
        public ProductType productType;
        public double prijs;
        public string beschrijving;
        public abstract string Randomstringgenerator(string naam, int rnd);
    }
    
}
