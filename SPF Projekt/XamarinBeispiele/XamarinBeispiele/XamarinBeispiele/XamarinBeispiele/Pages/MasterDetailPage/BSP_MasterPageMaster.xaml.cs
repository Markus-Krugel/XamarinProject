using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinBeispiele.Images;

namespace XamarinBeispiele
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BSP_MasterPageMaster : ContentPage
    {
        public ListView ListView;

        public BSP_MasterPageMaster()
        {
            InitializeComponent();

            BindingContext = new Doku_MasterPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class Doku_MasterPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<BSP_MasterPageMenuItem> MenuItems { get; set; }
            
            public Doku_MasterPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<BSP_MasterPageMenuItem>(new[]
                {
                    new BSP_MasterPageMenuItem { Id = 0, Title = "ScrollView"},
                    new BSP_MasterPageMenuItem { Id = 1, Title = "RelativeLayout"},
                    new BSP_MasterPageMenuItem { Id = 2, Title = "Stepper"},
                    new BSP_MasterPageMenuItem { Id = 3, Title = "TableView"},
                    new BSP_MasterPageMenuItem { Id = 4, Title = "ListView"},
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}