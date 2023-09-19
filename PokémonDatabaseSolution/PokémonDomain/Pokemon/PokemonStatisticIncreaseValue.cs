using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonDomain
{
    public class PokemonStatisticIncreaseValue
    {
        public int PokedexID { get; set; }

        public int HpIncrease { get; set; }
        public int AttackIncrease { get; set; }
        public int DefenseIncrease { get; set; }
        public int SpecialAttackIncrease { get; set; }
        public int SpecialDefenseIncrease { get; set; }
        public int SpeedIncrease { get; set; }
    }
}
