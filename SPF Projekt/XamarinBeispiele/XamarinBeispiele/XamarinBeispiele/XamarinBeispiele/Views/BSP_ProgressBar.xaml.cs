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
	public partial class BSP_ProgressBar : ContentPage
	{
		public BSP_ProgressBar()
		{
			InitializeComponent ();

            var layout = new StackLayout();

            var ProgressBar = new ProgressBar {Progress=0 };
            var ProgressBar2 = new ProgressBar {BackgroundColor = Color.White , Progress  = 0};

            layout.Children.Add(ProgressBar);
            layout.Children.Add(ProgressBar2);

            ProgressBar.ProgressTo(1, 25000, Easing.CubicIn);
            ProgressBar2.ProgressTo(1, 25000, Easing.BounceIn);

            Content = layout;
        }
	}
}