using Microsoft.AspNetCore.Mvc;

namespace EducationPlatform.API.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
