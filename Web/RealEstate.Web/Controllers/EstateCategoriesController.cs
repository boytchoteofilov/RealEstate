namespace RealEstate.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using RealEstate.Services.Data;
    using RealEstate.Web.ViewModels.EstateCategories;

    public class EstateCategoriesController : Controller
    {
        private readonly IEstateCategoriesService estateCategoriesService;

        public EstateCategoriesController(IEstateCategoriesService estateCategoriesService)
        {
            this.estateCategoriesService = estateCategoriesService;
        }

        public IActionResult All()
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(EstateCategoryCreateInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.estateCategoriesService.CreateAsync(input);

            return this.Redirect("/");
        }

        // public async Task<IActionResult> Create(EstateCategoryCreateInputModel input)
        // {
        //    if (!this.ModelState.IsValid)
        //    {
        //        return this.View(input);
        //    }

        // await this.estateCategoriesService.CreateAsync<EstateCategoryCreateInputModel>(input);

        // return this.Redirect("/");
        // }
    }
}
