using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace HW4
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Pokemon> PokemonList { get; set; }

        public MainPage()
        {
            InitializeComponent();
            PopulateList();
        }

        private void PopulateList()
        {
            PokemonList = new ObservableCollection<Pokemon>()
            {
                new Pokemon()
                {
                    Name = "Pikachu",
                    Type = "Electric",
                    ImageSource = "https://republica.gt/wp-content/uploads/2017/10/pikachu.jpg"
                },

                new Pokemon()
                {
                    Name = "Sudowoodo",
                    Type = "Rock",
                    ImageSource = "https://pmg.gishan.cc/static/i/p/sudowoodo.jpg"
                },

                new Pokemon()
                {
                    Name = "Gyarados",
                    Type = "Water",
                    ImageSource = "https://cdn.bulbagarden.net/upload/thumb/4/41/130Gyarados.png/250px-130Gyarados.png"
                },

                new Pokemon()
                {
                    Name = "Charizard",
                    Type = "Fire",
                    ImageSource = "https://img.rankedboost.com/wp-content/uploads/2018/10/Charizard-Pokemon-Lets-GO.png"
                },

                new Pokemon()
                {
                    Name = "Rayquaza",
                    Type = "Dragon",
                    ImageSource = "https://cdn.bulbagarden.net/upload/thumb/e/e4/384Rayquaza.png/500px-384Rayquaza.png"
                }
            };

            PokemonListView.ItemsSource = PokemonList;
        }

        void Handle_Refreshing(object sender, System.EventArgs e)
        {
            PopulateList();
            PokemonListView.IsRefreshing = false;
        }

        void Handle_DeletePokemon(object sender, EventArgs e)
        { 
            var menuItem = (MenuItem)sender;
            var pokemonDelete = (Pokemon)menuItem.CommandParameter;
            PokemonList.Remove(pokemonDelete);
        }
    }
}
