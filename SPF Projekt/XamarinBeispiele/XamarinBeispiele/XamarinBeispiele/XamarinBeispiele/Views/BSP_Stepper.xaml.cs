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
	public partial class BSP_Stepper : ContentPage
	{

        public BSP_Stepper()
		{
			InitializeComponent ();

            Grid dasGrid = new Grid() { };

            dasGrid.HorizontalOptions = LayoutOptions.Center;

            dasGrid.ColumnSpacing = 5;
            dasGrid.RowSpacing = 30;
            dasGrid.Margin = 10;

            dasGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            dasGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            dasGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            dasGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            Content = dasGrid;

            Upstepper = new Stepper() { BackgroundColor = Color.Azure, Increment = 1, Minimum = 0, Maximum = 50, Value = 0 };
            Upstepper.ValueChanged += Upstepper_ValueChanged;
            Downstepper = new Stepper() { BackgroundColor = Color.Azure, Increment = 5, Minimum = 0, Maximum = 250, Value = 250 };
            Downstepper.ValueChanged += Downstepper_ValueChanged;

            UpstepperValue = new Label()
            {
                Text = "Ein Stepper der bei 0 startet und in 1er Schritten von 0 bis 50 gehen kann!",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Center
            };
            DownstepperValue = new Label()
            {
                Text = "Ein Stepper der bei 250 startet und in 5er Schritten von 0 bis 250 gehen kann!",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Center
            };

            dasGrid.Children.Add(Upstepper, 1, 0);
            dasGrid.Children.Add(Downstepper, 1, 1);
            dasGrid.Children.Add(UpstepperValue, 0, 0);
            dasGrid.Children.Add(DownstepperValue, 0, 1);
        }

        private void Upstepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            UpstepperValue.Text = "" + Upstepper.Value;
        }

        private void Downstepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            DownstepperValue.Text = "" + Downstepper.Value;
        }
    }
}