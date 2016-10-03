namespace Pisa.VirtualStore.Models.Archived
{
    using Pisa.VirtualStore.Models.Client;
    using Pisa.VirtualStore.Models.Base;

    public partial class ArchivedCalculusBasketDetail : BaseModel
    {
        public int CalculusOrderId { get; set; }

        public int ClientBasketDetailId { get; set; }

        public int CalculusAppliedOfferId { get; set; }

        public int CountWithOffer { get; set; }

        public int CountWithoutOffer { get; set; }

        public double AmountWithOffer { get; set; }

        public double AmountWithoutOffer { get; set; }

        public bool ProvidedByStore { get; set; }

        public virtual ArchivedCalculusOrder CalculusOrder { get; set; }

        public virtual ArchivedCalculusAppliedOffer CalculusAppliedOffer { get; set; }

        public virtual ClientBasketDetail ClientBasketDetail { get; set; }
    }
}
