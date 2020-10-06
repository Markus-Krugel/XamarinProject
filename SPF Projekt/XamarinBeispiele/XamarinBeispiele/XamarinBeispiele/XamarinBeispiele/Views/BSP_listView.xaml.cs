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
	public partial class BSP_ListView : ContentPage
	{
        public static List<ElementListe> source = new List<ElementListe>();

		public BSP_ListView()
		{
            listeFuellen();

            InitializeComponent ();

            //seiteAufbauen();
		}

        private void seiteAufbauen()
        {
            StackLayout layout = new StackLayout();

            // Die Listview mit ihren Werten wird erstellt
            ListView listview = new ListView();
            listview.IsGroupingEnabled = true;
            listview.Margin = new Thickness(0, 30, 0, 10);
            listview.BackgroundColor = Color.Gray;
            listview.HorizontalOptions = LayoutOptions.Center;
            
            // Listview wird mit Items befüllt
            listview.ItemsSource = source;

            // Kopfzeile wird erstellt
            Label label = new Label();
            label.HorizontalTextAlignment = TextAlignment.Center;
            label.BackgroundColor = Color.Wheat;
            label.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            label.Text = "HEADER";
            listview.Header = label;

            // Vorlage für die Kopfzeile der Gruppen wird erstellt
            listview.GroupHeaderTemplate = new DataTemplate(() =>
            {
                Label label2 = new Label { BackgroundColor = Color.LightGray, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
                label2.HorizontalTextAlignment = TextAlignment.Center;
                label2.FontAttributes = FontAttributes.Bold;
                label2.TextColor = Color.Blue;
                label2.SetBinding(Label.TextProperty, "Ueberschrift");

                return new ViewCell { View = label2 };
            });

            // Vorlage für die Items wird erstellt
            listview.ItemTemplate = new DataTemplate(() =>
            {
                ImageCell imageCell = new ImageCell();
                imageCell.ImageSource = "Assets\\LockScreenLogo.scale-125.png";
                imageCell.TextColor = Color.White;
                imageCell.SetBinding(ImageCell.TextProperty, "Wert");
                imageCell.SetBinding(ImageCell.DetailProperty, "Detail");
                imageCell.DetailColor = Color.LightGray;

                return imageCell;
            });

            // Fußzeile wird erstellt
            Label label3 = new Label();
            label3.BackgroundColor = Color.Wheat;
            label3.HorizontalTextAlignment = TextAlignment.Center;
            label3.Text = "Das hier ist das Ende";
            listview.Footer = label3;

            layout.Children.Add(listview);
            Content = layout;
        }

        private void listeFuellen()
        {
            ElementListe liste1 = new ElementListe();
            ElementListe liste2 = new ElementListe();
            ElementListe liste3 = new ElementListe();

            liste1.Ueberschrift = "Tiere";
            liste2.Ueberschrift = "Formen";
            liste3.Ueberschrift = "Farben";

            liste1.Add(new Element { Wert = "Katze", Detail = "Haustier" });
            liste1.Add(new Element { Wert = "Pferd", Detail = "Reittier" });
            liste1.Add(new Element { Wert = "Hund", Detail = "Haustier" });

            liste2.Add(new Element { Wert = "Kreis", Detail = "Beliebig viele Ecken" });
            liste2.Add(new Element { Wert = "Viereck", Detail = "Vier Ecken" });
            liste2.Add(new Element { Wert = "Dreieck", Detail = "Drei Ecken" });

            liste3.Add(new Element { Wert = "Rot" });
            liste3.Add(new Element { Wert = "Grün" });
            liste3.Add(new Element { Wert = "Blau" });

            source.Add(liste1);
            source.Add(liste2);
            source.Add(liste3);
        }
    }
}

public class ElementListe : List<Element>
{
    public string Ueberschrift { get; set; }
    public List<Element> elemente => this;
}

public class Element
{
    public string Wert { get; set; }
    public string Detail { get; set; }
}