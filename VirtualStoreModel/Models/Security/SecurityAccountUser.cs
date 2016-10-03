namespace Pisa.VirtualStore.Models.Security
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;

    public partial class SecurityAccountUser : BaseAuditableModel
    {
        public int SecurityAccountId { get; set; }

        public int SecurityUserId { get; set; }

        public int SecurityProfileId { get; set; }

        public SecurityAccount SecurityAccount { get; set; }

        public SecurityUser SecurityUser { get; set; }

        public SecurityProfile SecurityProfile { get; set; }

        /// <summary>
        /// When a user has several accounts, this column will indicate which one is used as default
        /// </summary>
        public bool Default { get; set; }
    }
}
