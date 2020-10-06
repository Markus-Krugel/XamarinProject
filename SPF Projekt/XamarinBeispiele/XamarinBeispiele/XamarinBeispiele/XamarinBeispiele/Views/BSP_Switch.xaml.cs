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
	public partial class BSP_Switch : ContentPage
	{
		public BSP_Switch()
		{
			InitializeComponent ();
            seiteAufbauen();
		}

        private void seiteAufbauen()
        {
            StackLayout layout = new StackLayout
            {
                BackgroundColor = Color.LightGray,
                Margin = new Thickness(0, 30, 0, 0)
            };

            StackLayout switches = new StackLayout();
            switches.Orientation = StackOrientation.Horizontal;

            StackLayout labels = new StackLayout();
            labels.Orientation = StackOrientation.Horizontal;

            // Die Switches werden erstellt
            Switch switch1 = new Switch { IsToggled = false,
                HorizontalOptions = LayoutOptions.CenterAndExpand };
            Switch switch2 = new Switch { IsToggled = true,
                HorizontalOptions = LayoutOptions.CenterAndExpand };

            Label label1 = new Label { HorizontalOptions = LayoutOptions.CenterAndExpand };

            // Das Binding um sich mit der Switch zu verknüpfen
            Binding binding1 = new Binding("IsToggled", source: switch1)
            { StringFormat = "Der Switch ist: {0:n}" };
            label1.SetBinding(Label.TextProperty, binding1);
            
            Label label2 = new Label { HorizontalOptions = LayoutOptions.CenterAndExpand };

            // Das Binding um sich mit der Switch zu verknüpfen
            Binding binding2 = new Binding("IsToggled", source: switch2)
            { StringFormat = "Der Switch ist: {0:n}" };
            label2.SetBinding(Label.TextProperty, binding2);

            switches.Children.Add(switch1);
            switches.Children.Add(switch2);

            labels.Children.Add(label1);
            labels.Children.Add(label2);

            layout.Children.Add(labels);
            layout.Children.Add(switches);
            Content = layout;
        }
    }
}