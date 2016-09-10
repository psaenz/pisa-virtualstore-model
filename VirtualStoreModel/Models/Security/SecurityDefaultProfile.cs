namespace Pisa.VirtualStore.Models.Security
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;

    /// <summary>
    /// Associates an SecurityProfileType with its default profile
    /// When a user is created, the profile assigned will be the default indicated here
    /// Only administrator could change this
    /// Administrators don't have a profile, they can access everything
    /// </summary>
    public partial class SecurityDefaultProfile : BaseAuditableModel
    {
        /*[DatabaseGenerated(DatabaseGeneratedOption.None)]*/
        public int IdSecurityProfileType { get; set; }

        public int IdSecurityProfile { get; set; }

        public virtual SecurityProfileType SecurityProfileType { get; set; }

        public virtual SecurityProfile SecurityProfile { get; set; }
    }
}
