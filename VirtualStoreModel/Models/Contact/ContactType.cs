namespace Pisa.VirtualStore.Models.Contact
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;

    public partial class ContactType : BaseModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContactType()
        {
            Contacts = new HashSet<Contact>();
        }

        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
