using PokemonStore.Models;

namespace PokemonStore.Data;

public class DataAccess
{
    private readonly ApplicationDbContext _appContext;

    public DataAccess(ApplicationDbContext appContext)
    {
        _appContext = appContext;
    }

    public async Task<List<Pokemon>> GetAllPokemon()
    {
        var result = _appContext.Pokemons.ToList();
        // Gör andra grejer medan vi hämtar för databaasen är långsam
        var returnList = result;
        return returnList;
    }

    public async Task AddPokemon(Pokemon pokemon)
    {
        await _appContext.Pokemons.AddAsync(pokemon);
        await _appContext.SaveChangesAsync();
    }

    public async Task<Pokemon?> GetPokemonById(int id)
    {
        var result = await _appContext.Pokemons.FindAsync(id);
        return result;
    }

    public async Task UpdatePokemon(Pokemon pokemon)
    {
        //Pokemon? dbPoke = await _appContext.Pokemons.FindAsync(pokemon.Id);
        //if (dbPoke == null)
        //    throw new Exception("This Pokemon does not exist");
        //else
        //{
        //    dbPoke.Name = pokemon.Name;
        //    dbPoke.Description = pokemon.Description;
        //    dbPoke.InStock = pokemon.InStock;
        //    dbPoke.ImgUrl = pokemon.ImgUrl;
        //    dbPoke.PriceSek = pokemon.PriceSek;
        //}

        _appContext.Pokemons.Update(pokemon);
        await _appContext.SaveChangesAsync();
    }
}
