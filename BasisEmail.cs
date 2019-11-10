using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO
{
    class BasisEmail
    {
        string standaardopening = "U heeft de volgende producten besteld bij SexShopXX ";
        string standaardsluiting = "Wij wensen u prettige dag toe. ";
        public string[] Print()
        {
            string[] print = new string[1];
            print[0] = standaardopening;
            print[1] = standaardsluiting;
            return print;
        }
    }
}
