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
	public partial class SlackPage : ContentPage
	{
		public SlackPage ()
		{
			InitializeComponent ();

            var layout = new StackLayout
            {
                Spacing = 40,
                Padding = new Thickness(0),
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            layout.Children.Add(new Label { Text = "Label 1"});

            Content = layout;
		}
	}
}