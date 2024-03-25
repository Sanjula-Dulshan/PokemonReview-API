using Microsoft.AspNetCore.Mvc;
using PokemonReview_API.Data;
using PokemonReview_API.Interfaces;
using PokemonReview_API.Models;

namespace PokemonReview_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController:Controller
    {
        private readonly IPokemonRepository _pokemonRepository;
        public PokemonController(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
        public IActionResult GetPokemens()
        {
            var pokemens = _pokemonRepository.GetPokemons();

            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(pokemens);
        }
    }
}
