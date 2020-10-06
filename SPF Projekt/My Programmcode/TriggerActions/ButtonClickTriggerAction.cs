using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinBeispiele
{
    public class ButtonClickTriggerAction : TriggerAction<Button>
    {
        protected override void Invoke(Button button)
        {
            button.BackgroundColor = Color.Green;
        }
    }
}
