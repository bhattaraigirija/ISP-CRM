using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ISPCRM.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult MessageView()
        {
            return View();
        }
    }
}