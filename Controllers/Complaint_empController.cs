using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ISPCRM.Controllers
{
    public class Complaint_empController : Controller
    {
        public IActionResult Addnew_complaint()
        {
            return View();
        }
        public IActionResult Ed_complaint()
        {
            return View();
        }
        public IActionResult View_complaint()
        {
            return View();
        }
    }
}