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
	public partial class BSP_SearchBar : ContentPage
	{
        SearchBar SB1 = new SearchBar {Placeholder="SPF Suche", PlaceholderColor = Color.LightGreen,
            CancelButtonColor = Color.Green, HorizontalTextAlignment = TextAlignment.Center};



        public BSP_SearchBar()
        {
            InitializeComponent();

            SB1.SearchButtonPressed += SB1_SearchButtonPressed;

            var layout = new StackLayout { };

            var SB2 = new SearchBar { Placeholder = "WEB Suche", PlaceholderColor = Color.LightGray,
                CancelButtonColor = Color.Gray, HorizontalTextAlignment = TextAlignment.Center };
            var SB3 = new SearchBar { Placeholder = "Die Suche", PlaceholderColor = Color.LightGray,
                CancelButtonColor = Color.Gray,Text="Die Suche",TextColor=Color.Green,
                HorizontalTextAlignment = TextAlignment.Start, FontAttributes= FontAttributes.Bold };

            layout.Children.Add(SB1);
            layout.Children.Add(SB2);
            layout.Children.Add(SB3);

            Content = layout;
        }

        private void SB1_SearchButtonPressed(object sender, EventArgs e)
        {
            SB1.PlaceholderColor = Color.Red;
            SB1.TextColor = Color.Red;
        }
    }
}