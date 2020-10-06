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
    public partial class BSP_Label : ContentPage
    {
        public BSP_Label()
        {
            InitializeComponent();

            //seiteAufbauen();
        }

        private void seiteAufbauen()
        {
            Grid grid = new Grid { BackgroundColor = Color.LightGray, Margin = new Thickness(0, 30, 0, 0) };

            grid.RowDefinitions.Add(new RowDefinition { Height = 50 });
            grid.RowDefinitions.Add(new RowDefinition { Height = 50 });
            grid.RowDefinitions.Add(new RowDefinition { Height = 70 });

            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());

            Style style = new Style(typeof(Label))
            {
                Setters =
                {
                    new Setter { Property = Label.MarginProperty, Value = new Thickness() },
                    new Setter { Property = Label.BackgroundColorProperty, Value = Color.White}
                }
            };

            // Label mit CharakterWrap
            Label label1 = new Label();
            label1.LineBreakMode = LineBreakMode.CharacterWrap;
            label1.Style = style;
            label1.Text = "Hier wurde CharacterWrap verwendet";

            // Label mit HeadTruncation
            Label label2 = new Label();
            label2.LineBreakMode = LineBreakMode.HeadTruncation;
            label2.Style = style;
            label2.Text = "Hier wurde HeadTruncation verwendet";

            // Label mit MiddleTruncation
            Label label3 = new Label();
            label3.LineBreakMode = LineBreakMode.MiddleTruncation;
            label3.Style = style;
            label3.Text = "Hier wurde MiddleTruncation verwendet";

            // Label mit NoWrap (Standard)
            Label label4 = new Label();
            label4.LineBreakMode = LineBreakMode.NoWrap;
            label4.Style = style;
            label4.Text = "Hier wurde NoWrap verwendet";

            // Label mit TailTruncation
            Label label5 = new Label();
            label5.LineBreakMode = LineBreakMode.TailTruncation;
            label5.Style = style;
            label5.Text = "Hier wurde TailTruncation verwendet";

            // Label mit WordWrap
            Label label6 = new Label();
            label6.LineBreakMode = LineBreakMode.WordWrap;
            label6.Style = style;
            label6.Text = "Hier wurde WordWrap verwendet";

            // Label mit FormattedString
            Label label7 = new Label();
            label7.Style = style;

            // neuer FormattedString erstellt
            FormattedString s = new FormattedString();

            // FormattedString mit Spans befüllen
            s.Spans.Add(new Span { Text = "In Blau ", ForegroundColor = Color.Blue });
            s.Spans.Add(new Span { Text = "ist alles " });
            s.Spans.Add(new Span { Text = "Schöner", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Span)), FontAttributes = FontAttributes.Bold });

            // FormattedString einfügen
            label7.FormattedText = s;

            grid.Children.Add(label1, 0, 0);
            grid.Children.Add(label2, 1, 0);
            grid.Children.Add(label3, 2, 0);
            grid.Children.Add(label4, 0, 1);
            grid.Children.Add(label5, 1, 1);
            grid.Children.Add(label6, 2, 1);
            grid.Children.Add(label7, 1, 2);

            Content = grid;
        }
    }
}