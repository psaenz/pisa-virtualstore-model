namespace Pisa.VirtualStore.Models.Security
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;
    public partial class SecurityPerson : BaseAuditableModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MaidenName { get; set; }

        public string Email { get; set; }

        public bool EmailVerified { get; set; }
    }
}
