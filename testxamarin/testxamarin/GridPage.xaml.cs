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
	public partial class GridPage : ContentPage
	{
		public GridPage ()
		{
			InitializeComponent ();

            var grid = new Grid
            {
                RowSpacing = 20,
                ColumnSpacing = 20,
                BackgroundColor = Color.Beige
            };

            var label1 = new Label { Text = "Label 1" };
            label1.BackgroundColor = Color.Coral;
            var label2 = new Label { Text = "Label 2", BackgroundColor = Color.Cyan };
            grid.Children.Add(label1,  0, 0);
            // Grid.SetRowSpan(label1, 2);
            // Grid.SetColumnSpan(label1, 2);

            grid.Children.Add(label2, 0, 1);

            grid.RowDefinitions.Add(new RowDefinition {
                Height = new GridLength(100, GridUnitType.Absolute)
            });

            grid.RowDefinitions.Add(new RowDefinition {
                Height = new GridLength(1, GridUnitType.Star)
            });

            grid.ColumnDefinitions.Add(new ColumnDefinition {
                Width = new GridLength(1, GridUnitType.Star)
            });

            grid.ColumnDefinitions.Add(new ColumnDefinition
            {
                Width = new GridLength(10, GridUnitType.Absolute)
            });

            Content = grid;
		}
	}
}