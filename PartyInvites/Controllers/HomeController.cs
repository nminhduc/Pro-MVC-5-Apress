﻿using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Morning" : "Afternoon";
            return View();
        }

        [HttpGet]
        public ViewResult RspvForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RspvForm(GuestResponse guestResponse)
        {
            return View("Thanks", guestResponse);
        }
    }
}