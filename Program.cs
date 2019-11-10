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
            Console.WriteLine("Welkom in SexShopXX");
            while (verkoop.stage != Stage.Email)
            {
                verkoop.winkelWagentje.productCataloges.BeschrijfAlleProducten();
                verkoop.HandleInput(Console.ReadLine());
            }
        }
    }
}
