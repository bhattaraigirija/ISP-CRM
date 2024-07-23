using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ISPCRM.Controllers
{
    public class Customer_empController : Controller
    {
        public IActionResult Addnew_customer()
        {
            return View();
        }
        public IActionResult Ed_customer()
        {
            return View();
        }
        public IActionResult View_customer()
        {
            return View();
        }
    }
}