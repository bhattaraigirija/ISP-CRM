using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ISPCRM.Controllers
{
    public class Pie_empController : Controller
    {
        public IActionResult ComplainReport()
        {
            return View ();
        }
        public IActionResult View_All_Report()
        {
            return View();
        }
    }
}