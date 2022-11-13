using Apis.Areas.Api_Pokemon.Data;
using Apis.Areas.Api_Pokemon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apis.Areas.Api_Pokemon.ViewModels
{
    public class PokemonViewModels: BasePaginador
    {
        public List<Pokemon> Pokemon { get; set; }     
    }
}
