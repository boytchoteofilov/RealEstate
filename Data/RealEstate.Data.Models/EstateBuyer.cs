namespace RealEstate.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class EstateBuyer
    {
        public int Id { get; set; }

        public int EstateId { get; set; }

        public virtual Estate Estate { get; set; }

        public int BuyerId { get; set; }

        public virtual Buyer Buyer { get; set; }
    }
}
