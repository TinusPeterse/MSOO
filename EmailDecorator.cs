using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO
{
    abstract class EmailDecorator
    {
        abstract public string Print(Product product, int amount, int rnd);
    }
}
