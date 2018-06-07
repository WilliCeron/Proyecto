using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace proyectofinal
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            
			InitializeComponent();
		}



        async public void IngresarHome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }


    }
}
