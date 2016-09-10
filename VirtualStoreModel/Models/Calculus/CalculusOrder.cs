namespace Pisa.VirtualStore.Models.Calculus
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Store;
    using Pisa.VirtualStore.Models.Order;
    using Pisa.VirtualStore.Models.Base;

    public partial class CalculusOrder : BaseModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CalculusOrder()
        {
            CalculusBasketDetails = new HashSet<CalculusBasketDetail>();
            CalculusFreeProducts = new HashSet<CalculusFreeProduct>();
            CalculusAppliedOffers = new HashSet<CalculusAppliedOffer>();
            CalculusServicesCosts = new HashSet<CalculusServiceCost>();
        }

        public int IdOrder { get; set; }

        public int IdStore { get; set; }

        public DateTime CalculusDate { get; set; }

        public virtual Store Store { get; set; }

        public virtual Order Order { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalculusBasketDetail> CalculusBasketDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalculusFreeProduct> CalculusFreeProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalculusAppliedOffer> CalculusAppliedOffers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalculusServiceCost> CalculusServicesCosts { get; set; }
    }
}
