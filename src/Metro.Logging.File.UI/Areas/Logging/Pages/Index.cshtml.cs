using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Metro.Logging.File.UI.Areas.Logging.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public DateTime StartDate { get; set; } = DateTime.Today.AddDays(-30);

        [BindProperty(SupportsGet = true)]
        public DateTime EndDate { get; set; } = DateTime.Today;

        public IEnumerable<int> LogItems { get; set; }

        public IActionResult OnGet()
        {
            //ViewData["scheme"] = HttpContext.Request.Scheme;
            //ViewData["host"] = HttpContext.Request.Host;
            //ViewData["path"] = HttpContext.Request.Path;
            //bool login = AuthHelper.Check(HttpContext);
            //if (!login) return RedirectToPage("Login");

            string logsPath = Path.Combine(AppContext.BaseDirectory, "logs");
            string[] files = Directory.GetFiles(logsPath);
            files = files.Select(s => Path.GetFileNameWithoutExtension(s)).ToArray();
            int startDate = StartDate.Year * 10000 + StartDate.Month * 100 + StartDate.Day;
            int endDate = EndDate.Year * 10000 + EndDate.Month * 100 + EndDate.Day;

            LogItems = files
                .Where(w => new Regex("^[0-9]{8}$").IsMatch(w))
                .Select(s => Convert.ToInt32(s))
                .Where(w => w >= startDate && w <= endDate)
                .OrderByDescending(o => o)
                .ToArray();

            return Page();
        }
    }
}