using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HW3_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var pokemon1 = new PokemonModel
            {
                pokemonNumber = 151,
                pokemonName = "Mew",
                pokemonImg1 = "https://usercontent1.hubstatic.com/14145286_f520.jpg",
                pokemonImg2 = "",
                pokemonImg3 = "",
            };
        }
    }
}
