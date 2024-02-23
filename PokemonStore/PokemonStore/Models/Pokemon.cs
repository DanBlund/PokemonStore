namespace PokemonStore.Models;

public class Pokemon
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int InStock { get; set; }
    public string ImgUrl { get; set; }
    public int PriceSek { get; set; }

}
