using Apis.Areas.Api_Pokemon.Data;
using Apis.Areas.Api_Pokemon.ViewModels;
using Apis.Models;
using Apis.Repository.IRepository;
using Apis.Utilidades;
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
        private readonly IPokemonRepository _pokemonRepository;

        public PokemonController(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }
        public async Task<IActionResult> Index(int Pagina = 1)
        {
            var cantidadRegistrosPorPagina = 20;

            ApiData api = new ApiData(_pokemonRepository);
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
        
        public async Task<IActionResult> Pokemon(int Id)
        {
            ApiData api = new ApiData(_pokemonRepository);
            var miPokemon = await api.ObtenerUnPokemon(Id);

            return View(miPokemon);
        }

        [HttpPost]        
        public async Task<int> AgregarAFavorito(int Id)
        {
            
            PokemonFavorito modelPokemon = new PokemonFavorito
            {               
                PokemonId =Id,      
                Estado = 1,    
                UsuarioCrea = "Abel",
                FechaCreacion = DateTime.Now
            };

            var respuesta = await _pokemonRepository.CrearAsync(Helper.RutaPokemon, modelPokemon);
            int Resultado= respuesta == true ? 1 : 0;

            return Resultado;
        }

        [HttpPost]
        public async Task<int> DeletePokemon(int Id)
        {
            var respuesta = await _pokemonRepository.EliminarAsync(Helper.RutaPokemon, Id);
            int Resultado = respuesta == true ? 1 : 0;

            return Resultado;
        }


    }
}
