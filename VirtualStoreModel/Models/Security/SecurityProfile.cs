namespace Pisa.VirtualStore.Models.Security
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.General;
    using Pisa.VirtualStore.Models.Base;
    public partial class SecurityProfile : BaseAuditableModel
    {
        public string Name { get; set; }

        public int SecurityProfileTypeId { get; set; }

        public int GeneralStatusId { get; set; }

        public Nullable<int> SecurityProfileParentId { get; set; }

        //public int SecurityAccountCreatorId { get; set; }

        public SecurityProfileType SecurityProfileType { get; set; }

        public virtual GeneralStatus GeneralStatus { get; set; }

        public virtual SecurityProfile SecurityProfileParent { get; set; }

        //public virtual SecurityAccount SecurityAccountCreator { get; set; }
    }
}
