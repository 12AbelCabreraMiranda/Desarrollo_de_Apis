using Apis.Areas.Api_Pokemon.Data;
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
    public class PokemonRepository:Repository<Pokemon>,IPokemonRepository
    {
 
        //Inyeccion de dependencia
        private readonly IHttpClientFactory _httpClientFactory;
        public PokemonRepository(IHttpClientFactory httpClientFactory): base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

    }
}
