using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace XamarinBeispiele
{
    class lagerMengeToBoolConverter : IValueConverter
    {
        /* Vergleicht die Bestellmenge mit der Lagermenge des Models
           und gibt aus, ob die Bestellmenge größer ist als die Lagermenge */
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double bestellung = (double)value;

            Picker lager = ((Picker)parameter);
            if ((BSP_Model)lager.SelectedItem != null)
            {
                BSP_Model model = (BSP_Model)lager.SelectedItem;
                return bestellung > model.LagerMenge;
            }
            return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return 0;
        }
    }
}
