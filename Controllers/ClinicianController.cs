using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using GrapheneTraceApplication.Models;

namespace GrapheneTraceApplication.Controllers
{
    [Authorize]
    public class ClinicianController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public ClinicianController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null || user.UserType != "Clinician")
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}
