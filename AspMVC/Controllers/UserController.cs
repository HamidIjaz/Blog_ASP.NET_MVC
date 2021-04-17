using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
namespace Blog.Controllers
{

    public class UserController : Controller
    {

        public ViewResult Remove(int id)
        {
            User s = UserRepository.users.Find(s => s.Id == id);
            UserRepository.users.Remove(s);
            return View("ListUsers", UserRepository.users);
        }

        public ViewResult Details(int id)
        {
            User s = UserRepository.users.Find(s => s.Id == id);
            return View("Thanks", s);
        }

        public ViewResult Edit(int id)
        {
            User s = UserRepository.users.Find(s => s.Id == id);
            return View("Edit", s);

        }
        [HttpPost]
        public ViewResult Edit(User s)
        {
            if (ModelState.IsValid)
            {
                foreach (User std in UserRepository.users)
                {
                    if (std.Id == s.Id)
                    {
                        std.Name = s.Name;
                        
                        std.Age = s.Age;
                        
                        break;
                    }
                }

                return View("ListUsers", UserRepository.users);
            }
            else
            {
                ModelState.AddModelError(String.Empty, "Please enter correct data");
                return View();
            }

        }

        public ViewResult Index()
        {
            return View("Index");
        }

        public ViewResult Login()
        {
            return View("adminLogin");
        }

        [HttpGet]
        public ViewResult UserForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AdminValidate(Admin s)
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

        [HttpPost]
        public ViewResult UserForm(User s)
        {

            if (true)
            {
                UserRepository.AddStudent(s);
                return View("Thanks", s);
            }
            else
            {
                ModelState.AddModelError(String.Empty, "Please enter correct data");
                return View();
            }
        }

        public ViewResult ListUsers()
        {
            return View(UserRepository.users);
        }
    }
}