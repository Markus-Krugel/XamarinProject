using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinBeispiele.Images;

namespace XamarinBeispiele
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BSP_Images : ContentPage
	{
		public BSP_Images()
		{
			InitializeComponent ();

            //seiteAufbauen();
        }

        private void seiteAufbauen()
        {
            Grid grid = new Grid();
            grid.BackgroundColor = Color.LightGray;
            grid.Margin = new Thickness(5, 30, 5, 0);

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
   
            //  Ein Bild mit AspectFill der aus einer URL geladen wird.
            Image image1 = new Image
            {
                Source = "http://img.4plebs.org/boards/hr/image/1440/22/1440225683004.png",
                Aspect = Aspect.AspectFill
            };

            //  Ein Bild mit AspectFit der aus einer Datei geladen wird.
            Image image2 = new Image
            {
                Source = claImageResourceResolver.ResolveImage("landschaft"),
                Aspect = Aspect.AspectFit
            };

            //  Ein Bild mit Fill der aus einer Datei geladen wird.
            Image image3 = new Image
            {
                Source = claImageResourceResolver.ResolveImage("landschaft"),
                Aspect = Aspect.Fill
            };

            Label label1 = new Label { Text = "Bild mit AspectFill" };
            Label label2 = new Label { Text = "Bild mit AspectFit" };
            Label label3 = new Label { Text = "Bild mit Fill" };

            grid.Children.Add(image1, 0, 0);
            grid.Children.Add(image2, 1, 0);
            grid.Children.Add(image3, 2, 0);

            grid.Children.Add(label1, 0, 1);
            grid.Children.Add(label2, 1, 1);
            grid.Children.Add(label3, 2, 1);

            Content = grid;
        }
	}
}