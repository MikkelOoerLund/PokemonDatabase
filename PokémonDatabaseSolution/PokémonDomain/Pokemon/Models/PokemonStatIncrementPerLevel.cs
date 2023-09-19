using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokémonDomain
{
    public class PokemonStatIncrementPerLevel
    {
        [Key]
        public int PokedexId { get; set; }

        public int HpIncrement { get; set; }
        public int AttackIncrement { get; set; }
        public int DefenseIncrement { get; set; }
        public int SpecialAttackIncrement { get; set; }
        public int SpecialDefenseIncrement { get; set; }
        public int SpeedIncrement { get; set; }
    }

}
