using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinBeispiele
{
    // Soll vom "INotifyPropertyChanged" Interface erben
    class BSP_ViewModel : INotifyPropertyChanged
    {
        // Eine Liste der Waren
        private ObservableCollection<BSP_Model> waren;
        public ObservableCollection<BSP_Model> Waren
        {
            set
            {
                waren = value;
                OnPropertyChanged("Waren");
            }
            get { return waren; }
        }

        // Das zurzeit ausgewählte Model
        private BSP_Model gewaehlt;
        public BSP_Model Gewaehlt
        {
            get
            {
                return gewaehlt;
            }
            set
            {
                gewaehlt = value;
                Lagermenge = Gewaehlt.LagerMenge;
                OnPropertyChanged("Gewaehlt");
            }
        }

        // Die Lagermenge des Models
        public double Lagermenge
        {
            get
            {
                if (Gewaehlt == null)
                    return 0;
                return Gewaehlt.LagerMenge;
            }
            set
            {
                Gewaehlt.LagerMenge = (int)value;
                OnPropertyChanged("Lagermenge");
            }
        }

        // Der Bestell-Command
        public Command bestellen { get; set; }

        // Von INotifyPropertyChanged gefordert
        public event PropertyChangedEventHandler PropertyChanged;

        public BSP_ViewModel()
        {
            warenFuellen();

            Gewaehlt = Waren[0];

            // Der Command wird erstellt
            bestellen = new Command<Slider>(
                execute: (Slider bestellmenge) =>
                {
                    Lagermenge -= bestellmenge.Value;
                    OnPropertyChanged("Waren");

                    /* Die Liste wird durchgegangen und wenn das Model mit
                       der gleichen Bezeichnung gefunden wurde, wird dessen
                       Lagermenge um die Bestellmenge reduziert*/
                    foreach (BSP_Model model in Waren)
                    {
                        if (model.Bezeichnung.Equals(Gewaehlt.Bezeichnung))
                        {
                            Waren[Waren.IndexOf(model)].LagerMenge = Gewaehlt.LagerMenge;
                            OnPropertyChanged("Waren");
                            break;
                        }
                    }
                }
            );
        }

        // Die Liste wird befüllt
        private void warenFuellen()
        {
            Waren = new ObservableCollection<BSP_Model>();

            // Das Event "CollectionChanged" löst die Methode "Ausfuehren" aus
            Waren.CollectionChanged += Ausfuehren;
            Waren.Add(new BSP_Model("Bitte auswählen", 0));
            Waren.Add(new BSP_Model("Spielekonsole", 70));
            Waren.Add(new BSP_Model("Grafikkarte", 60));
            Waren.Add(new BSP_Model("Telefon", 75));
            Waren.Add(new BSP_Model("Fernseher", 80));
            Waren.Add(new BSP_Model("Headset", 90));
        }

        // ruft OnPropertyChanged mit dem übergebenen String "Waren" auf
        private void Ausfuehren(Object sender, EventArgs e) => OnPropertyChanged("Waren");

        // Bei einer Veränderung einer Property, sollte dies aufgerufen werden 
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
