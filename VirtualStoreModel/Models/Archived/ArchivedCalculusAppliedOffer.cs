namespace Pisa.VirtualStore.Models.Archived
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models;
    using Pisa.VirtualStore.Models.Base;
    using Pisa.VirtualStore.Models.Archived;
    using Pisa.VirtualStore.Models.Calculus;
    using Pisa.VirtualStore.Models.Contact;
    using Pisa.VirtualStore.Models.Client;
    using Pisa.VirtualStore.Models.Offer;
    using Pisa.VirtualStore.Models.Order;
    using Pisa.VirtualStore.Models.Service;
    using Pisa.VirtualStore.Models.Store;
    using Pisa.VirtualStore.Models.Security;

    public partial class ArchivedCalculusAppliedOffer : BaseModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ArchivedCalculusAppliedOffer()
        {
            ArchivedCalculusBasketDetails = new HashSet<ArchivedCalculusBasketDetail>();
        }

        public int IdCalculusOrder { get; set; }

        public int IdOffer { get; set; }

        public int NumberApplied { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArchivedCalculusBasketDetail> ArchivedCalculusBasketDetails { get; set; }

        public virtual ArchivedCalculusOrder ArchivedCalculusOrder { get; set; }

        public virtual Offer Offer { get; set; }
    }
}
