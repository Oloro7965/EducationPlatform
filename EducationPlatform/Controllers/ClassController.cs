using Microsoft.AspNetCore.Mvc;

namespace EducationPlatform.API.Controllers
{
    public class ClassController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
