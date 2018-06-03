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
	public partial class Home : ContentPage
	{
		public Home ()
		{
			InitializeComponent ();
		}
        async private void visitarSandona(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sandona());
        }


        async private void visitarBuesaco(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Buesaco());
        }


        async private void visitarLacruz(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LaCruz());
        }


        async private void visitarLaslajas(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LasLajas());
        }


        async private void visitarCumbal(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cumbal());
        }


        async private void visitarPasto(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pasto());
        }

        async private void visitarElencano(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Encano());
        }

        async private void visitarTumaco(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tumaco());
        }
    }
}