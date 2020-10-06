using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinBeispiele
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //globalerStyle();
            MainPage = new NavigationPage(new XamarinBeispiele.NavigationsMenue());
        }

        private void globalerStyle()
        {
            var blauZentriert = new Style(typeof(Label))
            {
                Setters =
                {
                    new Setter{Property = Label.BackgroundColorProperty, Value = Color.White},
                    new Setter{Property = Label.VerticalOptionsProperty, Value = LayoutOptions.CenterAndExpand},
                    new Setter{Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.CenterAndExpand},
                    new Setter{Property = Label.TextColorProperty, Value = Color.Blue },
                    new Setter{Property = Label.TextProperty, Value ="Globaler Style"}
                }
            };

            Resources = new ResourceDictionary();
            Resources.Add("blauZentriert", blauZentriert);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
