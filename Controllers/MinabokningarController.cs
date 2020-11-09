using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyraBilar.Models;
using Microsoft.AspNetCore.Mvc;

namespace HyraBilar.Controllers
{
    public class MinabokningarController : Controller
    {

        //hämta alla bilar
        public IActionResult Index()
        {
            var bookings = DbContext.Hyrabilar;
            return View(bookings);
        }
    }
}
