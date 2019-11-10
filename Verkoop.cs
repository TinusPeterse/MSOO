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
                                Console.WriteLine("please fill in the number of the item you want");
                                winkelWagentje.Add(winkelWagentje.productCataloges.AlleProducten[checkedStringToInt() - 1], AmountRequested());
                                break;
                            }
                        case "print cart":
                            {
                                winkelWagentje.GetMyPrice(); // Dit roept niet het betalen aan en print alleen de cart
                                                          // Verwarrende naam I know.
                                Console.WriteLine("");
                                winkelWagentje.productCataloges.BeschrijfAlleProducten();
                                break;
                            }
                        case "pay":
                            {
                                if (winkelWagentje.HeeftFysiekProduct)
                                { AskAdres(); }
                                winkelWagentje.GetMyPrice();
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
                    switch (betalinghandler.Probeerbetaling(input, winkelWagentje.Leegwinkelwagentje))
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
                            foreach (string line in emailopsteller.PrintEmail(winkelWagentje.InDeWagenDictionary, winkelWagentje.InDeWagenList,postcode,huisnummer))
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
                else { Console.WriteLine("Parse error"); }
            }
            return int.Parse(input);
        }
        public string postcode = "0000AA";
        public int huisnummer = 0;
        public void AskAdres()
        {
            Console.WriteLine("For your orderd physical products please fill in your address");
            Console.WriteLine("Postcode : ");
            postcode = Console.ReadLine();
            Console.WriteLine("huisnummer : ");
            huisnummer = checkedStringToInt();
        }
    }
}
