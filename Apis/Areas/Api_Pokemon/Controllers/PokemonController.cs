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
        public async Task<IActionResult> Index()
        {

            ApiData api = new ApiData();
            List<Pokemon> data = await api.miApi();

            return View(data);
        }
    }
}
