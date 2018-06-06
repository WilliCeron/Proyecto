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
	public partial class Encano : ContentPage
	{
		public Encano ()
		{
			InitializeComponent ();
		}

        async private void HistoriaEncano(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HistoriaEncano());
        }


        async private void ComidasEncano(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ComidaEncano());
        }

        async private void fotosEncano(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GaleriaEncano());
        }





        async private void RegresarHome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }
    }
}