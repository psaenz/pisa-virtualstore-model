namespace Pisa.VirtualStore.Models.Calculus
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Client;
    using Pisa.VirtualStore.Models.Base;

    public partial class CalculusBasketDetail : BaseModel
    {
        public int IdCalculusOrder { get; set; }

        public int IdBasketDetail { get; set; }

        public int IdAppliedOffer { get; set; }

        public int CountWithOffer { get; set; }

        public int CountWithoutOffer { get; set; }

        public double AmountWithOffer { get; set; }

        public double AmountWithoutOffer { get; set; }

        public bool ProvidedByStore { get; set; }

        public virtual ClientBasketDetail BasketDetail { get; set; }

        public virtual CalculusOrder CalculusOrder { get; set; }

        public virtual CalculusAppliedOffer CalculusAppliedOffer { get; set; }
    }
}
