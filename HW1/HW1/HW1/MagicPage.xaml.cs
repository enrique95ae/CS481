using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HW1
{
    public partial class MagicPage : ContentPage
    {
        public MagicPage()
        {
            InitializeComponent();
        }
         
        private async void MessageBtn_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert(":)","Just a pop up message", "Back to main page");
            await Navigation.PopAsync();
        }
    }
}
