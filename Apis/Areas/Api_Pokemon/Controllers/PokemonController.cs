using Apis.Areas.Api_Pokemon.Data;
using Apis.Areas.Api_Pokemon.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apis.Areas.Api_Pokemon.Controllers
{
    [Area("Api_Pokemon")]
    public class PokemonController : Controller
    {
        public async Task<IActionResult> Index(int Pagina = 1)
        {
            var cantidadRegistrosPorPagina = 20;

            ApiData api = new ApiData();
            var datosPokemons =await api.MiApi(Pagina*20);

            var pokemons = datosPokemons.OrderBy(x => x.Id)
                                        //.Skip((Pagina - 1) * cantidadRegistrosPorPagina)
                                        .Take(cantidadRegistrosPorPagina).ToList();
            //var totalDeRegistros = datosPokemons.Count();
            var totalDeRegistros = 1154;

            var lstModels = new PokemonViewModels()
            {
               Pokemon= pokemons,
               PaginaActual=Pagina,
               TotalDeRegistros= totalDeRegistros,
               RegistrosPorPagina=cantidadRegistrosPorPagina
            };


            return View(lstModels);
        }
        
        public async Task<IActionResult> MiPokemon(int id)
        {
            ApiData api = new ApiData();
            var miPokemon = await api.ObtenerUnPokemon(id);

            return View(miPokemon);
        }
    }
}
