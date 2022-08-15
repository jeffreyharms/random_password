using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using RandomPassword.Models;

namespace RandomPassword.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public IActionResult Generate()
    {
        int? Count = HttpContext.Session.GetInt32("count");
        if(Count == null) 
        {
            HttpContext.Session.SetInt32("count", 1);
        }
        Password newPass = new Password();
        return View("Index", newPass);
    }
    [HttpPost("/increment")]
    public IActionResult AddOne()
    {
        int? totalPass = HttpContext.Session.GetInt32("count");
        if (totalPass == null)
        {
            totalPass = 1;
        }
        else
        {
            totalPass += 1;
        }

        HttpContext.Session.SetInt32("count", (int)totalPass);
        return RedirectToAction("Generate");
    }
}
