namespace Pisa.VirtualStore.Models.Security
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.General;
    using Pisa.VirtualStore.Models.Base;

    public enum SecurityProfileType : int
    {
        Administrator = 10,
        Client = 20,
        Store = 30,
        Brand = 40,
        Provider = 50
    }

    public partial class SecurityProfile : BaseAuditableModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SecurityProfile()
        {
            SecurityProfileActions = new HashSet<SecurityProfileAction>();
        }

        public string Name { get; set; }

        public int IdSecurityProfileType { get; set; }

        public int IdGeneralStatus { get; set; }

        public int IdSecurityProfileParent { get; set; }

        public int IdSecurityAccountCreator { get; set; }

        public SecurityProfileType SecurityProfileType { get; set; }

        public virtual GeneralStatus GeneralStatus { get; set; }

        public virtual SecurityProfile SecurityProfileParent { get; set; }

        public virtual SecurityAccount SecurityAccountCreator { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SecurityProfileAction> SecurityProfileActions { get; set; }
    }
}
