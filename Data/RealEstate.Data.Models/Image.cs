namespace RealEstate.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using RealEstate.Data.Common.Models;

    public class Image : BaseDeletableModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int EstateId { get; set; }

        public virtual Estate Estate { get; set; }

        public string Extention { get; set; }
    }
}
