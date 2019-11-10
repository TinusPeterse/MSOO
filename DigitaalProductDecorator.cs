using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO
{
    class DigitaalProductDecorator: EmailDecorator
    {
        public override string Print(Product product, int amount, int rnd)
        {
            string print = product.naam + " hoeveelheid : " + amount.ToString() + " beschrijving : " + product.beschrijving;
            for (int i = amount; i > 0; i--) { print += " downloadlink : " + product.Randomstringgenerator(product.naam, rnd+i); };
            return print;
        }
    }
}
