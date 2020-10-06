using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace XamarinBeispiele
{
    public class ColorToDouble : IValueConverter
    {
        public Color Momentan { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter is String)
            {
                String text = (String)parameter;

                // Je nach Parameter soll der entsprechende Wert zurückgegeben werden
                switch (text)
                {
                    case "Rot":
                        return ((Color)value).R;
                    case "Grün":
                        return ((Color)value).G;
                    case "Blau":
                        return ((Color)value).B;
                }
            }
            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter is String && value is double)
            {
                String text = (String)parameter;
                double wert = (double)value;

                // Je nach Parameter soll eine Farbe mit entsprechenden neuem Wert erstellt werden
                switch (text)
                {
                    case "Rot":
                        {
                            Momentan = Color.FromRgb(wert, Momentan.G, Momentan.B);
                            return Momentan;
                        }
                    case "Grün":
                        {
                            Momentan = Color.FromRgb(Momentan.R, wert, Momentan.B);
                            return Momentan;
                        }
                    case "Blau":
                        {
                            Momentan = Color.FromRgb(Momentan.R, Momentan.G, wert);
                            return Momentan;
                        }
                }
            }
            return Momentan;
        }
    }
}
