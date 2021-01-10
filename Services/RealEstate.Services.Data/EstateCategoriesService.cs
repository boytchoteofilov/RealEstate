namespace RealEstate.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using RealEstate.Data.Common.Repositories;
    using RealEstate.Data.Models;
    using RealEstate.Services.Mapping;
    using RealEstate.Web.ViewModels.EstateCategories;

    public class EstateCategoriesService : IEstateCategoriesService
    {
        private readonly IDeletableEntityRepository<EstateCategory> estateCategoryRepository;

        public EstateCategoriesService(IDeletableEntityRepository<EstateCategory> estateCategoryRepository)
        {
            this.estateCategoryRepository = estateCategoryRepository;
        }

        public IEnumerable<T> AllEstateCategoriesAsync<T>()
        {
            var query = this.estateCategoryRepository.AllAsNoTracking();

            var estateCategories = query.To<T>().ToList();

            return estateCategories;
        }

        public async Task CreateAsync(EstateCategoryCreateInputModel input)
        {
            var newCategory = new EstateCategory
            {
                Name = input.Name,
            };

            await this.estateCategoryRepository.AddAsync(newCategory);
            await this.estateCategoryRepository.SaveChangesAsync();
        }

        // public async Task CreateAsync<T>(T input)
        // {
        //    var newCategory = this.estateCategoryRepository.All().To<EstateCategory>(input).FirstOrDefault();

        // await this.estateCategoryRepository.AddAsync(newCategory);
        //    await this.estateCategoryRepository.SaveChangesAsync();
        // }
    }
}
