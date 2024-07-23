using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ISPCRM.Controllers
{
    public class NoticeController : Controller
    {
        public IActionResult Addnew_notice()
        {
            return View();
        }
        public IActionResult Ed_notice()
        {
            return View();
        }
        public IActionResult View_notice()
        {
            return View();
        }
    }
}