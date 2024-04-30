using Microsoft.AspNetCore.Mvc;

namespace EducationPlatform.API.Controllers
{
    public class ModuleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
