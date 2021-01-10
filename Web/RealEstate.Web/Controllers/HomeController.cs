namespace RealEstate.Web.Controllers
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;

    using Microsoft.AspNetCore.Mvc;
    using RealEstate.Web.ViewModels;
    using RealEstate.Web.ViewModels.Estates;

    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            // var vm = new EstateSearchViewModel();
            return this.View(/*vm*/);
        }

        [HttpPost]
        public IActionResult Index(EstateSearchViewModel vm)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(vm);
            }

            return this.RedirectToAction("FoundEstates", "Estates");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }

        public IActionResult Data()
        {
            var data = new DataAsClass() { };

            data.AllDirectories = Directory.EnumerateDirectories(data.CurrentDirectory.ToString());
            data.AllTxtFiles = Directory.EnumerateFiles(data.CurrentDirectory, ".txt", SearchOption.AllDirectories);

            return this.Json(data);
        }
    }

    internal class DataAsClass
    {
        public DataAsClass()
        {
            this.CurrentDirectory = Directory.GetCurrentDirectory();
        }

        public string CurrentDirectory { get; set; }

        public IEnumerable<string> AllDirectories { get; set; }

        public IEnumerable<string> AllTxtFiles { get; set; }
    }
}
