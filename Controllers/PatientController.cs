using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GrapheneTraceApplication.Controllers
{
    [Authorize]

    public class PatientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
