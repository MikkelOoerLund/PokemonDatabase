using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonDomain
{
    public class PokemonTypeContainer
    {
        public int PokemonTypeContainerId { get; set; }
        public PokemonType FirstPokemonType { get; set; }
        public PokemonType SecondPokemonType { get; set; }
    }
}
