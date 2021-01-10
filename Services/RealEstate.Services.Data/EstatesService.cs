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
    using RealEstate.Web.ViewModels.Estates;

    public class EstatesService : IEstatesService
    {
        private readonly IDeletableEntityRepository<Estate> estatesRepository;

        public EstatesService(IDeletableEntityRepository<Estate> estatesRepository)
        {
            this.estatesRepository = estatesRepository;
        }

        public async Task CreateEstateAsync(EstateCreateInputModel input)
        {
            var estate = new Estate()
            {
                Number = input.Number,
                Title = input.Title,
                Description = input.Description,
                EstateCategoryId = input.EstateCategoryId,
                OwnerId = input.OwnerId,
            };

            await this.estatesRepository.AddAsync(estate);
            await this.estatesRepository.SaveChangesAsync();
        }

        public IEnumerable<T> Search<T>(int number)
        {
           return this.estatesRepository.All().Where(x => x.Number == number).To<T>().ToList();
        }
    }
}
