using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonTypeCombination = System.ValueTuple<PokémonDomain.PokemonType, PokémonDomain.PokemonType>;

namespace PokémonDomain
{
    public class PokemonTypeContainerFactory
    {
        //private PokemonTypeContainerBuilder _pokemonTypeContainerBuilder;
        //private Dictionary<PokemonTypeCombination, PokemonTypeContainer> _pokemonTypeContainers;


        //public PokemonTypeContainerFactory(PokemonTypeContainerBuilder pokemonTypeContainerBuilder)
        //{
        //    _pokemonTypeContainerBuilder = pokemonTypeContainerBuilder;
        //    _pokemonTypeContainers = new Dictionary<PokemonTypeCombination, PokemonTypeContainer>();
        //}


        //public PokemonTypeContainer GetPokemonTypeContainer(PokemonTypeCombination pokemonTypeCombination)
        //{
        //    if (_pokemonTypeContainers.ContainsKey(pokemonTypeCombination))
        //    {
        //        return _pokemonTypeContainers[pokemonTypeCombination];
        //    }

        //    var firstType = pokemonTypeCombination.Item1;
        //    var secondType = pokemonTypeCombination.Item2;

        //    var container = _pokemonTypeContainerBuilder.SetFirstPokemonType(firstType)
        //        .SetSecondPokemonType(secondType)
        //        .Build();

        //    _pokemonTypeContainers.Add(pokemonTypeCombination, container);
        //    return container;
        //}

    }
}
