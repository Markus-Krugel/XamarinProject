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
	public partial class BSP_Triggers : ContentPage
	{
		public BSP_Triggers()
		{
			InitializeComponent ();
            //seiteAufbauen();
		}

        private void seiteAufbauen()
        {
            resourcesErstellen();

            Grid grid = new Grid() { BackgroundColor = Color.LightGray, Margin = new Thickness(0, 30, 0, 0) };

            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

            var slider = new Slider
            {
                Minimum = 0,
                Maximum = 100,
                Triggers =
                {
                    // Wenn der Slider den Wert 100 hat wird die Größe des Sliders halbiert
                    new Trigger(typeof(Slider))
                    {
                        Property = Slider.ValueProperty,
                        Value = "100",
                        Setters=
                        {
                            new Setter{Property = Slider.ScaleProperty, Value = 0.5}
                        }
                    }
                }
            };

            var label = new Label
            {
                BackgroundColor = Color.White,
                Margin = 5,
                Text = "Eingabe ist in Ordnung",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,

                /*  Bindet an den Value Wert des Sliders.Wenn dieser 100 erreicht
                    wird ein neuer Text mit roter Farbe dargestellt */
                Triggers =
                {
                    new DataTrigger(typeof(Label))
                    {
                        Binding = new Binding("Value", source:slider),
                        Value = "100",
                        Setters=
                        {
                            new Setter { Property = Label.TextProperty, Value = "Zu hohe Eingabe" },
                            new Setter { Property = Label.TextColorProperty, Value = Color.Red }
                        }
                    },
                }
            };

            var benutzer = new Entry { Placeholder = "Gib 'Benutzer' ein" };
            var passwort = new Entry { Placeholder = "Gib 'Passwort' ein" };

            var button = new Button
            {
                Text = "Weiter",
                IsEnabled = false,

                Triggers =
                {
                    // Wenn in den Entries "Benutzer" und "Passwort" steht, wird der Button enabled
                    new MultiTrigger(typeof(Button))
                    {
                        // Die Bedingungen, die erfüllt werden müssen
                        Conditions=
                        {
                            new BindingCondition { Binding = new Binding ("Text", source: benutzer), Value = "Benutzer" },
                            new BindingCondition { Binding = new Binding("Text", source: passwort), Value = "Passwort" }
                        },
                        // Enabled den Button
                        Setters=
                        {
                            new Setter { Property = Button.IsEnabledProperty, Value = true }
                        }
                    },
                    // Ruft die Klasse "ButtonClickTriggerAction" auf, wenn der Button geklickt wurde
                    new EventTrigger
                    {
                        Event = "Clicked",
                        Actions=
                        {
                            new ButtonClickTriggerAction()
                        }
                    },
                    // Wenn der Button deaktiviert ist, Hintergrund Grau färben
                    new Trigger(typeof(Button))
                    {
                        Property = Button.IsEnabledProperty,
                        Value = false,
                        Setters=
                        {
                            new Setter { Property = Button.BackgroundColorProperty, Value = Color.Gray }
                        }
                    },
                    // Wenn der Button aktiviert ist, Hintergrund Grau färben
                    new Trigger(typeof(Button))
                    {
                        Property = Button.IsEnabledProperty,
                        Value = true,
                        Setters=
                        {
                            new Setter { Property = Button.BackgroundColorProperty, Value = Color.Gray }
                        }
                    }
                }
            };

            grid.Children.Add(slider, 0, 0);
            grid.Children.Add(label, 1, 0);
            grid.Children.Add(benutzer, 0, 1);
            grid.Children.Add(passwort, 1, 1);
            grid.Children.Add(button, 0, 2);

            Grid.SetColumnSpan(button, 2);

            Content = grid;
        }

        private void resourcesErstellen()
        {
            Resources = new ResourceDictionary();

            // Ein Trigger für alle Entries
            var entryStyle = new Style(typeof(Entry))
            {
                Setters =
                {
                    new Setter{ Property = Entry.HorizontalTextAlignmentProperty, Value = TextAlignment.Center }
                },
                Triggers =
                {
                    new Trigger(typeof(Entry))
                    {
                        Property = Entry.IsFocusedProperty,
                        Value = true,
                        Setters=
                        {
                            new Setter { Property = Entry.TextColorProperty, Value = Color.Blue },
                        },
                        /* Ruft die Klasse "EntryFocusTriggerAction" auf 
                                und setzt die Eigenschaft Farbe auf Gray */
                        EnterActions =
                        {
                            new EntryFocusTriggerAction { Farbe = Color.Gray }
                        },
                        /* Ruft die Klasse "EntryFocusTriggerAction" auf 
                                und setzt die Eigenschaft Farbe auf DarkGray */
                        ExitActions =
                        {
                            new EntryFocusTriggerAction { Farbe = Color.DarkGray }
                        }
                    }
                }
            };
            Resources.Add(entryStyle);
        }
    }
}