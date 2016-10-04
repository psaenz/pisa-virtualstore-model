namespace Pisa.VirtualStore.Models.Calculus
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Offer;
    using Pisa.VirtualStore.Models.Base;

    public partial class CalculusAppliedOffer : BaseModel
    {
        public int CalculusOrderId { get; set; }

        public int OfferId { get; set; }

        public int NumberApplied { get; set; }

        public virtual CalculusOrder CalculusOrder { get; set; }

        public virtual OfferInfo Offer { get; set; }
    }
}
