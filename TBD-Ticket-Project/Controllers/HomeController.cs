﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TBD_Ticket_Project.Models;
using System.Data.Entity;

namespace TBD_Ticket_Project.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var latestPosts = db.Posts.Include(p => p.Author)
                                      .OrderByDescending(p => p.Date)
                                      .Take(3); 
            return View(latestPosts);
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}