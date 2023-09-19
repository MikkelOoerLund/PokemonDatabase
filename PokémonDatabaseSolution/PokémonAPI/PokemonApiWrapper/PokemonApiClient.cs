using System;
using System.Threading.Tasks;
using PokeApiNet;

namespace PokémonAPI
{
    public class PokemonApiClient
    {
        private readonly PokeApiClient _pokeApiClient;

        public PokemonApiClient()
        {
            _pokeApiClient = new PokeApiClient();
        }


        public async Task<Pokemon> GetPokemonWithId(int id)
        {
            var pokemon = await _pokeApiClient.GetResourceAsync<Pokemon>(id);
            return pokemon;
        }
    }

}
