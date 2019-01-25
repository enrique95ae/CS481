using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HW1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //Button click handler
        private async void MagicBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MagicPage());
        }
    }
}
