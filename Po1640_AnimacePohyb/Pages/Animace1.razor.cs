
namespace Po1640_AnimacePohyb.Pages
{
	public partial class Animace1
	{
		private Models.Postava? Postava { get; set; }

		#region Udalosti formulare
		protected override void OnInitialized()
		{
			InicializaceHry();
			base.OnInitialized();
		}

		protected override async Task OnAfterRenderAsync(bool firstRender)
		{
			if (firstRender && Postava != null)
			{
				// Zde by mohl být kód pro spuštění animace
				
				 await Task.Run(Postava.Presun);
				 StateHasChanged(); //prekresli komponentu
			}
			await base.OnAfterRenderAsync(firstRender);
		}
		#endregion

		#region Metody
		private void InicializaceHry()
		{
			Postava = new Models.Postava("img/Pes.png", "Maxipes",150);
			Postava.PridejPozici(pozX: 45, 300,70, 100);
			Postava.PridejPozici(pozX: 450, 270, 20, 100);
			Postava.PridejPozici(pozX: 840, 340, 80, 100);
			Postava.PridejPozici(pozX: 110, 430, 100, 100);
		}
		#endregion
	}
}
