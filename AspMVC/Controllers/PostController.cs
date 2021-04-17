using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspMVC.Controllers
{
    

    public class PostController : Controller
    {

        public ViewResult Login()
        {
            return View("userLogin");
        }

        public ViewResult About()
        {
            return View();
        }


        public ViewResult Profile()
        {
            return View();
        }

        public ViewResult userValidate(User u)
        {
            if (true)
            {                
                return View("Index1");
            }
            else
            {
                ModelState.AddModelError(String.Empty, "Please enter correct data");
                return View();
            }
        }

    }
}
