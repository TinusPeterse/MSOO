using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO
{
    class ShopUI
    {
        static void Main()
        {
            Verkoop verkoop = new Verkoop();
            verkoop.winkelWagentje.productCataloges.HaalproductenUitDatabase();
            Console.WriteLine("Welkom in SexShopXX");
            verkoop.winkelWagentje.productCataloges.BeschrijfAlleProducten();
            while (verkoop.stage != Stage.Finished)
            {
                verkoop.HandleInput(Console.ReadLine());
            }
            Console.WriteLine("The end");
            Console.ReadLine();
        }
    }
}
