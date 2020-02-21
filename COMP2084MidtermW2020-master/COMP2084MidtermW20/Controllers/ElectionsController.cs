using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace COMP2084MidtermW20.Controllers
{
    public class ElectionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}