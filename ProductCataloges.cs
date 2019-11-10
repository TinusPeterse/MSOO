using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO
{
    public class ProductCataloges
    {
        public List<Product> AlleProducten = new List<Product>();
        public void BeschrijfAlleProducten()
        {
            int i = 1;
            foreach (Product product in AlleProducten)
            {
                Console.WriteLine(i.ToString() + "." + product.naam + " " + product.prijs );
                i++;
            }
        }
        public void HaalproductenUitDatabase()
        {
            string[] producten = System.IO.File.ReadAllLines(@"..\..\producten.txt");
            foreach (string product in producten)
            {
                string[] eigenschappen = product.Split(' ');

                if (eigenschappen[1] == "Digitaal")
                {
                    DigitaalProduct digitaalProduct = new DigitaalProduct(eigenschappen[0], ProductType.Digitaal, Convert.ToDouble(eigenschappen[2], CultureInfo.InvariantCulture), eigenschappen[3]);
                    AlleProducten.Add(digitaalProduct);
                }
                else if (eigenschappen[1] == "Fysiek")
                {
                    FysiekProduct fysiekProduct = new FysiekProduct(eigenschappen[0], ProductType.Fysiek, Convert.ToDouble(eigenschappen[2], CultureInfo.InvariantCulture), eigenschappen[3]);
                    AlleProducten.Add(fysiekProduct);
                }
                else { Console.WriteLine("ErrorInDataBase"); }
            }
        }
    }
}
