using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ISPCRM.Models;
using System.Data;
using System.Configuration;

namespace ISPCRM.Controllers
{
    public class Log_adminController : Controller
    {
        public IActionResult Adminlogin()
        {
            return View();
        }

      //  [HttpPost]
      /*  public IActionResult login(Log_admin login)
        {
            String user = login.username;

            String pass = login.password;
            try { 
            if(user.Equals("admin") && pass.Equals("admin"))
                return RedirectToAction("Index","Home");
            
            else if(user.Equals("eadmin") && pass.Equals("eadmin"))
                return RedirectToAction("Index", "Home_emp");
            
            else if (user.Equals("cadmin") && pass.Equals("cadmin"))
                return RedirectToAction("Index", "Home_user");
            
            else
            {
                TempData["Message"] = "Username and Password did not match !!!";
                return RedirectToAction("Adminlogin", "Log_admin");
            }
            }catch(Exception ex)
            {
                TempData["Message"] = "Please Enter Correct Username and Password !!!";
                return RedirectToAction("Adminlogin", "Log_admin");
            }*/


        }
        

    }















/*   [HttpPost]
    public IActionResult login()
   {
       List<Log_admin> list1 = new List<Log_admin>();
       String mainconn = ConfigurationManager.ConnectionStrings["i_s_p"].ConnectionString;
       MySqlConnection sql = new MySqlConnection(mainconn);
       String query = "SELECT * FROM i_s_p_admin ";
       MySqlCommand cmd = new MySqlCommand(query);
       cmd.Connection = sql;
       sql.Open();
       MySqlDataReader dr = cmd.ExecuteReader();
       while (dr.Read())
       {
           list1.Add(new Log_admin
           {
               username = dr["username"].ToString(),
               password = dr["username"].ToString()
           }) ; 

       }
       sql.Close();

       return RedirectToAction("Index","Home");
   }*/
