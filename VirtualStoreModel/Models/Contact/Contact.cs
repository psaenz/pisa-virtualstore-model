namespace Pisa.VirtualStore.Models.Contact
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;

    public partial class Contact : BaseAuditableModel
    {
        public int ContactTypeId { get; set; }

        public string Details { get; set; }

        public virtual ContactType ContactType { get; set; }
    }
}



