using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HW3_1
{
    public partial class MainPage : ContentPage
    {

        ObservableCollection<PokemonModel> pokemonList = new ObservableCollection<PokemonModel>();

        public MainPage()
        {
            InitializeComponent();

            //var pokemonList = new ObservableCollection<PokemonModel>();

            var pokemon1 = new PokemonModel
            {
                pokemonNumber = 151,
                pokemonName = "Mew",
                pokemonImg1 = "https://usercontent1.hubstatic.com/14145286_f520.jpg",
                //pokemonImg2 = "",
                //pokemonImg3 = "",
                pokemonDescription = "Mew is a pink, bipedal Pokémon with mammalian features. Its snout is short and wide, and it has triangular ears and large, blue eyes. It has short arms with three-fingered paws, large hind legs and feet with oval markings on the soles, and a long, thin tail ending in an ovoid tip. Its fur is so fine and thin, it can only be seen under a microscope. Mew is said to have the DNA of every single Pokémon contained within its body, and as such is able to learn any attack.",
            };

            pokemonList.Add(pokemon1);

            titleLabel.Text = pokemonList[0].pokemonName;
            mewPic.Source = pokemonList[0].pokemonImg1;
        }

        private async void moreInfoButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PokemonPage(pokemonList));
        }
    }
}
