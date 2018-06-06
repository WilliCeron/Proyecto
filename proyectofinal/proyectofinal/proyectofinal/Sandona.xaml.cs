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
	public partial class Sandona : ContentPage
	{
		public Sandona ()
		{
			InitializeComponent ();
		}


        async private void HistoriaSandona(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HistoriaSandona());
        }


        async private void ComidasSandona(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new comidaSandona());
        }

        async private void fotosSandona(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GaleriaSandona());
        }


       


        async private void RegresarHome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }

    }
}