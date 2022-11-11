using Apis.Areas.Api_RickandMorty.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apis.Areas.Api_RickandMorty.Controllers
{
    [Area("Api_RickandMorty")]
    public class RickandMortyController : Controller
    {
        public async Task<IActionResult> Index()
        {

            ApiData api = new ApiData();
            var data = await api.miApi();

            return View(data);
        }
    }
}
