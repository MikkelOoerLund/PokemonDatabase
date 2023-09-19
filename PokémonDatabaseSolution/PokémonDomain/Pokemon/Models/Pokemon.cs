using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonDomain
{
    public class Pokemon
    {
        [Key]
        public int PokemonId { get; set; }

        [ForeignKey("PokedexId")]
        public int PokedexId { get; set; }

        public int Level { get; set; }
        public string Nickname { get; set; }

        public virtual PokemonSpecie Specie { get; set; }
        public virtual PokemonBaseStats BaseStats { get; set; }
        public virtual PokemonStatIncrementPerLevel StatIncrementPerLevel { get; set; }
    }
}