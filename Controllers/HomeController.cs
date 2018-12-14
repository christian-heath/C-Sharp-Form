using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using form.Models;

namespace form.Controllers
{
    public class HomeController : Controller
    {
        // Requests
        [HttpGet("")]
        public IActionResult index()
        {
            return View();
        }

        [HttpPost("result")]
        public IActionResult result(User user)
        {
            if(ModelState.IsValid)
            {
                return View(user);
            }
            else{
                return View("index");
            }
        }
    }
}