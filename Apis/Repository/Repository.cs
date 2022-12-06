using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Apis.Repository.IRepository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        //Inyeccion de dependencia
        private readonly IHttpClientFactory _httpClientFactory;
        public Repository(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<bool> ActualizarAsync(string url, T itemActualizar)
        {
            var peticion = new HttpRequestMessage(HttpMethod.Patch, url);
            if (itemActualizar != null)
            {
                peticion.Content = new StringContent(
                    JsonConvert.SerializeObject(itemActualizar),
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

        public async Task<bool> CrearAsync(string url, T itemCrear)
        {
            var peticion = new HttpRequestMessage(HttpMethod.Post, url);
            if (itemCrear != null)
            {
                peticion.Content = new StringContent(
                    JsonConvert.SerializeObject(itemCrear),
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

        public async Task<bool> EliminarAsync(string url, int Id)
        {
            var peticion = new HttpRequestMessage(HttpMethod.Delete, url + Id);

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

        public async Task<IEnumerable> GetAllAsync(string url)
        {
            var peticion = new HttpRequestMessage(HttpMethod.Get, url);

            var cliente = _httpClientFactory.CreateClient();
            HttpResponseMessage respuesta = await cliente.SendAsync(peticion);

            //return
            if (respuesta.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonString = await respuesta.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<IEnumerable<T>>(jsonString);
            }
            else
            {
                return null;
            }
        }

        public async Task<T> GetAsync(string url, int Id)
        {
            var peticion = new HttpRequestMessage(HttpMethod.Get, url + Id);

            var cliente = _httpClientFactory.CreateClient();
            HttpResponseMessage respuesta = await cliente.SendAsync(peticion);

            //return
            if (respuesta.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonString = await respuesta.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<T>(jsonString);
            }
            else
            {
                return null;
            }
        }
    }
}
