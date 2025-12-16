using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using GrapheneTraceApplication.Models;
using GrapheneTraceApplication.Data;

namespace GrapheneTraceApplication.Controllers
{
    [Authorize]
    public class PatientController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public PatientController(
            UserManager<ApplicationUser> userManager,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        // Patient Dashboard
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null || user.UserType != "Patient")
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        // GET: Upload CSV
        [HttpGet]
        public async Task<IActionResult> Upload()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null || user.UserType != "Patient")
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        // POST: Upload CSV
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upload(IFormFile csvFile)
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null || user.UserType != "Patient")
            {
                return RedirectToAction("Index", "Home");
            }

            // Basic validation
            if (csvFile == null || csvFile.Length == 0)
            {
                ModelState.AddModelError("", "Please select a CSV file.");
                return View();
            }

            if (!csvFile.FileName.EndsWith(".csv"))
            {
                ModelState.AddModelError("", "Only CSV files are allowed.");
                return View();
            }

            // CSV processing will be added in Step 7.3
            TempData["Message"] = "CSV uploaded successfully. Processing will be added next.";

            return RedirectToAction(nameof(Index));
        }
    }
}
