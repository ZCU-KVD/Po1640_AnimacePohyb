namespace Po1640_AnimacePohyb.Models
{
	public class Pozice
	{
		public Pozice(int pozX, int pozY, int velikostObrProcenta, int viditelnostProcenta)
		{
			PozX = pozX;
			PozY = pozY;
			VelikostObrProcenta = velikostObrProcenta;
			ViditelnostProcenta = viditelnostProcenta;
		}

		public int PozX { get;  }
		private int PozY { get;  }
		public int VelikostObrProcenta { get; }
		private int ViditelnostProcenta { get; }

		public string Style
		{
			get
			{
				return $"left: {PozX}px; top: {PozY}px; opacity: {ViditelnostProcenta/100.0};";
			}
		}
	}
}
