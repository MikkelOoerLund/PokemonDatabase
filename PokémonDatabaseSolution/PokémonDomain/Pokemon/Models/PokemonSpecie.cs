using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonDomain
{
    public class PokemonSpecie
    {
        [Key]
        public int PokedexId { get; set; }

        [ForeignKey("PokemonTypesId")]
        public int PokemonTypesId { get; set; }

        public string Name { get; set; }

        public virtual PokemonTypes Types { get; set; }
    }
}
