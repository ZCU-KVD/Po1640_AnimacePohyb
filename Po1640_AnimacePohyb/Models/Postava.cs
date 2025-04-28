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
		
		private bool smerVpred = true; 
		private bool HlavaVpravo { get; set; } = true;
		public string TransformRotateY => HlavaVpravo ? "transform: rotateY(0deg);" : "transform: rotateY(180deg);";
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
			if (AktualniPozice == 0)
			{
				smerVpred = true;
			}
			else if (AktualniPozice >= PoziceList.Count - 1)
			{
				smerVpred = false;
			}
			var predchoziPozice = AktualniPozice;
			AktualniPozice += smerVpred ? 1 : -1;
			if(predchoziPozice>=0)
				HlavaVpravo = PoziceList[predchoziPozice].PozX < PoziceList[AktualniPozice].PozX;
		}
		#endregion
	}
}
