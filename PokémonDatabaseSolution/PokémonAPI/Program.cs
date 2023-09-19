
using PokémonDomain;

namespace PokémonAPI
{
    class Program
    {

        public static async Task Main(string[] args)
        {

            //var client = new PokemonApiClient();
            //var pokemonApi = await client.GetPokemonWithId(1);
            //var pokemon = new PokemonApiWrapper(pokemonApi);

            //foreach (var stat in pokemon.GetBaseStatsByName())
            //{
            //    await Console.Out.WriteLineAsync($"Key: {stat.Key} Value: {stat.Value}");
            //}



            using (var context = new PokemonDbContext())
            {
                context.Database.EnsureCreated();
                var speciesList = context.Species.ToList();
                //foreach (var species in speciesList)
                //{
                //    Console.WriteLine($"ID: {species.PokedexID}, Name: {species.SpeciesName}");
                //}

                Console.WriteLine("Here");
            }

            //var containerBuilder = new PokemonTypeContainerBuilder();
            //var factory = new PokemonTypeContainerFactory(containerBuilder);


            //var key = (PokemonType.Bug, PokemonType.Electric);

            //factory.GetPokemonTypeContainer(key);

            //var fac = new PokemonFactory();
            //var value = fac.CreateFromPokeApiNet(1);


            //var builder = WebApplication.CreateBuilder(args);

            //builder.Services.AddControllers();
            //builder.Services.AddEndpointsApiExplorer();
            //builder.Services.AddSwaggerGen();

            //PokeAPI.Pokemon pokemon = new PokeAPI.Pokemon();


            //var app = builder.Build();

            //if (app.Environment.IsDevelopment())
            //{
            //    app.UseSwagger();
            //    app.UseSwaggerUI();
            //}

            //app.UseHttpsRedirection();

            //app.UseAuthorization();

            //app.MapControllers();

            //app.Run();

            Console.ReadKey();

        }
    }
}

