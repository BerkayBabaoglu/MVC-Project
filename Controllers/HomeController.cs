using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StajMVC.Models;

namespace StajMVC.Controllers
{
    public class HomeController : Controller
    {
        private SchoolContext db = new SchoolContext();

        public ActionResult Index() //listeleme
        {
            var students = db.Students.ToList();
            return View(students); 
        }

        public ActionResult Create() //yeni ekleme (get)
        {
            return View();
        }

        [HttpPost] //yeni ekleme post
        public ActionResult Create(Students student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

    }
}