namespace RealEstate.Web.ViewModels.Estates
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using RealEstate.Web.ViewModels.EstateCategories;

    public class EstateCreateInputModel
    {
        public int Number { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int EstateCategoryId { get; set; }

        public int OwnerId { get; set; }

        public IEnumerable<EstateCategoriesSelectList> EstateCategories { get; set; }

        // public IEnumerable<EstateBuyersInputModel> Buyers { get; set; }

        // public IEnumerable<ImageInputModel> Images { get; set; }
    }
}
