using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ProductCataloges productCataloges = new ProductCataloges();
            productCataloges.HaalproductenUitDatabase();
            int i = 1;
            foreach (Product product in productCataloges.AlleProducten)
            {
                Console.WriteLine(i.ToString() + "." + product.naam);
                i++;
            }
            Console.ReadLine();
        }
    }
}
