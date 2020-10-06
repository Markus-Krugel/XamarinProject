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
	public partial class BSP_Styles : ContentPage
	{
        bool originalStyle = true;

        public BSP_Styles()
		{
			InitializeComponent ();

            stylesErstellen();
            //seiteAufbauen();
        }

        private void styleWechseln(object sender, EventArgs e)
        {
            if (originalStyle)
            {
                Resources["dynamisch"] = Resources["zentriertKleinRot"];
                originalStyle = false;
            }
            else
            {
                Resources["dynamisch"] = Resources["kleinRot"];
                originalStyle = true;
            }
        }

        // Das sind Page Level Styles
        private void stylesErstellen()
        {
            var kleinRot = new Style(typeof(Label))
            {
                Setters =
                {
                    new Setter{ Property = Label.FontSizeProperty, Value = Device.GetNamedSize(NamedSize.Small,typeof(Label)) },
                    new Setter{ Property = Label.TextColorProperty, Value = Color.Red },
                    new Setter{ Property = Label.TextProperty, Value = "Expliziter Style" },
                    new Setter{ Property = Label.BackgroundColorProperty, Value = Color.White }
                }
            };
            var implizit = new Style(typeof(Label))
            {
                Setters =
                {
                    new Setter{ Property = Label.TextColorProperty, Value = Color.Green },
                    new Setter{ Property = Label.TextProperty, Value = "Impliziter Style" },
                    new Setter{ Property = Label.BackgroundColorProperty, Value = Color.White }
                }
            };
            var zentriertKleinRot = new Style(typeof(Label))
            {
                //Vererben von einem Style
                BasedOn = kleinRot,
                Setters =
                {
                    new Setter{ Property = Label.VerticalOptionsProperty, Value = LayoutOptions.Center },
                    new Setter{ Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.Center },
                    new Setter{ Property = Label.TextProperty, Value = "Vererbter Style" },
                    new Setter{ Property = Label.BackgroundColorProperty, Value = Color.White }
                }
            };

            // ResourceDictionary erstellen und befüllen
            Resources = new ResourceDictionary();
            Resources.Add("kleinRot", kleinRot);
            Resources.Add("zentriertKleinRot", zentriertKleinRot);
            // Implizierter Style hinzufügen
            Resources.Add(implizit);
        }

        private void seiteAufbauen()
        {
            Grid grid = new Grid
            {
                BackgroundColor = Color.LightGray,
                Padding = 5,
                Margin = new Thickness(0, 30, 0, 0)
            };

            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

            Label implizit = new Label();
            Label explizit = new Label();
            Label vererbt = new Label();
            Label global = new Label();
            Label control = new Label();
            Label device = new Label();
            Label dyn = new Label();
            Label dynVererbt = new Label();

            //Control Level Style
            var orangeTitle = new Style(typeof(Label))
           {
               Setters =
               {
                    new Setter{ Property = Label.FontSizeProperty, Value = Device.GetNamedSize(NamedSize.Medium,typeof(Label)) },
                    new Setter{ Property = Label.TextColorProperty, Value = Color.Orange },
                    new Setter{ Property = Label.TextProperty, Value = "Control Level Style" },
                    new Setter{ Property = Label.BackgroundColorProperty, Value = Color.White }
               }
           };

            grid.Resources = new ResourceDictionary();
            grid.Resources.Add("orangeTitle", orangeTitle);

            Button button = new Button();
            button.Clicked += styleWechseln;
            button.Text = "Styles Ändern";

            // Dynamischer Style erstellen
            dyn.SetDynamicResource(Label.StyleProperty, "dynamisch");
            Resources["dynamisch"] = Resources["kleinRot"];

            // Styles setzen
            explizit.Style = (Style)Resources["kleinRot"];
            vererbt.Style = (Style)Resources["zentriertKleinRot"];

            // globaler Style nehmen
            global.Style = (Style)Application.Current.Resources["blauZentriert"];

            // Control Style nehmen
            control.Style = (Style)grid.Resources["orangeTitle"];

            // Device Style nehmen
            //device.Style = Device.Styles.TitleStyle;
            device.SetDynamicResource(Label.StyleProperty, Device.Styles.TitleStyleKey);
            device.Text = "TitleStyle";

            var dynamischVererbt = new Style(typeof(Label))
            {
                // Vererben von einem dynamischen Style
                BaseResourceKey = "dynamisch",
                Setters =
                {
                    new Setter{ Property = Label.TextColorProperty, Value = Color.Aqua },
                    new Setter{ Property = Label.TextProperty, Value = "Vererbter Style" },
                    new Setter{ Property = Label.BackgroundColorProperty, Value = Color.White }
                }
            };

            Resources.Add("dynamischVererbt", dynamischVererbt);
            dynVererbt.Style = (Style)Resources["dynamischVererbt"];


            grid.Children.Add(implizit, 0, 0);
            grid.Children.Add(explizit, 1, 0);
            grid.Children.Add(vererbt, 0, 1);
            grid.Children.Add(global, 1, 1);
            grid.Children.Add(control, 0, 2);
            grid.Children.Add(device, 1, 2);
            grid.Children.Add(dyn, 0, 3);
            grid.Children.Add(dynVererbt, 1, 3);
            grid.Children.Add(button, 0, 4);
            Grid.SetColumnSpan(button, 2);

            Content = grid;
        }
    } 
}