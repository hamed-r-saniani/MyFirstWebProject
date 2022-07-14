﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Model_ViewModel.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Model_ViewModel.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDatabaseContext _context;

        public HomeController(IDatabaseContext context)
        {
            _context = context;
        }
        

        Degree degree = new Degree();
        public IActionResult Index()
        {

            ViewBag.Degrees = new SelectList(degree.GetDegrees(), "DegreeID", "DegreeName");

            return View();
        }

        public IActionResult Register(Person model)
        {
            if (ModelState.IsValid)
            {
                if (model.Image != null)
                {
                    string ImageBase64 = "";
                    using (var ms = new MemoryStream())
                    {
                        model.Image.CopyTo(ms);
                        byte[] FileBytes = ms.ToArray();
                        ImageBase64 = Convert.ToBase64String(FileBytes);
                    }
                    ViewBag.Image = String.Format("data:image/png;base64,{0}", ImageBase64);
                }
                var person = new Person
                {
                    Age = model.Age,
                    BirthDate = model.BirthDate,
                    Email = model.Email,
                    Password = model.Password,
                    ConfirmPassword = model.ConfirmPassword,
                    Name = model.Name,
                    Family = model.Family,
                    UserName = model.UserName
                };
                _context.Person.Add(person);
                _context.SaveChangesAsync();
                
                return View(model);
            }
            else
            {
                ViewBag.Degrees = new SelectList(degree.GetDegrees(), "DegreeID", "DegreeName");
                return View("Index");
            }

        }
    }
}
