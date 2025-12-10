using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GrapheneTraceApplication.Controllers
{
    [Authorize]                     // must be logged in
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            // later we’ll add admin tools here
            return View();
        }
    }
}
