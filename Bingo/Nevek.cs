using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
	internal class Nevek
	{
		public List<string> neveklista;

		public Nevek(List<string> nevek)
		{
			this.neveklista = nevek;
		}

		public List<string> Neveklista { get => neveklista; set => neveklista = value; }

		private void Beolvas()
		{
			foreach (var sor in File.ReadAllLines("nevek.txt"))
			{
				this.neveklista.Add(sor);
			}
		}
	}
}
