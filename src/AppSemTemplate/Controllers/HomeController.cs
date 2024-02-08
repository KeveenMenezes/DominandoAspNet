using Microsoft.AspNetCore.Mvc;

namespace AppSemTemplate;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
