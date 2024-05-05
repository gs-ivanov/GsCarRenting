namespace CarRentingSystem.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class CatsController : Controller
    {
        public IActionResult All()
        {
            return View();
        }
    }
}
