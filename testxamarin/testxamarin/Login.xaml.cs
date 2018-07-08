using System;
using System.Threading.Tasks;
using testxamarin.Helpers;
using testxamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testxamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
    {
		public Login ()
		{
			InitializeComponent();

        }

        private async Task loginBtn_ClickedAsync(object sender, System.EventArgs e)
        {
            loginBtn.IsEnabled = false;
            var _username = username.Text;
            var _password = password.Text;
            try
            {
                if (String.IsNullOrEmpty(_username) || String.IsNullOrEmpty(_password))
                {
                    loginBtn.IsEnabled = true;
                    await DisplayAlert(
                        "Error",
                        "Username or password is empty",
                        "OK"
                    );
                    return;
                }

                var result = await Network.LoginAsync("login", new LoginBindingModel {
                    Username = _username,
                    Password = _password
                });

                username.Text = "";
                password.Text = "";

                if (result != null)
                {
                    loginBtn.IsEnabled = true;
                    if (result.Status == 200)
                    {
                        await Content.Navigation.PushAsync(new List());
                    } else
                    {
                        await DisplayAlert(
                            "Error",
                            "An error occur while loading",
                            "OK"
                        );
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                loginBtn.IsEnabled = true;
                await DisplayAlert(
                        "Error",
                        $"Error: {ex.Message}",
                        "OK"
                    );
            }
            
        }
    }
}