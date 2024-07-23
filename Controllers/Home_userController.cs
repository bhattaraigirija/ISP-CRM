using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ISPCRM.Models;

namespace ISPCRM.Controllers
{
    public class Home_userController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
