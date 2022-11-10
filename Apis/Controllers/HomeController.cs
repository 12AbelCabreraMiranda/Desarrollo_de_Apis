using Apis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Apis.Controllers
{
    public class HomeController : Controller
    {

        public async Task<IActionResult> Index()
        {

            ApiData api = new ApiData();
            List<Pokemon> data = await api.miApi();

            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
