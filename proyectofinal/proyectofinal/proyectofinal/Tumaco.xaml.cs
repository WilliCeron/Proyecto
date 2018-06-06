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
	public partial class Tumaco : ContentPage
	{
		public Tumaco ()
		{
			InitializeComponent ();
		}

        async private void HistoriaTumaco(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HistoriaTumaco());
        }


        async private void ComidasTumaco(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ComidaTumaco());
        }

        async private void fotosTumaco(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GaleriaTumaco());
        }





        async private void RegresarHome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }
    }
}