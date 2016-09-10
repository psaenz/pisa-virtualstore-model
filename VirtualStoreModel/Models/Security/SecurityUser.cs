namespace Pisa.VirtualStore.Models.Security
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.General;
    using Pisa.VirtualStore.Models.Base;
    public partial class SecurityUser : BaseAuditableModel
    {
        public int IdSecurityPerson { get; set; }

        public int IdGeneralStatus { get; set; }

        public int IdLastAccountUsed { get; set; }

        public string User { get; set; }

        public string Password { get; set; }

        public bool MustChangeThePassword { get; set; }

        public virtual GeneralStatus GeneralStatus { get; set; }

        public virtual SecurityPerson SecurityPerson { get; set; }

        /// <summary>
        /// When a user is invited by an Store to register, and later it user is removed we need
        /// to tell the user from which account he was removed and let them create a new Account
        /// </summary>
        public virtual SecurityAccount LastAccountUsed { get; set; }
    }
}
