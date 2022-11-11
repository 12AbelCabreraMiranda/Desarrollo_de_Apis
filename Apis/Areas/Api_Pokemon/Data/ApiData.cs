﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Apis
{
    public class ApiData
    {
        public async Task<List<Pokemon>> miApi()
        {
            List<Pokemon> lstPokemons = new List<Pokemon>();
            for(int i=1; i <= 15; i++)
            {
                var url = "https://pokeapi.co/api/v2/pokemon/"+i;
                //JsonSerializerOptions options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        Pokemon obj = new Pokemon();
                        var content = await response.Content.ReadAsStringAsync();

                        var objApi = JsonConvert.DeserializeObject<Principal>(content);
                        obj.Id = objApi.Id;
                        obj.Nombre = objApi.Name;
                        obj.Imagen = objApi.Sprites.Other.DreamWorld.FrontDefault;
                        obj.ColorCards = PintarBackground(objApi.Types[0].Type.Name);
                        lstPokemons.Add(obj);
                    }

                }
            }
            

            return lstPokemons;
            
        }


        public string PintarBackground(string _nombreColor)
        {
            List<BackgroundPokemon> myColor = new List<BackgroundPokemon>();
            myColor.Add(new BackgroundPokemon() { NombreColor = "fire", Color = "#FDDFDF" });
            myColor.Add(new BackgroundPokemon() { NombreColor = "grass", Color = "#DEFDE0" });
            myColor.Add(new BackgroundPokemon() { NombreColor = "electric", Color = "#FCF7DE" });
            myColor.Add(new BackgroundPokemon() { NombreColor = "water", Color = "#DEF3FD" });
            myColor.Add(new BackgroundPokemon() { NombreColor = "ground", Color = "#f4e7da" });
            myColor.Add(new BackgroundPokemon() { NombreColor = "rock", Color = "#d5d5d4" });
            myColor.Add(new BackgroundPokemon() { NombreColor = "fairy", Color = "#fceaff" });
            myColor.Add(new BackgroundPokemon() { NombreColor = "poison", Color = "#98d7a5" });
            myColor.Add(new BackgroundPokemon() { NombreColor = "bug", Color = "#f8d5a3" });
            myColor.Add(new BackgroundPokemon() { NombreColor = "dragon", Color = "#97b3e6" });
            myColor.Add(new BackgroundPokemon() { NombreColor = "psychic", Color = "#eaeda1" });
            myColor.Add(new BackgroundPokemon() { NombreColor = "flying", Color = "#F5F5F5" });
            myColor.Add(new BackgroundPokemon() { NombreColor = "fighting", Color = "#E6E0D4" });
            myColor.Add(new BackgroundPokemon() { NombreColor = "normal", Color = "#F5F5F5" });

            var findColor = (from l in myColor
                             where l.NombreColor==_nombreColor
                             select l.Color).FirstOrDefault();

            return findColor;
        }
    }

    public class Principal
    {
        [JsonProperty("abilities")]
        public List<Ability> Abilities { get; set; }

        [JsonProperty("base_experience")]
        public long BaseExperience { get; set; }

        [JsonProperty("forms")]
        public List<Species> Forms { get; set; }

        [JsonProperty("game_indices")]
        public List<GameIndex> GameIndices { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("held_items")]
        public List<HeldItem> HeldItems { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        [JsonProperty("location_area_encounters")]
        public Uri LocationAreaEncounters { get; set; }

        [JsonProperty("moves")]
        public List<Move> Moves { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order")]
        public long Order { get; set; }

        [JsonProperty("past_types")]
        public List<object> PastTypes { get; set; }

        [JsonProperty("species")]
        public Species Species { get; set; }

        [JsonProperty("sprites")]
        public Sprites Sprites { get; set; }

        [JsonProperty("stats")]
        public List<Stat> Stats { get; set; }

        [JsonProperty("types")]
        public List<TypeElement> Types { get; set; }

        [JsonProperty("weight")]
        public long Weight { get; set; }
    }

    public  class Ability
    {
        [JsonProperty("ability")]
        public Species AbilityAbility { get; set; }

        [JsonProperty("is_hidden")]
        public bool IsHidden { get; set; }

        [JsonProperty("slot")]
        public long Slot { get; set; }
    }

    public  class Species
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    public  class GameIndex
    {
        [JsonProperty("game_index")]
        public long GameIndexGameIndex { get; set; }

        [JsonProperty("version")]
        public Species Version { get; set; }
    }

    public  class HeldItem
    {
        [JsonProperty("item")]
        public Species Item { get; set; }

        [JsonProperty("version_details")]
        public List<VersionDetail> VersionDetails { get; set; }
    }

    public  class VersionDetail
    {
        [JsonProperty("rarity")]
        public long Rarity { get; set; }

        [JsonProperty("version")]
        public Species Version { get; set; }
    }

    public  class Move
    {
        [JsonProperty("move")]
        public Species MoveMove { get; set; }

        [JsonProperty("version_group_details")]
        public List<VersionGroupDetail> VersionGroupDetails { get; set; }
    }

    public  class VersionGroupDetail
    {
        [JsonProperty("level_learned_at")]
        public long LevelLearnedAt { get; set; }

        [JsonProperty("move_learn_method")]
        public Species MoveLearnMethod { get; set; }

        [JsonProperty("version_group")]
        public Species VersionGroup { get; set; }
    }

    public  class GenerationV
    {
        [JsonProperty("black-white")]
        public Sprites BlackWhite { get; set; }
    }

    public  class GenerationIv
    {
        [JsonProperty("diamond-pearl")]
        public Sprites DiamondPearl { get; set; }

        [JsonProperty("heartgold-soulsilver")]
        public Sprites HeartgoldSoulsilver { get; set; }

        [JsonProperty("platinum")]
        public Sprites Platinum { get; set; }
    }

    public  class Versions
    {
        [JsonProperty("generation-i")]
        public GenerationI GenerationI { get; set; }

        [JsonProperty("generation-ii")]
        public GenerationIi GenerationIi { get; set; }

        [JsonProperty("generation-iii")]
        public GenerationIii GenerationIii { get; set; }

        [JsonProperty("generation-iv")]
        public GenerationIv GenerationIv { get; set; }

        [JsonProperty("generation-v")]
        public GenerationV GenerationV { get; set; }

        [JsonProperty("generation-vi")]
        public Dictionary<string, Home> GenerationVi { get; set; }

        [JsonProperty("generation-vii")]
        public GenerationVii GenerationVii { get; set; }

        [JsonProperty("generation-viii")]
        public GenerationViii GenerationViii { get; set; }
    }

    public class Sprites
    {
        [JsonProperty("back_default")]
        public Uri BackDefault { get; set; }

        [JsonProperty("back_female")]
        public object BackFemale { get; set; }

        [JsonProperty("back_shiny")]
        public Uri BackShiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public object BackShinyFemale { get; set; }

        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public object FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public object FrontShinyFemale { get; set; }

        [JsonProperty("other")]
        public Other Other { get; set; }

        [JsonProperty("versions")]
        public Versions Versions { get; set; }

        [JsonProperty("animated")]
        public Sprites Animated { get; set; }
    }

    public  class GenerationI
    {
        [JsonProperty("red-blue")]
        public RedBlue RedBlue { get; set; }

        [JsonProperty("yellow")]
        public RedBlue Yellow { get; set; }
    }

    public  class RedBlue
    {
        [JsonProperty("back_default")]
        public Uri BackDefault { get; set; }

        [JsonProperty("back_gray")]
        public Uri BackGray { get; set; }

        [JsonProperty("back_transparent")]
        public Uri BackTransparent { get; set; }

        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_gray")]
        public Uri FrontGray { get; set; }

        [JsonProperty("front_transparent")]
        public Uri FrontTransparent { get; set; }
    }

    public  class GenerationIi
    {
        [JsonProperty("crystal")]
        public Crystal Crystal { get; set; }

        [JsonProperty("gold")]
        public Gold Gold { get; set; }

        [JsonProperty("silver")]
        public Gold Silver { get; set; }
    }

    public  class Crystal
    {
        [JsonProperty("back_default")]
        public Uri BackDefault { get; set; }

        [JsonProperty("back_shiny")]
        public Uri BackShiny { get; set; }

        [JsonProperty("back_shiny_transparent")]
        public Uri BackShinyTransparent { get; set; }

        [JsonProperty("back_transparent")]
        public Uri BackTransparent { get; set; }

        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonProperty("front_shiny_transparent")]
        public Uri FrontShinyTransparent { get; set; }

        [JsonProperty("front_transparent")]
        public Uri FrontTransparent { get; set; }
    }

    public  class Gold
    {
        [JsonProperty("back_default")]
        public Uri BackDefault { get; set; }

        [JsonProperty("back_shiny")]
        public Uri BackShiny { get; set; }

        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonProperty("front_transparent", NullValueHandling = NullValueHandling.Ignore)]
        public Uri FrontTransparent { get; set; }
    }

    public  class GenerationIii
    {
        [JsonProperty("emerald")]
        public Emerald Emerald { get; set; }

        [JsonProperty("firered-leafgreen")]
        public Gold FireredLeafgreen { get; set; }

        [JsonProperty("ruby-sapphire")]
        public Gold RubySapphire { get; set; }
    }

    public  class Emerald
    {
        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }
    }

    public  class Home
    {
        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public object FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public object FrontShinyFemale { get; set; }
    }

    public  class GenerationVii
    {
        [JsonProperty("icons")]
        public DreamWorld Icons { get; set; }

        [JsonProperty("ultra-sun-ultra-moon")]
        public Home UltraSunUltraMoon { get; set; }
    }

    public  class DreamWorld
    {
        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public string FrontFemale { get; set; }
    }

    public  class GenerationViii
    {
        [JsonProperty("icons")]
        public DreamWorld Icons { get; set; }
    }

    public  class Other
    {
        [JsonProperty("dream_world")]
        public DreamWorld DreamWorld { get; set; }

        [JsonProperty("home")]
        public Home Home { get; set; }

        [JsonProperty("official-artwork")]
        public OfficialArtwork OfficialArtwork { get; set; }
    }

    public  class OfficialArtwork
    {
        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }
    }

    public  class Stat
    {
        [JsonProperty("base_stat")]
        public long BaseStat { get; set; }

        [JsonProperty("effort")]
        public long Effort { get; set; }

        [JsonProperty("stat")]
        public Species StatStat { get; set; }
    }

    public  class TypeElement
    {
        [JsonProperty("slot")]
        public long Slot { get; set; }

        [JsonProperty("type")]
        public Species Type { get; set; }
    }


    public class Pokemon
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public Uri Imagen { get; set; }
        public string ColorCards { get; set; }
    }

    public class BackgroundPokemon
    {
        public string NombreColor { get; set; }
        public string Color { get; set; }
    }

}