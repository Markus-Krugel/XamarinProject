using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinBeispiele
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BSP_GestureRecognizer : ContentPage
	{
        private bool isZoomed;

		public BSP_GestureRecognizer()
		{
			InitializeComponent ();

            seiteAufbauen();
		}

        private void seiteAufbauen()
        {
            AbsoluteLayout absolut = new AbsoluteLayout ();

            Label hilfe = new Label { Text = "Einzelklick für Farbwechsel, Doppelklick für Zoom an/ausschalten, Ziehen für Verschieben, Zerren für Skalieren" };

            // Die GestureRecognizer werden erstellt und die dazugehörigen Methoden zugeordnet

            PanGestureRecognizer pan = new PanGestureRecognizer();
            pan.PanUpdated += Verschieben;

            PinchGestureRecognizer pinch = new PinchGestureRecognizer();
            pinch.PinchUpdated += Skalieren;

            TapGestureRecognizer einzelKlick = new TapGestureRecognizer();
            einzelKlick.Tapped += FarbeWechseln;
            einzelKlick.NumberOfTapsRequired = 1;

            TapGestureRecognizer doppelKlick = new TapGestureRecognizer();
            doppelKlick.Tapped += Zoom;
            doppelKlick.NumberOfTapsRequired = 2;

            // Die GestureRecognizer werden dem Stacklayout hinzugefügt

            absolut.GestureRecognizers.Add(pan);
            absolut.GestureRecognizers.Add(pinch);
            absolut.GestureRecognizers.Add(einzelKlick);
            absolut.GestureRecognizers.Add(doppelKlick);

            FarbBox = new BoxView { Color = Color.Aquamarine };

            AbsoluteLayout.SetLayoutBounds(FarbBox, new Rectangle (0.2, 0.2, 100, 100));
            AbsoluteLayout.SetLayoutFlags(FarbBox, AbsoluteLayoutFlags.PositionProportional);

            absolut.Children.Add(hilfe);
            absolut.Children.Add(FarbBox);

            Content = absolut;
        }

        // ändert zufällig die Farbe der Boxview
        private void FarbeWechseln(Object sender, EventArgs e)
        {
            Random random = new Random();
            double r = random.NextDouble();
            double g = random.NextDouble();
            double b = random.NextDouble();

            FarbBox.Color = Color.FromRgb(r, g, b);
        }

        // verschiebt die Boxview anhand der Wischgeste
        private void Verschieben(object sender, PanUpdatedEventArgs e)
        {
            FarbBox.TranslateTo(FarbBox.X + e.TotalX, FarbBox.Y + e.TotalY);
        }

        // skaliert die Boxview anhand der Zoombewegung
        private void Skalieren(object sender, PinchGestureUpdatedEventArgs e)
        {
            AbsoluteLayout.SetLayoutBounds(FarbBox, new Rectangle(0.2, 0.2, FarbBox.Height * e.Scale, FarbBox.Width * e.Scale));
        }

        // verdoppelt oder halbiert die Größe der Boxview
        private void Zoom(object sender, EventArgs e)
        {
            isZoomed = !isZoomed;

            if(isZoomed)
            {
                AbsoluteLayout.SetLayoutBounds(FarbBox, new Rectangle(0.2, 0.2, FarbBox.Height * 2, FarbBox.Width * 2));
            }
            else
            {
                AbsoluteLayout.SetLayoutBounds(FarbBox, new Rectangle(0.2, 0.2, FarbBox.Height * 0.5, FarbBox.Width * 0.5));
            }
        }
    }
}