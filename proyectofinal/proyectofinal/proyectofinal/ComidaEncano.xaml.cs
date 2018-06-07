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
	public partial class ComidaEncano : ContentPage
	{
		public ComidaEncano ()
		{
			InitializeComponent ();
		}
        async private void RegresarEncano(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Encano());
        }
    }
}