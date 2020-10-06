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
    public partial class BSP_MasterPageDetail : ContentPage
    {
        private int listId;

        public int ListId
        {
            get
            {
                return listId;
            }
            set
            {
                listId = value;

                var stacklayout = new StackLayout();

                switch (ListId)
                {
                    case 0:
                        {
                            this.Content = new BSP_ScrollView().Content;
                            break;
                        }

                    case 1:
                        {
                            this.Content = new BSP_RelativeLayout().Content;
                            break;
                        }

                    case 2:
                        {
                            this.Content = new BSP_Stepper().Content;
                            break;
                        }

                    case 3:
                        {
                            this.Content = new BSP_TableView().Content;
                            break;
                        }

                    case 4:
                        {
                            this.Content = new BSP_ListView().Content;
                            break;
                        }
                }

            }
        }

        public BSP_MasterPageDetail()
        {
            InitializeComponent();
        }
    }
}