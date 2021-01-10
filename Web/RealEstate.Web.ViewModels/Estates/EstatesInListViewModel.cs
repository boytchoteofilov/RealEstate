namespace RealEstate.Web.ViewModels.Estates
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using RealEstate.Data.Models;
    using RealEstate.Services.Mapping;

    public class EstatesInListViewModel : IMapFrom<Estate>
    {
        public int Number { get; set; }

        public string Title { get; set; }
    }
}
