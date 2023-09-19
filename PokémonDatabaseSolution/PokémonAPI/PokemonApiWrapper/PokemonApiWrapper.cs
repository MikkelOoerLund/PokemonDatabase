using PokeApiNet;

namespace PokémonAPI
{
    public class PokemonApiWrapper
    {
        private Pokemon _pokemon;

        public PokemonApiWrapper(Pokemon pokemon)
        {
            _pokemon = pokemon;
        }

        public Dictionary<PokemonStatName, int> GetBaseStatsByName()
        {
            var stats = _pokemon.Stats;
            var statCount = stats.Count;
            var baseStats = new Dictionary<PokemonStatName, int>();


            for (int statIndex = 0; statIndex < statCount; statIndex++)
            {
                var stat = stats[statIndex];
                var key = (PokemonStatName)statIndex;
                baseStats[key] = stat.BaseStat;
            }


            return baseStats;
        }


        public void SetWrapedPokemon(Pokemon pokemon)
        {
            _pokemon = pokemon;
        }
    }
}
