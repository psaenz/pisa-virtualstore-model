namespace Pisa.VirtualStore.Models.Archived
{
    using Pisa.VirtualStore.Models.Client;
    using Pisa.VirtualStore.Models.Base;

    public partial class ArchivedCalculusBasketDetail : BaseModel
    {
        public int IdCalculusOrder { get; set; }

        public int IdBasketDetail { get; set; }

        public int? IdAppliedOffer { get; set; }

        public int CountWithOffer { get; set; }

        public int CountWithoutOffer { get; set; }

        public double AmountWithOffer { get; set; }

        public double AmountWithoutOffer { get; set; }

        public bool ProvidedByStore { get; set; }

        public virtual ArchivedCalculusOrder ArchivedCalculusOrder { get; set; }

        public virtual ArchivedCalculusAppliedOffer ArchivedCalculusAppliedOffer { get; set; }

        public virtual ClientBasketDetail ClientBasketDetail { get; set; }
    }
}
