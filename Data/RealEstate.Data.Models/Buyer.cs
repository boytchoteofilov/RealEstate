namespace RealEstate.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using RealEstate.Data.Common.Models;

    public class Buyer : BaseDeletableModel<int>
    {
        public Buyer()
        {
            this.EstatesViewed = new HashSet<EstateBuyer>();
        }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Phone { get; set; }

        public virtual ICollection<EstateBuyer> EstatesViewed { get; set; }
    }
}
