using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace testxamarin
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
		{
			InitializeComponent();

            slider.Value = 0.5;

            //if (Device.OS == TargetPlatform.iOS) {
            //    Padding = new Thickness(0, 20, 0, 0);
            //}

            //Padding = Device.OnPlatform(
            //    iOS: new Thickness(0, 20, 0, 0),
            //    Android: new Thickness(0, 0, 0, 0),
            //    WinPhone: new Thickness(0, 0, 0, 0)
            //);

            //Device.OnPlatform(
            //    () => Padding = new Thickness(0, 20, 0, 0)
            //);
		}
	}
}
