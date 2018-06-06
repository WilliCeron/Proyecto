using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace proyectofinal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LaCruz : ContentPage
	{
		public LaCruz ()
		{
			InitializeComponent ();
		}


        async private void HistoriaLaCruz(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HistoriaLaCruz());
        }


        async private void ComidasLaCruz(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ComidaLaCruz());
        }

        async private void fotosLaCruz(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GaleriaLaCruz());
        }





        async private void RegresarHome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }
    }
}