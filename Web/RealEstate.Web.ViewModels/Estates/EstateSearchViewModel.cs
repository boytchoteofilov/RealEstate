namespace RealEstate.Web.ViewModels.Estates
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class EstateSearchViewModel
    {
        public int Number { get; set; }

        public string Location { get; set; }

        public string Status { get; set; }

        public string Type { get; set; }

        public string Area { get; set; }

        public int Bedrooms { get; set; }

        public int Baths { get; set; }
    }
}
