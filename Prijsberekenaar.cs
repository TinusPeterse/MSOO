using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO
{
	class Prijsberekenaar
	{
        public bool VerzendkostenToegevoegd = false;
		private double verzendkosten = 4.95;
		public double Berekenprijs(Dictionary<Product, int> dic, List<Product> list)
		{
			double Prijs = 0;
            foreach (Product a in list)
            {
                Prijs += a.prijs * dic[a];
                if (a.productType == ProductType.Fysiek)
                {
                    if (VerzendkostenToegevoegd)
                    {
                        Prijs += verzendkosten;
                        VerzendkostenToegevoegd = true;
                    }
                }
            }
			return Prijs;
		}
	}
}
