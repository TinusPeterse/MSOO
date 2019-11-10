using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO
{
    class WinkelWagentje
    {
        public ProductCataloges productCataloges = new ProductCataloges();
        public Dictionary<Product, int> InDeWagenDictionary = new Dictionary<Product, int>();
        public List<Product> InDeWagenList = new List<Product>();
        public void Add(int number)
        {
            Console.WriteLine("Hoeveel zou u er willen?");
            int amount = Convert.ToInt32(Console.ReadLine());
            InDeWagenList.Add(productCataloges.AlleProducten[number]);
            InDeWagenDictionary.Add(productCataloges.AlleProducten[number], amount);
        }
        public void PrintWagentje()
        {
            Console.WriteLine("Uw order to zo ver : ");
            foreach (Product product in InDeWagenList)
            {
                Console.WriteLine(product.naam + " U heeft hier zoveel van besteld : "  + InDeWagenDictionary[product]);
            }
        }
    }
}
