using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ZZalStorage.Controllers
{
    public class MainController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}