using PokemonReview_API.Models;

namespace PokemonReview_API.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
    }
}
