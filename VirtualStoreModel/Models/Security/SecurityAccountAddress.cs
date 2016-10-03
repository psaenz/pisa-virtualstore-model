namespace Pisa.VirtualStore.Models.Security
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Contact;
    using Pisa.VirtualStore.Models.Base;

    public partial class SecurityAccountAddress : BaseAuditableModel
    {
        public int ContactAddressId { get; set; }

        public int SecurityAccountId { get; set; }

        public virtual ContactAddress ContactAddress { get; set; }

        public virtual SecurityAccount SecurityAccount { get; set; }
    }
}
