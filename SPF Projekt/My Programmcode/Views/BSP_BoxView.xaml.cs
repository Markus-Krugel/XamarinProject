using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinBeispiele
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BSP_BoxView : ContentPage
	{
		public BSP_BoxView()
		{
			InitializeComponent ();

            BackgroundColor = Color.LightGray;

            var grid = new Grid();
            grid.HorizontalOptions = LayoutOptions.Center;

            grid.ColumnSpacing = 5;
            grid.RowSpacing = 30;
            grid.Margin = 10;

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(70, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(50, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(50, GridUnitType.Absolute) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(50, GridUnitType.Absolute) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(50, GridUnitType.Absolute) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(70, GridUnitType.Absolute) });

            var boxView1 = new BoxView
            {
                Color = Color.CornflowerBlue,
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill
            };
            var boxView2 = new BoxView
            {
                Color = Color.Firebrick,
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill
            };
            var boxView3 = new BoxView
            {
                Color = Color.White,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill,
                WidthRequest = 2
            };
            var boxView4 = new BoxView
            {
                Color = Color.Crimson,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill,
                WidthRequest = 20,
                HeightRequest = 2
            };
            var boxView5 = new BoxView
            {
                Color = Color.Yellow,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 20,
                HeightRequest = 2
            };
            var boxView6 = new BoxView
            {
                Color = Color.Crimson,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            grid.Children.Add(boxView1, 0, 0);
            grid.Children.Add(boxView2, 1, 0);
            grid.Children.Add(boxView3, 2, 0);
            grid.Children.Add(boxView4, 0, 1);
            grid.Children.Add(boxView5, 1, 1);
            grid.Children.Add(boxView6, 0, 2);

            Grid.SetRowSpan(boxView3, 3);
            Grid.SetColumnSpan(boxView6, 2);

            Content = grid;
        }
    }
}