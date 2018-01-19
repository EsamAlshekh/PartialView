using PartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            //PerCar perCar = new PerCar();
            //perCar.SeedLists();
            return View(/*perCar*/);
        }

        public ActionResult PartIndex()
        {

            //PerCar perCar = new PerCar();
            //perCar.SeedLists();
            return View(/*perCar*/);
        }

        public PartialViewResult PartCar(int id)
        {
            //PerCar perCar = new PerCar();
            //perCar.SeedLists();

            Car temp=PerCar.Cars.SingleOrDefault(c => c.Id == id);
            return PartialView("_Car",temp);
            
        }
    }
}