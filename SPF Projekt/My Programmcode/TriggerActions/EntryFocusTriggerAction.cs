using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinBeispiele
{
    class EntryFocusTriggerAction: TriggerAction<Entry>
    {
        public EntryFocusTriggerAction() { }

        public Color Farbe { set; get; }

        protected override void Invoke(Entry sender)
        {
            sender.BackgroundColor = Farbe;
        }
    }
}
