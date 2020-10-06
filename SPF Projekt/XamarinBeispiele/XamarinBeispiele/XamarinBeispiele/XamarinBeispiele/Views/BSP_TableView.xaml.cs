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
	public partial class BSP_TableView : ContentPage
	{
		public BSP_TableView()
		{
			InitializeComponent ();

            //var stacklayoutCustomizeCells = new StackLayout();

            //    stacklayoutCustomizeCells.Children.Add(new Image() { Source = "Images/Keyboard.png" });
            //    stacklayoutCustomizeCells.Children.Add(new Label()
            //    {
            //        Text = "left",
            //        TextColor = Color.FromHex("#f35e20"),
            //        VerticalOptions = LayoutOptions.Center
            //    });
            //    stacklayoutCustomizeCells.Children.Add(new Label()
            //    {
            //        Text = "right",
            //        TextColor = Color.FromHex("#503026"),
            //        VerticalOptions = LayoutOptions.Center,
            //        HorizontalOptions = LayoutOptions.EndAndExpand
            //    });

            //var stacklayoutLabelEntryImage = new StackLayout();

            //    stacklayoutLabelEntryImage.Children.Add(new Label() { Text = "SPF", TextColor = Color.FromHex("#f35e20") });
            //    stacklayoutLabelEntryImage.Children.Add(new Entry() { Placeholder = "Ist die Eingabe durch Eintippen geschehen?" });
            //    stacklayoutLabelEntryImage.Children.Add(new Image() { Source = "Images/Keyboard.png" });

            //var tv = new TableView
            //{
            //    Root = new TableRoot
            //    {
            //        new TableSection ("Dies ist eine TableSection")
            //        {
            //        new SwitchCell {Text = "Dies ist eine SwitchCell mit einem Label und einem Schalter."},
            //        new SwitchCell {Text = "Dies ist eine SwitchCell die an gestllt wurde", On = true}
            //        },
            //        new TableSection ("Überblick über Entrycell")
            //        {
            //            new EntryCell{ Text = "Dies ist eine Entrycell mit einem Label und einem Entry.",
            //                           LabelColor = Color.DarkGreen , Label="Perfect Entrcell" },
            //            new EntryCell{ Label="Leeres Entry mit Placeholder", Text="" ,
            //                           Placeholder ="Die Properties von den Childviews werden Größtenteils übernommen"}
            //        },
            //        new TableSection ("Customize Cells for your own porpose")
            //        {
            //            new ViewCell{ View = stacklayoutCustomizeCells},
            //        },
            //        new TableSection ("Common Label Enty Image Cell SPF")
            //        {
            //            new ViewCell{ View = stacklayoutLabelEntryImage},
            //        }
            //    },
            //    Intent = TableIntent.Settings
            //};

            //Content = tv;
        }
	}
}