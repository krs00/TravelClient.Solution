using Microsoft.AspNetCore.Mvc;
using TravelClient.Models;

namespace TravelClient.Controllers;

public class CitiesController : Controller
{
  public IActionResult Index()
  {
    List<City> cities = City.GetCities();
    return View(cities);
  }
}