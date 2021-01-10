namespace RealEstate.Web.ViewModels.EstateCategories
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using RealEstate.Data.Models;
    using RealEstate.Services.Mapping;

    public class EstateCategoryCreateInputModel : IMapTo<EstateCategory>
    {
        public string Name { get; set; }
    }
}
