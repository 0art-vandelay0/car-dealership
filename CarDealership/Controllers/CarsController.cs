using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
    public class CarsController : Controller
    {
        [HttpGet("/cars")]
        public ActionResult Index()
        {
            List<Car> allCars = Car.GetAll();
            return View(allCars);
        }

        [HttpGet("/cars/new")]
        public ActionResult CarForm()
        {
            return View();
        }

        [HttpPost("/cars")]
        public ActionResult Create(string make, string model, string year)
        {
            Car newCar = new Car(make, model, year);
            return RedirectToAction("Index");
        }
    }
}