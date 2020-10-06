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
	public partial class BSP_ActivityIndicator : ContentPage
	{
		public BSP_ActivityIndicator()
		{
			InitializeComponent ();


            var layout = new StackLayout { Margin = new Thickness(0,30,0,0), BackgroundColor = Color.LightGray };

            var AcIn1 = new ActivityIndicator{IsRunning=true ,Color = Color.Red };
            var AcIn2 = new ActivityIndicator { IsRunning = true, Color = Color.Blue };
            var AcIn3 = new ActivityIndicator { IsRunning = true, Color = Color.Black };
            var AcIn4 = new ActivityIndicator { IsRunning = false, Color = Color.Black };

            layout.Children.Add(AcIn1);
            layout.Children.Add(AcIn2);
            layout.Children.Add(AcIn3);
            layout.Children.Add(AcIn4);

            Content = layout;
		}
	}
}