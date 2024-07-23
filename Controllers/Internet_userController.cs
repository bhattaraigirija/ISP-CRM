using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ISPCRM.Controllers
{
    public class Internet_userController : Controller
    {
        public IActionResult Addnew_internet()
        {
            return View();
        }

        public IActionResult View_internet()
        {
            return View();
        }

        public IActionResult Ed_internet()
        {
            return View();
        }
    }
}