using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ISPCRM.Models;
namespace ISPCRM.Controllers
{
    [Route("i_s_p_customer")]

    public class CustomerController : Controller
    {
        private DataContext db = new DataContext();
        // CustomerDTO cdto = new CustomerDTO();
        //  CustomerDAO cdao = new CustomerDAO();
        DataContext dal = new DataContext();

        [HttpPost]
        public IActionResult Addnew_customer(Customer customer)
        {
            dal.customers.Add(customer);
            ViewBag.message = "Successfully Inserted";           
            return View();
        }


        public IActionResult Ed_customer()
        {
            return View();
        }
    /*    public IActionResult Delete(int S_No)
        {
            cdao.Delete(S_No);
            return Redirect("/Customer/Ed_customer");
        } */
        public IActionResult View_customer()
        {
            return View();
        }
 
    }
}