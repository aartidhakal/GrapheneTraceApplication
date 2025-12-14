using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using GrapheneTraceApplication.Models;

namespace GrapheneTraceApplication.Controllers
{
    [Authorize]
    public class PatientController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public PatientController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            // Load the logged-in user from DB
            var user = await _userManager.GetUserAsync(User);

            // Block access if not Patient
            if (user == null || user.UserType != "Patient")
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}
