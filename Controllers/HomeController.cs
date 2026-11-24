using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExASP.NETMVC.Models;

namespace ExASP.NETMVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

}
