using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using ProductModel;
using Newtonsoft.Json.Linq;
using System;

namespace HW5
{

    public partial class MainPage : ContentPage
    {
        public List<ProductData> items;



        /* ===== ||\    /|| ||==\       ==     ||==\     ======  //==\\   ||\      || =======
         *  ||   || \  / || ||   \     /  \    ||   \      ||   //    \\  || \     ||    ||          \
         *  ||   ||  \/  || ||    \   /    \   ||    \     ||   ||    ||  ||  \    ||    ||     ======\ CHANGE THE "fileName" VALUE TO MATCH THE PATH OF THE JSON FILE.
         *  ||   ||      || ||    /  ||    ||  ||    /     ||   ||====||  ||   \   ||    ||     ======/
         *  ||   ||      || ||====   ||    ||  ||====      ||   ||    ||  ||    \  ||    ||          /
         *  ||   ||      || ||        \   /    ||\\        ||   ||    ||  ||     \ ||    ||          
         * ===== ||      || ||         \=/     || \\       ||   ||    ||  ||      \||    ||
         */


        public string fileName = "/Users/enriquealonsoesposito/Desktop/CSUSM/CS481 Mobile Programming/HW5/HW5/HW5/products.json";


        public MainPage()
        {
            InitializeComponent();
            LoadJson();
        }

        public void LoadJson()
        {
            using (StreamReader r = new StreamReader(fileName))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<ProductData>>(json);
            }
            ProductsListView.ItemsSource = items;
        }

        private async void Handle_Clicked(object sender, System.EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var itemClicked = menuItem.CommandParameter as ProductData;
            await Navigation.PushAsync(new ItemPage(itemClicked));
        }
    }
}
