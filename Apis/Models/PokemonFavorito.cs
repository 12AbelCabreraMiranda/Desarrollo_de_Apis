using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apis.Models
{
    public class PokemonFavorito
    {

        [JsonProperty("pokemonId")]
        public long PokemonId { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("imagen")]
        public string Imagen { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("estado")]
        public long Estado { get; set; }

        [JsonProperty("usuarioCrea")]
        public string UsuarioCrea { get; set; }

        [JsonProperty("fechaCreacion")]
        public DateTimeOffset FechaCreacion { get; set; }
    }
}
