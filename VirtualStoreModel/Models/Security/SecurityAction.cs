namespace Pisa.VirtualStore.Models.Security
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.General;
    using Pisa.VirtualStore.Models.Base;
    public partial class SecurityAction : BaseAuditableModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ActionToExecute { get; set; }

        public int Order { get; set; }

        public int? SecurityActionParentId { get; set; }

        public int GeneralStatusId { get; set; }

        /// <summary>
        /// Use to disable an option for all the profiles and users
        /// </summary>
        public virtual GeneralStatus GeneralStatus { get; set; }

        public virtual SecurityAction SecurityActionParent { get; set; }
    }
}
