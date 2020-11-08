using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyraBilar.Models;
using Microsoft.AspNetCore.Mvc;

namespace HyraBilar.Controllers
{
    public class HyrabilarController : Controller
    {
        public IActionResult Index()
        {
            var Hyrabilar = DbContext.Hyrabilar;

            return View(Hyrabilar);
        }

        // GET: Rooms/Create
        public IActionResult Create()
        {
            return View();
        }
    }
}
