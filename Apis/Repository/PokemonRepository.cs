using Apis.Areas.Api_Pokemon.Data;
using Apis.Models;
using Apis.Repository.IRepository;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Apis.Repository
{
    public class PokemonRepository : IPokemonRepository
    {

        //Inyeccion de dependencia
        private readonly IHttpClientFactory _httpClientFactory;
        public PokemonRepository(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable> ObtenerTodoAsync(string url)
        {
            var peticion = new HttpRequestMessage(HttpMethod.Get, url);

            var cliente = _httpClientFactory.CreateClient();
            HttpResponseMessage respuesta = await cliente.SendAsync(peticion);

            //return
            if (respuesta.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonString = await respuesta.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<IEnumerable<PokemonFavorito>>(jsonString);
            }
            else
            {
                return null;
            }
        }

        public async Task<PokemonFavorito> ObtenerAsync(string url, int PokemonId)
        {
            var peticion = new HttpRequestMessage(HttpMethod.Get, url + PokemonId);

            var cliente = _httpClientFactory.CreateClient();
            HttpResponseMessage respuesta = await cliente.SendAsync(peticion);

            //return
            if (respuesta.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonString = await respuesta.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<PokemonFavorito>(jsonString);
            }
            else
            {
                return null;
            }
        }

        public async Task<bool> CrearAsync(string url, PokemonFavorito model)
        {
            var peticion = new HttpRequestMessage(HttpMethod.Post, url);
            if (model != null)
            {
                peticion.Content = new StringContent(
                    JsonConvert.SerializeObject(model),
                    Encoding.UTF8, "application/json"
                    );
            }
            else
            {
                return false;
            }

            var cliente = _httpClientFactory.CreateClient();
            HttpResponseMessage respuesta = await cliente.SendAsync(peticion);

            //return
            if (respuesta.StatusCode == System.Net.HttpStatusCode.Created)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> ActualizarAsync(string url, PokemonFavorito model)
        {
            var peticion = new HttpRequestMessage(HttpMethod.Patch, url);
            if (model != null)
            {
                peticion.Content = new StringContent(
                    JsonConvert.SerializeObject(model),
                    Encoding.UTF8, "application/json"
                    );
            }
            else
            {
                return false;
            }

            var cliente = _httpClientFactory.CreateClient();
            HttpResponseMessage respuesta = await cliente.SendAsync(peticion);

            //return
            if (respuesta.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public async Task<bool> EliminarAsync(string url, int PokemonId)
        {
            var peticion = new HttpRequestMessage(HttpMethod.Delete, url + PokemonId);

            var cliente = _httpClientFactory.CreateClient();
            HttpResponseMessage respuesta = await cliente.SendAsync(peticion);

            //return
            if (respuesta.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
