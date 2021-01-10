namespace RealEstate.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using RealEstate.Web.ViewModels.EstateCategories;

    public interface IEstateCategoriesService
    {
        IEnumerable<T> AllEstateCategoriesAsync<T>();

        Task CreateAsync(EstateCategoryCreateInputModel input);

        // TODO: make the method generic
        // Task CreateAsync<T>(T input);
    }
}
