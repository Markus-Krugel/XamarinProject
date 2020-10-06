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
    public partial class BSP_Editor : ContentPage
    {
        StackLayout layout = new StackLayout();

        Editor text = new Editor();

        Button reLogin = new Button { IsEnabled = false,
            Text = "Wenn man mich Clickt enable Ich Username und Passwort wieder" };
        Editor editor = new Editor { HeightRequest = 70 };
        Editor troll = new Editor();



        public BSP_Editor()
        {
            InitializeComponent();

            text = new Editor();

            text.Completed += Text_Completed;
            reLogin.Clicked += ReLogin_Clicked;
            troll.TextChanged += Troll_TextChanged;


            layout.Children.Add(text);
            layout.Children.Add(reLogin);
            layout.Children.Add(editor);
            layout.Children.Add(troll);

            Content = layout;
        }



        private void ReLogin_Clicked(object sender, EventArgs e)
        {
            text.IsEnabled = true;
            reLogin.IsEnabled = false;
            text.Text = "";
        }

        private void Text_Completed(object sender, EventArgs e)
        {
            text.IsEnabled = false;
            reLogin.IsEnabled = true;
        }

        private void Troll_TextChanged(object sender, TextChangedEventArgs e)
        {
            troll.Text = "";
        }
    }
}
