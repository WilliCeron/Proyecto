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
	public partial class Buesaco : ContentPage
	{
		public Buesaco ()
		{
			InitializeComponent ();
		}

        async private void HistoriaBuesaco(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HistoriaBuesaco());
        }


        async private void ComidasBuesaco(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ComidaBuesaco());
        }

        async private void fotosBuesaco(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GaleriaBuesaco());
        }





        async private void RegresarHome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }
    }
}