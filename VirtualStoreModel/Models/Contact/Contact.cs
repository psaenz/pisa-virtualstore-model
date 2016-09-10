namespace Pisa.VirtualStore.Models.Contact
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;

    public partial class Contact : BaseAuditableModel
    {
        public int IdContactType { get; set; }

        public string Description { get; set; }

        public virtual ContactType ContactType { get; set; }
    }
}



