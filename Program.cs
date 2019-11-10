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
			bool done = false;
            WinkelWagentje winkelWagentje = new WinkelWagentje();
            winkelWagentje.productCataloges.HaalproductenUitDatabase();
			winkelWagentje.productCataloges.BeschrijfAlleProducten();
			while (!done)
			{
				
				string input = Console.ReadLine();
				int amount;
				if (int.TryParse(input, out amount))
				{
					winkelWagentje.Add(Convert.ToInt32(amount - 1));
					Console.Clear();
					winkelWagentje.productCataloges.BeschrijfAlleProducten();
				}
				else
					switch (input)
					{
						case "d":
							done = true;
							winkelWagentje.Betalen();
							break;
						case "w":
							winkelWagentje.PrintWagentje();
							break;
					}
			}
            Console.WriteLine("TheEndForNow");
            Console.ReadLine();
        }
    }
}
