using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoneySwapperrASP.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MoneySwapperrASP.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
