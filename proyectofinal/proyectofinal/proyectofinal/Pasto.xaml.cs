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
	public partial class Pasto : ContentPage
	{
		public Pasto ()
		{
			InitializeComponent ();
		}

        async private void HistoriaPasto(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HistoriaPasto());
        }


        async private void ComidasPasto(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ComidaPasto());
        }

        async private void fotosPasto(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GaleriaPasto());
        }





        async private void RegresarHome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }
    }
}