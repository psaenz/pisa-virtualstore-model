namespace Pisa.VirtualStore.Models.Contact
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;
    using Pisa.VirtualStore.Models.General;

    public partial class ContactInfo : BaseAuditableModel
    {
        public int ContactTypeId { get; set; }

        public int StatusId { get; set; }

        public string Details { get; set; }

        public virtual GeneralStatus status { get; set; }

        public virtual ContactType ContactType { get; set; }
    }
}



