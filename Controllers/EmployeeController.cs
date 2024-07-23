using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ISPCRM.Controllers
{
    public class EmployeeController : Controller
    {
        //EmployeeDAO edao = new EmployeeDAO();
        public IActionResult Addnew_employee()
        {
            return View();
        }
       
        public IActionResult Ed_employee()
        {
         //   var dt = edao.Select();
         //   ViewBag.data = dt;
            return View();
        }
        public IActionResult View_employee()
        {
          //  var dt = edao.Select();
           // ViewBag.data = dt;
            return View();
        }
        
        public IActionResult Delete(int S_No)
        {
            //edao.Delete(S_No);
            ViewBag.message=("Employee Deleted Successfully !");
            return Redirect("/Employee/Ed_employee");
        }


        public IActionResult Update_employee()
        {
            return View();
        }
    }
}