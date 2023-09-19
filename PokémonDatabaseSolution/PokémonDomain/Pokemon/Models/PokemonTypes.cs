using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonDomain
{
    public class PokemonTypes
    {
        [Key]
        public int PokemonTypesId { get; set; }
        public PokemonType FirstPokemonType { get; set; }
        public PokemonType SecondPokemonType { get; set; }
    }
}
