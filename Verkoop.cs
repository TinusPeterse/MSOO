using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO
{
    enum Stage { Shopping, Paying, Email }
    class Verkoop
    {
        public WinkelWagentje winkelWagentje = new WinkelWagentje();
        private Betalinghandler betalinghandler = new Betalinghandler();
        public Emailopsteller emailopsteller = new Emailopsteller();
        public Stage stage = Stage.Shopping;
        public void HandleInput(string input)
        {
            switch (stage)
            {
                case Stage.Shopping:
                {
                    switch (input)
                    {
                        case "add item":
                            {
                                winkelWagentje.Add(winkelWagentje.productCataloges.AlleProducten[checkedStringToInt() - 1], AmountRequested());
                                Console.WriteLine("item succesfully added to cart");
                                break;
                            }
                        case "print cart":
                            {
                                winkelWagentje.PrintWagentje();
                                break;
                            }
                        case "pay":
                            {
                                winkelWagentje.Betalen();
                                stage = Stage.Paying;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("wrong action please try again");
                                break;
                            }
                        }
                break;
                                        }
                case Stage.Paying:      {
                break;
                                        }
                case Stage.Email:       {
                break;
                                        }
            }
        }

        private int AmountRequested()
        {
            Console.WriteLine("Hoeveel van dit product wilt u bestellen");
            return checkedStringToInt();
        }
        private int checkedStringToInt()
        {
            bool correctInput = false;
            string input = "";
            while (!correctInput)
            {
                input = Console.ReadLine();
                int i;
                if (int.TryParse(input, out i)) correctInput = true;
            }
            return int.Parse(input);
        }
    }
}
