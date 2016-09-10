namespace Pisa.VirtualStore.Models.Client
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;
    using Pisa.VirtualStore.Models.Security;

    public partial class ClientBasket : BaseAuditableModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClientBasket()
        {
            ClientBasketDetails = new HashSet<ClientBasketDetail>();
        }

        public int IdSecurityUser { get; set; }

        public int Sequence { get; set; }

        public string Name { get; set; }

        public virtual SecurityUser SecurityUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientBasketDetail> ClientBasketDetails { get; set; }
    }
}
