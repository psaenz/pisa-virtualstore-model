namespace Pisa.VirtualStore.Models.Offer
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;
    using Pisa.VirtualStore.Models.Store;
    using Pisa.VirtualStore.Models.General;
    using Pisa.VirtualStore.Models.Archived;
    using Pisa.VirtualStore.Models.Calculus;

    public partial class Offer : BaseAuditableModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Offer()
        {
            OfferDetails = new HashSet<OffersDetail>();
        }

        public int IdStore { get; set; }

        public int IdStatus { get; set; }

        public int IdGeneralMedia { get; set; }

        public int IdGeneralSchedule { get; set; }

        public string Name { get; set; }

        public int MaximumPerOrder { get; set; }

        public virtual Store Store { get; set; }

        public virtual GeneralStatus GeneralStatus { get; set; }

        public virtual GeneralMedia GeneralMedia { get; set; }

        public virtual GeneralSchedule GeneralSchedule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OffersDetail> OfferDetails { get; set; }
    }
}
