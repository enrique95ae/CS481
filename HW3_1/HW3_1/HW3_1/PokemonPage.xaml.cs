using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace HW3_1
{
    public partial class PokemonPage : ContentPage
    {
        public PokemonPage(ObservableCollection<PokemonModel> list)
        {
            InitializeComponent();
            titleLabel.Text = list[0].pokemonName;
            pokemonPic0.Source = list[0].pokemonImg1;
            pokemonDescription.Text = list[0].pokemonDescription;
        }
    }
}
