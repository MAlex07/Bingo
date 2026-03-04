using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
	internal class BingoJatekos
	{
		private List<string> nev;
		private char[,] kartya;

		public List<string> Nev { get => nev; set => nev = value; }
		public char[,] Kartya { get => kartya; set => kartya = value; }

		public BingoJatekos(List<string> nev, char[,] kartya)
		{
			this.nev = nev;
			this.kartya = kartya;
		}

		private void Beolvas(string fajlnev)
		{
			foreach (var sor in File.ReadAllLines(fajlnev))
			{
				this.nev.Add(sor);
			}
		}
	}
}
