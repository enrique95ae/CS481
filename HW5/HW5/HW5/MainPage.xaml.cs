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
        ProductData productDataFromJson = new ProductData();



        /* ===== ||\    /|| ||==\       ==     ||==\     ======  //==\\   ||\      || =======
         *  ||   || \  / || ||   \     /  \    ||   \      ||   //    \\  || \     ||    ||          \
         *  ||   ||  \/  || ||    \   /    \   ||    \     ||   ||    ||  ||  \    ||    ||     ======\ CHANGE THE "fileName" VALUE TO MATCH THE PATH OF THE LOCAL JSON FILE.
         *  ||   ||      || ||    /  ||    ||  ||    /     ||   ||====||  ||   \   ||    ||     ======/
         *  ||   ||      || ||====   ||    ||  ||====      ||   ||    ||  ||    \  ||    ||          /
         *  ||   ||      || ||        \   /    ||\\        ||   ||    ||  ||     \ ||    ||          
         * ===== ||      || ||         \=/     || \\       ||   ||    ||  ||      \||    ||
         */


        public string fileName = "./products.json";

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

        //public void LoadJson()
        //{
        //    //var fileName = "HW5.products.json";

        //    var assembly = typeof(MainPage).GetTypeInfo().Assembly;
        //    Stream stream = assembly.GetManifestResourceStream(fileName);

        //    using (var reader = new System.IO.StreamReader(stream))
        //    {
        //        var jsonAsString = reader.ReadToEnd();
        //        productDataFromJson = JsonConvert.DeserializeObject<ProductData>(jsonAsString);

        //    }


        //    ProductsListView.ItemsSource = new ObservableCollection<ProductData>(productDataFromJson);

        //}

        private async void Handle_Clicked(object sender, System.EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var itemClicked = menuItem.CommandParameter as ProductData;
            await Navigation.PushAsync(new ItemPage(itemClicked));
        }
    }
}
