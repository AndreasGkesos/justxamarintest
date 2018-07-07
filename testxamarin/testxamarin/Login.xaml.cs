using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testxamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();

            // username.TextColor = Color.Black;

        }

        private void username_Focused(object sender, FocusEventArgs e)
        {
            ((CustomRenderers.CustomEntry)sender).TextColor = Color.Black;
        }
    }
}