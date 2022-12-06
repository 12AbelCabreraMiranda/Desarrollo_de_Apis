using Apis.Models;
using Apis.Repository.IRepository;
using Apis.Utilidades;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Apis.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPokemonRepository _pokemonRepository;

        public HomeController(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var resultado = await _pokemonRepository.GetAllAsync(Helper.RutaPokemon);           

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearPokemon(PokemonFavorito pokemonFavorito)
        {
            var resultado = await _pokemonRepository.CrearAsync(Helper.RutaPokemon, pokemonFavorito);

            return View();
        }

        [HttpGet]        
        public async Task<IActionResult> EditarPokemon(int? PokemonId)
        {
            PokemonFavorito pokemonFavorito = new PokemonFavorito();

            if (PokemonId == null)
            {
                return NotFound();
            }
            pokemonFavorito = await _pokemonRepository.GetAsync(Helper.RutaPokemon, PokemonId.GetValueOrDefault());

            if (pokemonFavorito == null)
            {
                return NotFound();
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditarPokemon(PokemonFavorito pokemonFavorito)
        {
            var resultado = await _pokemonRepository.ActualizarAsync(Helper.RutaPokemon+pokemonFavorito.PokemonId, pokemonFavorito);

            return View();
        }

        [HttpDelete]       
        public async Task<IActionResult> EliminarPokemon(int PokemonId)
        {
            var resultado = await _pokemonRepository.EliminarAsync(Helper.RutaPokemon, PokemonId);
            if (resultado)
            {
                return Json(new { success = true, message = "Pokemon eliminado" });
            }

            return Json(new { success = false, message = "Pokemon no eliminado" });
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
   
}
