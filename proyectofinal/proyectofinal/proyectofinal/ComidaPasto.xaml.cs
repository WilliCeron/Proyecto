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
	public partial class ComidaPasto : ContentPage
	{
		public ComidaPasto ()
		{
			InitializeComponent ();
		}
        async private void RegresarPasto(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pasto());
        }
    }
}