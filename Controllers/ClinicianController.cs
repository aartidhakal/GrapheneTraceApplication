using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GrapheneTraceApplication.Controllers
{
    [Authorize]                     // must be logged in
    public class ClinicianController : Controller
    {
        public IActionResult Index()
        {
            // later we’ll load clinician-specific data here
            return View();
        }
    }
}
