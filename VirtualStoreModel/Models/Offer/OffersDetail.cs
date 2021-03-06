namespace Pisa.VirtualStore.Models.Offer
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Product;
    using Pisa.VirtualStore.Models.Base;

    public partial class OffersDetail : BaseAuditableModel
    {
        public int IdOffer { get; set; }

        public int IdProduct { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public virtual Offer Offer { get; set; }

        public virtual Product Product { get; set; }
    }
}
