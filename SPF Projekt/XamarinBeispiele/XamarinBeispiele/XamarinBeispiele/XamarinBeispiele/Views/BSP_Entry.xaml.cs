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
	public partial class BSP_Entry : ContentPage
	{
        ScrollView scroll = new ScrollView();
        StackLayout stacklayout = new StackLayout();

        Entry username = new Entry();
        Entry passwort = new Entry();

        Button reLogin = new Button();

        Entry lStart = new Entry();
        Entry lCenter = new Entry();
        Entry lEnd = new Entry();

        Entry troll = new Entry();

        public BSP_Entry()
        {
            InitializeComponent();

            var layout = new StackLayout { };

            username = new Entry { IsPassword = false,  Placeholder = "Ich bin kein Passwort" };
            passwort = new Entry { IsPassword = true,   Placeholder = "Ich bin ein Passwort drücke " +
                                                                     "'Enter' nach Beendigung der Eingabe", };
            passwort.Completed += Passwort_Completed;

            reLogin = new Button { Text = "Wenn man mich Clickt enable Ich" +
                " Username und Passwort wieder", IsEnabled = false };
            reLogin.Clicked 
                += ReLogin_Clicked;

            lStart  = new Entry { Placeholder = "Ich schreib von Links nach Rechts",
                HorizontalTextAlignment = TextAlignment.Start, AutomationId = "Passwort", StyleId = "Username" };
            lCenter = new Entry { Placeholder = "Ich schreibe in der Mitte",
                HorizontalTextAlignment = TextAlignment.Center };
            lEnd    = new Entry { Placeholder = "Ich schreib von Rechts nach Links",
                HorizontalTextAlignment = TextAlignment.End };

            troll = new Entry { Placeholder = "Du kannst nichts in mich schreiben, da ich deine Eingabe lösche." };
            troll.TextChanged += Troll_TextChanged;


            layout.Children.Add(username);
            layout.Children.Add(passwort);
            layout.Children.Add(reLogin);
            layout.Children.Add(lStart);
            layout.Children.Add(lCenter);
            layout.Children.Add(lEnd);
            layout.Children.Add(troll);

            scroll.Content = layout;

            Content = scroll;
        }

        private void ReLogin_Clicked(object sender, EventArgs e)
        {
            passwort.IsEnabled = true;
            username.IsEnabled = true;
            reLogin.IsEnabled = false;
            username.Text = "";
            passwort.Text = "";
        }

        private void Passwort_Completed(object sender, EventArgs e)
        {
            passwort.IsEnabled = false;
            username.IsEnabled = false;
            reLogin.IsEnabled = true;

        }

        private void Troll_TextChanged(object sender, TextChangedEventArgs e)
        {
            troll.Text = "";
        }
    }
}