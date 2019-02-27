using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace APIpracticeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //call here
        }

        async void GeneratePicButton_Clicked(object sender, EventArgs e)
        {
            string dogApiEndpoint = "https://dog.ceo/api/breeds/image/random";
            Uri dogApiUri = new Uri(dogApiEndpoint);

            HttpClient client = new HttpClient();
            DogData dogData = new DogData();

            HttpResponseMessage response = await client.GetAsync(dogApiUri);

            string jsonContent = await response.Content.ReadAsStringAsync();

            dogData = JsonConvert.DeserializeObject<DogData>(jsonContent);

            dogImage.Source = dogData.Message;
        }
    }
}
