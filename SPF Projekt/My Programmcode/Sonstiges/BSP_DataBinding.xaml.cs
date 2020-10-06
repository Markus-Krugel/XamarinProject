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
	public partial class BSP_DataBinding : ContentPage
	{
		public BSP_DataBinding()
		{
			InitializeComponent ();
            seiteAufbauen();
		}

        private void seiteAufbauen()
        {
            AbsoluteLayout layout = new AbsoluteLayout() { BackgroundColor = Color.LightGray };

            ColorToDouble converter = new ColorToDouble { Momentan = Color.Black };

            BoxView box = new BoxView { BackgroundColor = Color.Black };

            Label labelRot = new Label();
            Label labelGrün = new Label();
            Label labelBlau = new Label();

            Slider sliderRot = new Slider { Minimum = 0, Maximum = 1 };
            Slider sliderGrün = new Slider { Minimum = 0, Maximum = 1 };
            Slider sliderBlau = new Slider { Minimum = 0, Maximum = 1 };

            // Die Value Werte der Sliders werden mit dem Value Property des entsprechenden Sliders verknüpft.
            // Dabei wird noch ein Converter übergeben, der noch ein Parameter bekommt für die Zuweisung des RGB Wertes
            Binding bindingRotSlider = new Binding("BackgroundColor", source: box) { Converter = converter, ConverterParameter = "Rot" };
            sliderRot.SetBinding(Slider.ValueProperty, bindingRotSlider);

            Binding bindingGrünSlider = new Binding("BackgroundColor", source: box) { Converter = converter, ConverterParameter = "Grün" };
            sliderGrün.SetBinding(Slider.ValueProperty, bindingGrünSlider);

            Binding bindingBlauSlider = new Binding("BackgroundColor", source: box) { Converter = converter, ConverterParameter = "Blau" };
            sliderBlau.SetBinding(Slider.ValueProperty, bindingBlauSlider);

            // Die Text Value der Labels werden mit der Background Property der BoxView verknüpft.
            // Dazwischen ist ein Converter, der die Zahlen zu einem richtigen RGB Wert verwandelt und anschließend mit einem StringFormat ausgegeben wird
            Binding bindingRotLabel = new Binding("Value", source: sliderRot) { Converter = new DoubletoRGBValue(), StringFormat = "R : {0:d}" };
            labelRot.SetBinding(Label.TextProperty, bindingRotLabel);

            Binding bindingGrünLabel = new Binding("Value", source: sliderGrün) { Converter = new DoubletoRGBValue(), StringFormat = "G : {0:d}" };
            labelGrün.SetBinding(Label.TextProperty, bindingGrünLabel);

            Binding bindingBlauLabel = new Binding("Value", source: sliderBlau) { Converter = new DoubletoRGBValue(), StringFormat = "B : {0:d}" };
            labelBlau.SetBinding(Label.TextProperty, bindingBlauLabel);

            AbsoluteLayout.SetLayoutBounds(box, new Rectangle(0.3, 0.1, 0.8, 0.2));
            AbsoluteLayout.SetLayoutFlags(box, AbsoluteLayoutFlags.All);

            AbsoluteLayout.SetLayoutBounds(labelRot, new Rectangle(0.1, 0.4, 0.1, 0.1));
            AbsoluteLayout.SetLayoutFlags(labelRot, AbsoluteLayoutFlags.All);

            AbsoluteLayout.SetLayoutBounds(labelGrün, new Rectangle(0.1, 0.6, 0.1, 0.1));
            AbsoluteLayout.SetLayoutFlags(labelGrün, AbsoluteLayoutFlags.All);

            AbsoluteLayout.SetLayoutBounds(labelBlau, new Rectangle(0.1, 0.8, 0.1, 0.1));
            AbsoluteLayout.SetLayoutFlags(labelBlau, AbsoluteLayoutFlags.All);

            AbsoluteLayout.SetLayoutBounds(sliderRot, new Rectangle(0.4, 0.4, 0.5, 0.1));
            AbsoluteLayout.SetLayoutFlags(sliderRot, AbsoluteLayoutFlags.All);

            AbsoluteLayout.SetLayoutBounds(sliderGrün, new Rectangle(0.4, 0.6, 0.5, 0.1));
            AbsoluteLayout.SetLayoutFlags(sliderGrün, AbsoluteLayoutFlags.All);

            AbsoluteLayout.SetLayoutBounds(sliderBlau, new Rectangle(0.4, 0.8, 0.5, 0.1));
            AbsoluteLayout.SetLayoutFlags(sliderBlau, AbsoluteLayoutFlags.All);

            layout.Children.Add(box);
            layout.Children.Add(labelRot);
            layout.Children.Add(labelGrün);
            layout.Children.Add(labelBlau);
            layout.Children.Add(sliderRot);
            layout.Children.Add(sliderGrün);
            layout.Children.Add(sliderBlau);

            Content = layout;
        }
	}
}