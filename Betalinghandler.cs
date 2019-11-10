using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO
{
	class Betalinghandler
	{
		public WinkelWagentje winkelWagentje;
		public string Probeerbetaling(string setting)
		{
			if (setting == "success") return Betalinggelukt();
			if (setting == "failure") return Betalingmislukt();
			else return "Parse error";
		}
		private string Betalingmislukt()
		{
			return "faal";
		}
		private string Betalinggelukt()
		{
			return "success";
		}
	}
}
