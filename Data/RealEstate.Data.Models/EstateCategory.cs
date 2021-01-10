namespace RealEstate.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using RealEstate.Data.Common.Models;

    public class EstateCategory : BaseDeletableModel<int>
    {
        public EstateCategory()
        {
            this.Estates = new HashSet<Estate>();
        }

        public string Name { get; set; }

        public virtual ICollection<Estate> Estates { get; set; }
    }
}
