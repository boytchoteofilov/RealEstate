namespace RealEstate.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using RealEstate.Data;
    using RealEstate.Data.Models;
    using RealEstate.Services.Data;
    using RealEstate.Web.ViewModels.EstateCategories;
    using RealEstate.Web.ViewModels.Estates;

    public class EstatesController : Controller
    {
        private readonly IEstatesService estatesService;
        private readonly IEstateCategoriesService estateCategoriesService;

        public EstatesController(
            IEstatesService estatesService,
            IEstateCategoriesService estateCategoriesService)
        {
            this.estatesService = estatesService;
            this.estateCategoriesService = estateCategoriesService;
        }

        public IActionResult Create()
        {
            var estateCategories = this.estateCategoriesService.AllEstateCategoriesAsync<EstateCategoriesSelectList>();
            var viewModel = new EstateCreateInputModel()
            {
                EstateCategories = estateCategories,
            };
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(EstateCreateInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.estatesService.CreateEstateAsync(input);

            return this.Redirect("/");
        }

        public IActionResult FoundEstates()
        {
            var vm = new EstateSearchViewModel();

            return this.View(vm);
        }

        [HttpPost]
        public IActionResult FoundEstates(EstateSearchViewModel data)
        {
            var vm = new EstatesListViewModel()
            {
                Estates = this.estatesService.Search<EstatesInListViewModel>(data.Number),
            };

            return this.View(vm);
        }
    }
}
