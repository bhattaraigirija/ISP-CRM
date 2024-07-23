using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ISPCRM.Controllers
{
    public class Employee_empController : Controller
    {
        public IActionResult Addnew_employee()
        {
            return View();
        }
        public IActionResult Ed_employee()
        {
            return View();
        }
        public IActionResult View_employee()
        {
            return View();
        }
    }
}