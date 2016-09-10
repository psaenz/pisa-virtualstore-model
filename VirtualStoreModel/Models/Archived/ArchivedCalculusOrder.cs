namespace Pisa.VirtualStore.Models.Archived
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Order;
    using Pisa.VirtualStore.Models.Store;
    using Pisa.VirtualStore.Models.Base;

    public partial class ArchivedCalculusOrder : BaseModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ArchivedCalculusOrder()
        {
            ArchivedCalculusBasketDetails = new HashSet<ArchivedCalculusBasketDetail>();
            ArchivedCalculusFreeProducts = new HashSet<ArchivedCalculusFreeProduct>();
            ArchivedCalculusAppliedOffers = new HashSet<ArchivedCalculusAppliedOffer>();
            ArchivedCalculusServicesCosts = new HashSet<ArchivedCalculusServiceCost>();
        }

        public int IdOrder { get; set; }

        public int IdStore { get; set; }

        public DateTime CalculusDate { get; set; }

        public virtual Store Store { get; set; }

        public virtual Order Order { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArchivedCalculusBasketDetail> ArchivedCalculusBasketDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArchivedCalculusFreeProduct> ArchivedCalculusFreeProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArchivedCalculusAppliedOffer> ArchivedCalculusAppliedOffers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArchivedCalculusServiceCost> ArchivedCalculusServicesCosts { get; set; }
    }
}
