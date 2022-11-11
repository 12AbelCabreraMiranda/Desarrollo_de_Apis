using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Apis.Areas.Api_RickandMorty.Data
{
    public class ApiData
    {
        public async Task<Principal> miApi()
        {
            var url = "https://rickandmortyapi.com/api/character";
            JsonSerializerOptions options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
            Principal objApi = new Principal();


            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    objApi = System.Text.Json.JsonSerializer.Deserialize<Principal>(content,options);

                }
                
            }

            return objApi;
            
        }
    }

    public class Principal
    {
        [JsonProperty("info")]
        public Info Info { get; set; }

        [JsonProperty("results")]
        public List<Result> Results { get; set; }
    }

    public class Info
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("pages")]
        public long Pages { get; set; }

        [JsonProperty("next")]
        public Uri Next { get; set; }

        [JsonProperty("prev")]
        public object Prev { get; set; }
    }

    public class Result
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("species")]
        public string Species { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("origin")]
        public Location Origin { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("image")]
        public Uri Image { get; set; }

        [JsonProperty("episode")]
        public List<Uri> Episode { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("created")]
        public DateTimeOffset Created { get; set; }
    }

    public class Location
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
    
}
