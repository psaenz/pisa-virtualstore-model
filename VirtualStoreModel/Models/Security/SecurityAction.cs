namespace Pisa.VirtualStore.Models.Security
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.General;
    using Pisa.VirtualStore.Models.Base;
    public partial class SecurityAction : BaseAuditableModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SecurityAction()
        {
            SecurityActions = new HashSet<SecurityAction>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ActionToExecute { get; set; }

        public int Order { get; set; }

        public int IdSecurityActionParent { get; set; }

        public int IdGeneralStatus { get; set; }

        /// <summary>
        /// Use to disable an option for all the profiles and users
        /// </summary>
        public virtual GeneralStatus GeneralStatus { get; set; }

        public virtual SecurityAction SecurityActionParent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SecurityAction> SecurityActions { get; set; }
    }
}
