using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using APPDEV.Models;

namespace APPDEV.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Member3()
    {
        MemberModel3.SamanthaModel member = new MemberModel3.SamanthaModel();

        member.FullName = "Samantha Nicole D. Angeles";
        member.Age = 19;
        member.Birthday = "September 09, 2007";

        return View(member);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    } 


}
