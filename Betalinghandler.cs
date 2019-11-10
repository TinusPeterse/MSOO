using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO
{
	public class Betalinghandler
	{
		public bool Probeerbetaling(string setting, bool wagentjeIsLeeg)
		{
            if (setting == "succes" && !wagentjeIsLeeg) return true;
			if (wagentjeIsLeeg) Console.WriteLine("Uw winkelmandje is leeg, voeg eerst iets toe");
			return false;
		}
	}
}
