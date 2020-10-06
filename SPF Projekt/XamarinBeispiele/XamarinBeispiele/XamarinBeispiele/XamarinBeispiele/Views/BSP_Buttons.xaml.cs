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
	public partial class BSP_Buttons : ContentPage
	{
        int geklickt = 0;
		public BSP_Buttons()
		{
			InitializeComponent ();
            seiteAufbauen();
		}

        private void OnClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            geklickt++;
            button.Text = "Du hast " + geklickt + " Mal diesen Knopf geklickt.";
        }

        private void seiteAufbauen()
        {
            Grid grid = new Grid();

            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

            grid.Margin = new Thickness(0, 20, 0, 0);
            grid.Padding = 5;
            grid.BackgroundColor = Color.LightGray;

            // Erster Button
            Button button1 = new Button();
            button1.BorderColor = Color.MediumOrchid;
            button1.BorderRadius = 10;
            button1.BorderWidth = 3;
            button1.Text = "Radius: 10 und Width: 3";
            button1.BackgroundColor = Color.WhiteSmoke;

            // Zweiter Button
            Button button2 = new Button();
            button2.BorderColor = Color.Chartreuse;
            button2.BorderRadius = 4;
            button2.BorderWidth = 7;
            button2.Text = "Radius: 4 und Width: 7";
            button2.BackgroundColor = Color.WhiteSmoke;

            // Dritter Button
            Button button3 = new Button();
            button3.FontAttributes = FontAttributes.Bold;
            button3.FontFamily = "Arial";
            button3.FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button));
            button3.Text = "Gross";
            button3.TextColor = Color.Aqua;
            button3.BackgroundColor = Color.WhiteSmoke;

            // Vierter Button
            Button button4 = new Button();
            button4.FontAttributes = FontAttributes.Italic;
            button4.FontFamily = "Georgia";
            button4.FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Button));
            button4.Text = "Klein";
            button4.TextColor = Color.DarkSlateBlue;
            button4.BackgroundColor = Color.WhiteSmoke;

            // Sechster Button
            Button button5 = new Button();
            button5.Text = "Du hast 0 Mal diesen Knopf geklickt.";
            button5.Clicked += OnClicked;
            button5.BackgroundColor = Color.WhiteSmoke;

            grid.Children.Add(button1, 0, 0);
            grid.Children.Add(button2, 1, 0);
            grid.Children.Add(button3, 0, 1);
            grid.Children.Add(button4, 1, 1);
            grid.Children.Add(button5, 0, 2);

            Content = grid;
        }
    }
}