namespace Pisa.VirtualStore.Models.Calculus
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Offer;
    using Pisa.VirtualStore.Models.Base;

    public partial class CalculusAppliedOffer : BaseModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CalculusAppliedOffer()
        {
            CalculusBasketDetails = new HashSet<CalculusBasketDetail>();
        }

        public int IdCalculusOrder { get; set; }

        public int IdOffer { get; set; }

        public int NumberApplied { get; set; }

        public virtual CalculusOrder CalculusOrder { get; set; }

        public virtual Offer Offer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalculusBasketDetail> CalculusBasketDetails { get; set; }
    }
}
