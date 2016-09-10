namespace Pisa.VirtualStore.Models.Contact
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Order;
    using Pisa.VirtualStore.Models.Store;
    using Pisa.VirtualStore.Models.General;
    using Pisa.VirtualStore.Models.Base;

    public partial class ContactRegion : BaseModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContactRegion()
        {
            ContactRegions = new HashSet<ContactRegion>();
        }

        public string Name { get; set; }

        public int IdContactRegionParent { get; set; }

        public int IdGeneralStatus { get; set; }

        public virtual ContactRegion ContactRegionParent { get; set; }

        public virtual GeneralStatus GeneralStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactRegion> ContactRegions { get; set; }
    }
}
