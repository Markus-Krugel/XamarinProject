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
    public partial class BSP_TabbedPage : TabbedPage
    {
        public BSP_TabbedPage()
        {
            InitializeComponent();

            Children.Add(new BSP_ScrollView() {Title="ScrollView" });
            Children.Add(new BSP_Stepper() {Title="Stepper" });
            Children.Add(new BSP_Grid() {Title = "Grid" });
        }
    }
}