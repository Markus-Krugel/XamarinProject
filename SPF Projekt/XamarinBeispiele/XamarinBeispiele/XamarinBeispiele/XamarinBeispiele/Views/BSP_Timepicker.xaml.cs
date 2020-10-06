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
	public partial class BSP_Timepicker : ContentPage
	{
		public BSP_Timepicker()
		{
			InitializeComponent ();

            var layout = new StackLayout();

            layout.Children.Add(new TimePicker {Time= TimeSpan.FromMinutes(170), TextColor = Color.Black });
            layout.Children.Add(new TimePicker { TextColor = Color.Red });
            layout.Children.Add(new TimePicker { TextColor = Color.Red, Format = "hh:mm:ss" });
            Content = layout;
		}
	}
}