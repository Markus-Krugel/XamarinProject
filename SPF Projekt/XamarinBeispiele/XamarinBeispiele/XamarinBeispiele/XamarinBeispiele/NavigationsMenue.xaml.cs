using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinBeispiele
{
    /* Um einen Fehler bei ItemSelect auf UWP Platformen zu verhindern
       musste man das Xamarin Forms NugetPackage von UWP updaten  */
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NavigationsMenue : ContentPage
	{
        // Die Tableview wird anhand dieser Liste befüllt   
        List<SeitenListe> seiten = new List<SeitenListe>();

		public NavigationsMenue ()
		{
            listeFuellen();

            InitializeComponent ();

            seiteAufbauen();
		}

        // hier werden die Views erstellt und der Oberfläche hinzugefügt
        private void seiteAufbauen()
        {
            StackLayout layout = new StackLayout();
            layout.Padding = 0;

            // Die Listview mit ihren Werten wird erstellt
            ListView listview = new ListView();
            listview.IsGroupingEnabled = true;
            listview.BackgroundColor = Color.Gray;
            listview.ItemTapped += onItemSelect;
            listview.SeparatorVisibility = SeparatorVisibility.Default;
            listview.SeparatorColor = Color.DarkGray;

            // Listview wird mit Items befüllt
            listview.ItemsSource = seiten;

            // Kopfzeile wird erstellt
            Label kopfzeilenLabel = new Label();
            kopfzeilenLabel.HorizontalTextAlignment = TextAlignment.Center;
            kopfzeilenLabel.BackgroundColor = Color.WhiteSmoke;
            kopfzeilenLabel.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            kopfzeilenLabel.Text = "Beispiele";
            listview.Header = kopfzeilenLabel;

            // Vorlage für die Kopfzeile der Gruppen wird erstellt
            listview.GroupHeaderTemplate = new DataTemplate(() =>
            {
                Label groupHeaderLabel = new Label { BackgroundColor = Color.LightGray, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
                groupHeaderLabel.HorizontalTextAlignment = TextAlignment.Center;
                groupHeaderLabel.FontAttributes = FontAttributes.Bold;
                groupHeaderLabel.TextColor = Color.Blue;
                groupHeaderLabel.SetBinding(Label.TextProperty, "Ueberschrift");
                groupHeaderLabel.VerticalTextAlignment = TextAlignment.Center;

                return new ViewCell { View = groupHeaderLabel };
            });

            // Vorlage für die Items wird erstellt
            listview.ItemTemplate = new DataTemplate(() =>
            {
                TextCell cell = new TextCell();
                cell.TextColor = Color.White;
                cell.SetBinding(ImageCell.TextProperty, "Detail");

                return cell;
            });

            layout.Children.Add(listview);

            Content = layout;
        }

        // hier wird die Liste für die TableView befüllt
        private void listeFuellen()
        {
            SeitenListe viewList = new SeitenListe();
            SeitenListe layoutList = new SeitenListe();
            SeitenListe pagesList = new SeitenListe();
            SeitenListe gesturesList = new SeitenListe();
            SeitenListe sonstigesList = new SeitenListe();

            // Überschriften der Gruppen

            viewList.Ueberschrift = "Views";
            layoutList.Ueberschrift = "Layouts";
            pagesList.Ueberschrift = "Pages";
            gesturesList.Ueberschrift = "GestureRecognizers";
            sonstigesList.Ueberschrift = "Sonstiges";

            // Hinzufügen der Einträge in die jeweiligen Gruppen

            viewList.Add(new Seite { Page = new BSP_ActivityIndicator(), Detail = "ActivityIndicator Beispiel" });
            viewList.Add(new Seite { Page = new BSP_Buttons(), Detail = "Button Beispiel" });
            viewList.Add(new Seite { Page = new BSP_BoxView(), Detail = "BoxView Beispiel" });
            viewList.Add(new Seite { Page = new BSP_DatePicker(), Detail = "DatePicker Beispiel" });
            viewList.Add(new Seite { Page = new BSP_Editor(), Detail = "Editor Beispiel" });
            viewList.Add(new Seite { Page = new BSP_Entry(), Detail = "Entry Beispiel" });
            viewList.Add(new Seite { Page = new BSP_Images(), Detail = "Images Beispiel" });
            viewList.Add(new Seite { Page = new BSP_Label(), Detail = "Label Beispiel" });
            viewList.Add(new Seite { Page = new BSP_ListView(), Detail = "ListView Beispiel" });
            viewList.Add(new Seite { Page = new BSP_Picker(), Detail = "Picker Beispiel" });
            viewList.Add(new Seite { Page = new BSP_ProgressBar(), Detail = "ProgressBar Beispiel" });
            viewList.Add(new Seite { Page = new BSP_SearchBar(), Detail = "SearchBar Beispiel" });
            viewList.Add(new Seite { Page = new BSP_Stepper(), Detail = "Stepper Beispiel" });
            viewList.Add(new Seite { Page = new BSP_Switch(), Detail = "Switch Beispiel" });
            viewList.Add(new Seite { Page = new BSP_TableView(), Detail = "TableView Beispiel" });
            viewList.Add(new Seite { Page = new BSP_Timepicker(), Detail = "TimePicker Beispiel" });

            layoutList.Add(new Seite { Page = new BSP_AbsuluteLayout(), Detail = "AbsoluteLayout Beispiel" });
            layoutList.Add(new Seite { Page = new BSP_Grid(), Detail = "Grid Beispiel" });
            layoutList.Add(new Seite { Page = new BSP_RelativeLayout(), Detail = "RelativeLayout Beispiel" });
            layoutList.Add(new Seite { Page = new BSP_ScrollView(), Detail = "ScrollView Beispiel" });
            layoutList.Add(new Seite { Page = new BSP_StackLayout(), Detail = "StackLayout Beispiel" });

            pagesList.Add(new Seite { Page = new BSP_MasterPage() , Detail = "MasterDetailPage Beispiel - Zurückgehen nicht möglich" });
            pagesList.Add(new Seite { Page = new BSP_CarouselPage() , Detail = "CarouselPage Beispiel" });
            pagesList.Add(new Seite { Page = new BSP_TabbedPage() , Detail = "TabbedPage Beispiel" });

            gesturesList.Add(new Seite { Page = new BSP_GestureRecognizer(), Detail = "GestureRecognizers" });

            sonstigesList.Add(new Seite { Page = new BSP_DataBinding(), Detail = "Data Binding Beispiel" });
            sonstigesList.Add(new Seite { Page = new BSP_MVVM(), Detail = "MVVM Beispiel" });
            sonstigesList.Add(new Seite { Page = new BSP_Styles(), Detail = "Styles Beispiel" });
            sonstigesList.Add(new Seite { Page = new BSP_Triggers(), Detail = "Triggers Beispiel" });

            // Die Gruppen werden der Liste hinzugefügt

            seiten.Add(viewList);
            seiten.Add(layoutList);
            seiten.Add(pagesList);
            seiten.Add(gesturesList);
            seiten.Add(sonstigesList);
        }

        // Wenn etwas ausgewählt wurde, wird auf die entsprechende Seite weitergeleitet
        private void onItemSelect(object sender, EventArgs e)
        {
            ListView listView = sender as ListView;

            Seite seite = listView.SelectedItem as Seite;
            Navigation.PushAsync(seite.Page);
        }
    }

    // diese Klasse ist für die Verwaltung der Gruppen zuständig
    public class SeitenListe : List<Seite>
    {
        public string Ueberschrift { get; set; }
        public List<Seite> elemente => this;
    }

    // diese Klasse ist für die Verwaltung der einzelnen Einträge verantwortlich
    public class Seite
    {
        public Page Page { get; set; }
        public string Detail { get; set; }
    }
}