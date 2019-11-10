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
            WinkelWagentje winkelWagentje = new WinkelWagentje();
            winkelWagentje.productCataloges.HaalproductenUitDatabase();
            winkelWagentje.productCataloges.BeschrijfAlleProducten();
            winkelWagentje.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("TheEndForNow");
            Console.ReadLine();
        }
    }
}
