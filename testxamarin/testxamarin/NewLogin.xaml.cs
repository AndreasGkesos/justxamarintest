﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testxamarin.MasterDetail;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testxamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewLogin : ContentPage
	{
		public NewLogin ()
		{
			InitializeComponent ();
		}

        private void Login_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MasterDetails());
        }
    }
}