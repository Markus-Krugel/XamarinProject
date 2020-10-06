using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace XamarinBeispiele
{
    public class DoubletoRGBValue : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //übersetzt den double Wert von 0 bis 1 in richtige RGB Werte
            return System.Convert.ToInt32((double)value * 255);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return 0;
        }
    }
}
