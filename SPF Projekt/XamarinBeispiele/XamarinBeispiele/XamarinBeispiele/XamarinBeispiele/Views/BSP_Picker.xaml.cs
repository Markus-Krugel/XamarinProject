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
	public partial class BSP_Picker : ContentPage
	{
		public BSP_Picker()
		{
			InitializeComponent ();

            //seiteAufbauen();
        }

        private void seiteAufbauen()
        {
            StackLayout stack = new StackLayout();

            stack.BackgroundColor = Color.LightGray;

            // Picker wird erstellt
            Picker picker = new Picker { Margin = new Thickness(5, 25, 5, 5) };

            // Es werden dem Picker Items hinzugefügt
            picker.Items.Add("Wert 1");
            picker.Items.Add("Wert 2");
            picker.Items.Add("Wert 3");

            // Alternative Art Picker zu befüllen
            String[] werte = new String[] { "Wert 1", "Wert 2", "Wert 3" };
            picker.ItemsSource = werte;

            // Erster Eintrag wird ausgewählt;
            picker.SelectedIndex = 0;

            Label label1 = new Label { };
            label1.Margin = new Thickness(5, 70, 0, 0);
            label1.HorizontalOptions = LayoutOptions.Center;
            label1.SetBinding(Label.TextProperty, new Binding("SelectedIndex", source: picker) { StringFormat = "Index: {0:N}" });

            Label label2 = new Label { };
            label2.Margin = new Thickness(5, 5, 0, 0);
            label2.HorizontalOptions = LayoutOptions.Center;
            label2.SetBinding(Label.TextProperty, new Binding("SelectedItem", source: picker) { StringFormat = "Item: {0:N}" });

            stack.Children.Add(picker);
            stack.Children.Add(label1);
            stack.Children.Add(label2);

            Content = stack;
        }
	}
}