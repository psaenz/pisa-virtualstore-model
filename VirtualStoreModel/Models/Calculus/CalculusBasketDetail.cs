namespace Pisa.VirtualStore.Models.Calculus
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Client;
    using Pisa.VirtualStore.Models.Base;

    public partial class CalculusBasketDetail : BaseModel
    {
        public int CalculusOrderId { get; set; }

        public int ClientBasketDetailId { get; set; }

        public int CalculusAppliedOfferId { get; set; }

        public int CountWithOffer { get; set; }

        public int CountWithoutOffer { get; set; }

        public double AmountWithOffer { get; set; }

        public double AmountWithoutOffer { get; set; }

        public bool ProvidedByStore { get; set; }

        public virtual CalculusOrder CalculusOrder { get; set; }

        public virtual ClientBasketDetail ClientBasketDetail { get; set; }

        public virtual CalculusAppliedOffer CalculusAppliedOffer { get; set; }
    }
}
