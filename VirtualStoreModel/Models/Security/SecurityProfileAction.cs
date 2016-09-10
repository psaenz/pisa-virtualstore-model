namespace Pisa.VirtualStore.Models.Security
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;
    public partial class SecurityProfileAction : BaseAuditableModel
    {
        public int IdSecurityProfile { get; set; }

        public int IdSecurityAction { get; set; }

        public bool Available { get; set; }

        public virtual SecurityAction SecurityAction { get; set; }

        public virtual SecurityProfile SecurityProfile { get; set; }
    }
}
