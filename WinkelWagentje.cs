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
		public bool Leegwinkelwagentje = true;
		public bool HeeftFysiekProduct = false;
		public double Prijs = 0;
        public void Add(int number)
        {
			Leegwinkelwagentje = false;
			Product currentProduct = productCataloges.AlleProducten[number];
			if (currentProduct.productType == ProductType.Fysiek) HeeftFysiekProduct = true;
			Console.WriteLine("Hoeveel zou u er willen?");
			int amount = Convert.ToInt32(Console.ReadLine());
			if (InDeWagenDictionary.ContainsKey(currentProduct))			// Als je iets bijbesteld wordt de orderregels samengevoegd
			{
				amount += InDeWagenDictionary[currentProduct];
				InDeWagenDictionary.Remove(currentProduct);
				InDeWagenList.Remove(currentProduct);
			}

            InDeWagenList.Add(currentProduct);
            InDeWagenDictionary.Add(currentProduct, amount);
        }
        public void PrintWagentje()
        {
            Console.WriteLine("Uw order to zo ver : ");
            foreach (Product product in InDeWagenList)
            {
                Console.WriteLine(product.naam + " U heeft hier zoveel van besteld : "  + InDeWagenDictionary[product]);
            }
        }
		public void Betalen()
		{
			foreach (Product a in InDeWagenList)
				Prijs += a.prijs * InDeWagenDictionary[a];
			Console.Clear();
			PrintWagentje();
			Console.WriteLine("Uw totaal bedrag is : " + Prijs.ToString());
			Console.ReadLine();
		}
    }
}
