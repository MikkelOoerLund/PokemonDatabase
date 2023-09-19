using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonDomain
{
    public class PokemonBuilder
    {
        private Pokemon _pokemon;

        public PokemonBuilder()
        {
            _pokemon = new Pokemon();
        }

        public PokemonBuilder SetPokedexId(int pokedexId)
        {
            _pokemon.PokedexId = pokedexId;
            return this;
        }

        public PokemonBuilder SetLevel(int level)
        {
            _pokemon.Level = level;
            return this;
        }

        public PokemonBuilder SetNickname(string nickname)
        {
            _pokemon.Nickname = nickname;
            return this;
        }

        public PokemonBuilder SetSpecie(PokemonSpecie specie)
        {
            _pokemon.Specie = specie;
            return this;
        }

        public PokemonBuilder SetBaseStats(PokemonBaseStats baseStats)
        {
            _pokemon.BaseStats = baseStats;
            return this;
        }

        public PokemonBuilder SetIncreaseValueStats(PokemonStatIncrementPerLevel statIncrementPerLevel)
        {
            _pokemon.StatIncrementPerLevel = statIncrementPerLevel;
            return this;
        }

        public Pokemon Build()
        {
            return _pokemon;
        }
    }

}
