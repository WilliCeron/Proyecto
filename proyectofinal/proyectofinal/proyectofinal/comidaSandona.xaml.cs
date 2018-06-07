﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace proyectofinal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class comidaSandona : ContentPage
	{
		public comidaSandona ()
		{
			InitializeComponent ();
		}

        async private void RegresarSandona(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sandona());
        }
    }
}