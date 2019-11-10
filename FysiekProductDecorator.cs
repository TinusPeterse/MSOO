using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO
{
    class FysiekProductDecorator:EmailDecorator
    {
        public override string Print(Product product,int amount,int blub)
        {
            string print = product.naam + " hoeveelheid : " + amount.ToString() +" beschrijving : " + product.beschrijving;
            return print;
        }
    }
}
