namespace RealEstate.Web.ViewModels.Estates
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using RealEstate.Data.Models;

    public class EstatesListViewModel
    {
        public IEnumerable<EstatesInListViewModel> Estates { get; set; }
    }
}
