using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO
{
	public class WinkelWagentje
	{
		public ProductCataloges productCataloges = new ProductCataloges();
		public Dictionary<Product, int> InDeWagenDictionary = new Dictionary<Product, int>();
		public List<Product> InDeWagenList = new List<Product>();
        public Prijsberekenaar prijsberekenaar = new Prijsberekenaar();
		public bool Leegwinkelwagentje = true;
		public bool HeeftFysiekProduct = false;
		public double Prijs = 0;
		public void Add(Product currentProduct, int amount)
		{
			Leegwinkelwagentje = false;
			if (currentProduct.productType == ProductType.Fysiek) HeeftFysiekProduct = true;
			if (InDeWagenDictionary.ContainsKey(currentProduct))            // Als je iets bijbesteld wordt de orderregels samengevoegd
			{
				amount += InDeWagenDictionary[currentProduct];
				InDeWagenDictionary.Remove(currentProduct);
				InDeWagenList.Remove(currentProduct);
			}
			if (amount < 1) Console.WriteLine("Je kan niet minder dan één product bestellen");
			else AddToCart(currentProduct, amount);
		}
		
		private void AddToCart(Product currentProduct, int amount)
		{
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
            Prijs = prijsberekenaar.Berekenprijs(InDeWagenDictionary, InDeWagenList);
			Console.Clear();
			PrintWagentje();
			Console.WriteLine("Uw totaal bedrag is : " + Prijs.ToString());
		}
    }
}
