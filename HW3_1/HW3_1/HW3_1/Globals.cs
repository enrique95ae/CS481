using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Net.Sockets;

namespace HW3_1
{
    public class PokemonModel
    {

        public int pokemonNumber { get; set; }
        public string pokemonName { get; set; }
        public string pokemonDescription { get; set; }

        //more data...

        public ImageSource pokemonImg1 { get; set; }
        public ImageSource pokemonImg2 { get; set; }
        public ImageSource pokemonImg3 { get; set; }

    }
}