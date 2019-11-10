using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO
{
	class Betalinghandler
	{
		public bool Probeerbetaling(string setting)
		{
            if (setting == "succes") return true;
            if (setting == "failure") return false;
            else return false;
		}
	}
}
