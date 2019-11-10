using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO
{
    public class DigitaalProduct: Product
    {
        public DigitaalProduct(string _naam, ProductType _productType, double _prijs, string _beschrijving)
        {
            naam = _naam;
            productType = _productType;
            prijs = _prijs;
            beschrijving = _beschrijving;
        }
        Random rnd = new Random();
        public string Randomstringgenerator()
        {
            return "randomstring*/"+naam+"/"+rnd.ToString();
        }
    }
}
