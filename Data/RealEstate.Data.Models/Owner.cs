namespace RealEstate.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using RealEstate.Data.Common.Models;

    public class Owner : BaseDeletableModel<int>
    {
        public Owner()
        {
            this.EstatesOwned = new HashSet<Estate>();
        }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public virtual ICollection<Estate> EstatesOwned { get; set; }
    }
}
