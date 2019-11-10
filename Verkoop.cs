using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO
{
    class Verkoop
    {
        public WinkelWagentje winkelWagentje = new WinkelWagentje();
        private Betalinghandler betalinghandler = new Betalinghandler();
        public Emailopsteller emailopsteller = new Emailopsteller();
        enum Stage {Shopping,Paying,Email }
        private Stage stage = Stage.Shopping;
        public void HandleInput(string input)
        {
            switch (stage)
            {
                case Stage.Shopping:    { break; }
                case Stage.Paying:      { break; }
                case Stage.Email:       { break; }
            }
        }
    }
}
