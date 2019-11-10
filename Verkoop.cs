using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO
{
    public enum Stage { Shopping, Paying, Email, Finished }
    public class Verkoop
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
                case Stage.Paying:
                {
                    switch (betalinghandler.Probeerbetaling(input))
                    {
                        case true:
                            {
                                Console.WriteLine("De betaling was een succes");
                                stage = Stage.Email;
                                break;
                            }
                        case false:
                            {
                                Console.WriteLine("De betaling is fout gegaan");
                                Console.WriteLine("U bevindt zich nu opnieuw in het winkelwagentje");
                                stage = Stage.Shopping;
                                break;
                            }
                        }
                    break;
                }
                case Stage.Email:
                {
                    switch (input)
                    {
                        case "read email":
                        {
                            foreach (string line in emailopsteller.PrintEmail(winkelWagentje.InDeWagenDictionary, winkelWagentje.InDeWagenList))
                            {
                                Console.WriteLine(line);
                            }
                            stage = Stage.Finished;
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
