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
	public partial class BSP_RelativeLayout : ContentPage
	{
		public BSP_RelativeLayout()
		{
			InitializeComponent ();

            //var layout = new RelativeLayout();

            //var greenbox = new BoxView { Color = Color.Green };
            //var greenboxLabel1 = new Label { Text = "Ich bin das Label 1.Ich bin in der günen Box gefangen, da man mir die selbe Width and Height über Constraints mitgegeben hat." };
            //var greenboxLabel2 = new Label { Text = "Dieses Label hat im X und Y Constraint -100. Damit kann man um Pixel verschieben.Ansonsten sind die Werte und der Bezugspunkt mit Label 1 identisch." };

            //layout.Children.Add(greenbox,
            //    Constraint.RelativeToParent((parent) => { return (parent.Width * .5); }),
            //    Constraint.RelativeToParent((parent) => { return (parent.Height * .6); }),
            //    Constraint.Constant(160),
            //    Constraint.Constant(160)
            //    );

            //layout.Children.Add(greenboxLabel1,
            //    Constraint.RelativeToView(greenbox, (Parent, sibling) => { return sibling.X; }),
            //    Constraint.RelativeToView(greenbox, (parent, sibling) => { return sibling.Y; }),
            //    Constraint.RelativeToView(greenbox, (Parent, sibling) => { return sibling.Width; }),
            //    Constraint.RelativeToView(greenbox, (parent, sibling) => { return sibling.Height; }));

            //layout.Children.Add(greenboxLabel2,
            //    Constraint.RelativeToView(greenbox, (Parent, sibling) => { return sibling.X - 150; }),
            //    Constraint.RelativeToView(greenbox, (parent, sibling) => { return sibling.Y - 150; }),
            //    Constraint.RelativeToView(greenbox, (Parent, sibling) => { return sibling.Width; }),
            //    Constraint.RelativeToView(greenbox, (parent, sibling) => { return sibling.Height; }));

            //Content = layout;
        }
    }
}