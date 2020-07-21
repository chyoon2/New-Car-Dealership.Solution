using Microsoft.AspNetCore.Mvc;
using CarDealer.Models;
using System.Collections.Generic;

namespace CarDealer.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/addcarform")]
    public ActionResult AddCarForm()
    {
      return View();
    }

    [HttpPost("/addcarform")]
    public ActionResult AddCarForm(string makeModel, string miles, string price)
    {
      int milesInput = int.Parse(miles);
      int priceInput = int.Parse(price);
      Car myCar = new Car(makeModel, priceInput, milesInput);
      return RedirectToAction("Index");
    }
  }
}