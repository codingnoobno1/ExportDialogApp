using Microsoft.AspNetCore.Mvc;
using ExportDialogApp.Models;
using ExportDialogApp.ViewModels;

namespace ExportDialogApp.Controllers
{
    public class ExportController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new ExportViewModel
            {
                IncludeScopingDoc = true,
                IncludeAllDoc = false,
                ExportType = "selected",
                FileFormats = new[] { "PDF", "XLSX", "CSV" }
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Export(ExportModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Export logic here
            var fileName = model.IncludeTimestamp 
                ? $"Export_{DateTime.Now:yyyyMMdd_HHmmss}.{model.FileFormat.ToLower()}"
                : $"Export.{model.FileFormat.ToLower()}";

            return Json(new { success = true, fileName });
        }
    }
}