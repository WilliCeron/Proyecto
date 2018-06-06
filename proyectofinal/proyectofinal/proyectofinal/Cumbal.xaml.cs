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
	public partial class Cumbal : ContentPage
	{
		public Cumbal ()
		{
			InitializeComponent ();
		}


        async private void HistoriaCumbal(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HistoriaCumbal());
        }


        async private void ComidasCumbal(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ComidaCumbal());
        }

        async private void fotosCumbal(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GaleriaCumbal());
        }





        async private void RegresarHome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }
    }
}