using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TestLibrary
{
    public class TestLibrary : ContentPage
    {
        public TestLibrary()
        {
            var button = new Button
            {
                Text = "Click Me Now!",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            int clicked = 0;
            button.Clicked += (s, e) => button.Text = "Clicked by Srini: " + clicked++;

            Content = button;
        }
    }
}
