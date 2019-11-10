using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO
{
    class DigitaalProduct: Product
    {
        Random rnd = new Random();
        public string Randomstringgenerator()
        {
            return "randomstring*/"+naam+"/"+rnd.ToString();
        }
    }
}
