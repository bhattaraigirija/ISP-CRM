using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace ISPCRM.Controllers
{
    public class InternetController : Controller
    {
      //  InternetDAO dao = new InternetDAO();
        public IActionResult Addnew_internet()
        {
            return View();
        }

     

        public IActionResult View_internet()
        {
          // var dt= dao.Select();
            //ViewBag.data = dt;
            return View();
        }

       
        public IActionResult Ed_internet(int S_No)
        {
         //   var dt = dao.Select();
         //   ViewBag.data = dt;           
           return View();
        }
        public IActionResult Delete(int S_No)
        {            
          //  dao.Delete(S_No);
            ViewBag.message = "Internet Plan Deleted Successfully !";
            return Redirect("/Internet/Ed_internet");
        }
        public IActionResult Update_internet()
        {
         //   var dt = dao.Select();
         //   ViewBag.data = dt;
            return View();
        }

      
    }
}