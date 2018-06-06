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
	public partial class LasLajas : ContentPage
	{
		public LasLajas ()
		{
			InitializeComponent ();
		}


        async private void HistoriaLasLajas(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HistoriaLasLajas());
        }


        async private void ComidasLasLajas(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ComidaLasLajas());
        }

        async private void fotosLasLajas(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GaleriaLasLajas());
        }





        async private void RegresarHome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }
    }
}