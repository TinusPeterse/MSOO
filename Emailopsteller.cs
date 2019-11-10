using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO
{
    class Emailopsteller
    {
        public List<String> PrintEmail(Dictionary<Product,int> keyValuePairs, List<Product> products)
        {
            List<string> totalemail = new List<string>();
            BasisEmail s = new BasisEmail();
            totalemail.Add(s.Print()[0]);
            Random rnd = new Random();
            foreach (Product product in products)
            {
                string blub;
                switch (product.productType)
                {
                    case ProductType.Digitaal:
                        {
                            DigitaalProductDecorator digitaalProductDecorator = new DigitaalProductDecorator();
                            blub = digitaalProductDecorator.Print(product,keyValuePairs[product],rnd.Next());
                            break;
                        }
                    case ProductType.Fysiek:
                        {
                            FysiekProductDecorator fysiekProductDecorator = new FysiekProductDecorator();
                            blub = fysiekProductDecorator.Print(product, keyValuePairs[product],rnd.Next());
                            break;
                        }
                    default: // Is er alleenmaar zodat ik totaleemail.add(blub) kan doen.
                        {
                            blub = "Error producttype not found";
                            break;
                        }
                }
                totalemail.Add(blub);
            }
            totalemail.Add(s.Print()[1]);
            return totalemail; 
        }
    }
}
