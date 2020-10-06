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
	public partial class BSP_AbsuluteLayout : ContentPage
	{
		public BSP_AbsuluteLayout()
		{
			InitializeComponent ();

            //BackgroundColor = Color.LightGray;
            //var absoluteLayout = new AbsoluteLayout();

            //var absoluteText = new Label
            //{
            //    Text = "Ich bin absolut Positoniert.",
            //    LineBreakMode = LineBreakMode.WordWrap
            //};
            //AbsoluteLayout.SetLayoutBounds(absoluteText, new Rectangle(115, 150, 100, 100));

            //var proportionalText = new Label
            //{
            //    Text = "Ich bin proportional Positoniert.",
            //    LineBreakMode = LineBreakMode.WordWrap
            //};
            //AbsoluteLayout.SetLayoutBounds(proportionalText, new Rectangle(.5, 1, .5, .1));
            //AbsoluteLayout.SetLayoutFlags(proportionalText, AbsoluteLayoutFlags.All);

            //var viewboxLeft = new BoxView { Color = Color.Red };
            //AbsoluteLayout.SetLayoutBounds(viewboxLeft, new Rectangle(0, .5, 25, 100));
            //AbsoluteLayout.SetLayoutFlags(viewboxLeft, AbsoluteLayoutFlags.PositionProportional);

            //var viewboxRight = new BoxView { Color = Color.Yellow };
            //AbsoluteLayout.SetLayoutBounds(viewboxRight, new Rectangle(1, .5, 25, 100));
            //AbsoluteLayout.SetLayoutFlags(viewboxRight, AbsoluteLayoutFlags.PositionProportional);

            //var viewboxTop = new BoxView { Color = Color.Blue };
            //AbsoluteLayout.SetLayoutBounds(viewboxTop, new Rectangle(.5, 0, 100, 25));
            //AbsoluteLayout.SetLayoutFlags(viewboxTop, AbsoluteLayoutFlags.PositionProportional);

            //var viewboxBottom = new BoxView { Color = Color.Green };
            //AbsoluteLayout.SetLayoutBounds(viewboxBottom, new Rectangle(.5, 1, 100, 25));
            //AbsoluteLayout.SetLayoutFlags(viewboxBottom, AbsoluteLayoutFlags.PositionProportional);

            //var viewboxItem = new BoxView { Color = Color.White };
            //AbsoluteLayout.SetLayoutBounds(viewboxItem, new Rectangle(100, 100, .5, .5));
            //AbsoluteLayout.SetLayoutFlags(viewboxItem, AbsoluteLayoutFlags.SizeProportional);

            //var viewboxShadow = new BoxView { Color = Color.Black };
            //AbsoluteLayout.SetLayoutBounds(viewboxShadow, new Rectangle(.5, .5, .5, .5));
            //AbsoluteLayout.SetLayoutFlags(viewboxShadow, AbsoluteLayoutFlags.All);



            //absoluteLayout.Children.Add(viewboxShadow);
            //absoluteLayout.Children.Add(viewboxItem);

            //absoluteLayout.Children.Add(viewboxLeft);
            //absoluteLayout.Children.Add(viewboxRight);
            //absoluteLayout.Children.Add(viewboxTop);
            //absoluteLayout.Children.Add(viewboxBottom);

            //absoluteLayout.Children.Add(proportionalText);
            //absoluteLayout.Children.Add(absoluteText);

            //Content = absoluteLayout;
        }
	}
}