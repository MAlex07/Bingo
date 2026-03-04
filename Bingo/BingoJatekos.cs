using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
	internal class BingoJatekos
	{
		private string nev;
		private int[,] kartya;

		
		public int[,] Kartya { get => kartya; set => kartya = value; }
		public string Nev { get => nev; set => nev = value; }

		public BingoJatekos(string nev, int[,] kartya)
		{
			this.nev = nev;
			this.kartya = kartya;
		}

		public void Megjelenit()
		{
			for (int i = 0; i < ; i++)
			{

			}
		}
	}
}
