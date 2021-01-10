namespace RealEstate.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using RealEstate.Web.ViewModels.Estates;

    public interface IEstatesService
    {
        Task CreateEstateAsync(EstateCreateInputModel input);

        IEnumerable<T> Search<T>(int number);
    }
}
