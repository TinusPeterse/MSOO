using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO
{
    public class FysiekProduct:Product
    {
        public FysiekProduct(string _naam, ProductType _productType, double _prijs, string _beschrijving)
        {
            naam = _naam;
            productType = _productType;
            prijs = _prijs;
            beschrijving = _beschrijving;
        }
    }
}
