﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //string myData = "This is my dummy data";
            return View("Index");
        }


    }
}