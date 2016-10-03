namespace Pisa.VirtualStore.Models.Audit
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Security;
    using Pisa.VirtualStore.Models.Base;

    public partial class AuditAuthor : BaseModel
    {
        // Dont add the SecurityUser here - we dont actually need it, and will create a cycle reference.
        // The lighter this class is the better
        // When it is -1 means it was created by the system, for instance Unit Tests or the Feed method in the VirtualStoreDbInitializer
        public int SecurityUserId { get; set; }

        public DateTime CurrentDate { get; set; }
    }
}
