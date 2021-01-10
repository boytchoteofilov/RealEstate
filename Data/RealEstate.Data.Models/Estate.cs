namespace RealEstate.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using RealEstate.Data.Common.Models;

    public class Estate : BaseDeletableModel<int>
    {
        public Estate()
        {
            this.Buyers = new HashSet<EstateBuyer>();
        }

        public int Number { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public ApplicationUser AddedByUserId { get; set; }

        public ApplicationUser AddedByUser { get; set; }

        public int EstateCategoryId { get; set; }

        public virtual EstateCategory EstateCategory { get; set; }

        public int OwnerId { get; set; }

        public virtual Owner Owner { get; set; }

        public virtual ICollection<EstateBuyer> Buyers { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}
