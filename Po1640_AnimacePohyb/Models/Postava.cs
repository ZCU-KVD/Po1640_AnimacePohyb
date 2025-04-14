namespace Po1640_AnimacePohyb.Models
{
	public class Postava
	{
		public Postava(string obrazek, string jmeno, int width)
		{
			Obrazek = obrazek;
			Jmeno = jmeno;
			ObrazekWidthDefault = width;
		}
		#region Vlastnosti
		public string Obrazek { get; }
		public string Jmeno { get; }
		public int AktualniPozice { get; private set; } = -1;
		private int ObrazekWidthDefault { get; }

		private List<Pozice> PoziceList { get; } = new List<Pozice>();

		public string Style
		{
			get
			{
				if (AktualniPozice < 0)
				{
					return $"width: {ObrazekWidthDefault}px;";
				}
				else
				{
					var pozicePom = PoziceList[AktualniPozice];
					return $"{pozicePom.Style} width: {ObrazekWidthDefault * pozicePom.VelikostObrProcenta/100}px;";
				}
			}
		}
		#endregion

		#region Metody
		public void PridejPozici(int pozX, int pozY, int velikostObrProcenta, int viditelnostProcenta)
		{
			var poziceNew = new Pozice(pozX,pozY,velikostObrProcenta,viditelnostProcenta);
			PoziceList.Add(poziceNew);
		}

		public void Presun()
		{ 
			AktualniPozice += 1;
		}
		#endregion
	}
}
