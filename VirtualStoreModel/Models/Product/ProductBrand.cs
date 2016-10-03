namespace Pisa.VirtualStore.Models.Product
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.General;
    using Pisa.VirtualStore.Models.Base;

    public partial class ProductBrand : BaseAuditableModel
    {
        public string Name { get; set; }

        public int GeneralStatusId { get; set; }

        public virtual GeneralStatus GeneralStatus { get; set; }
    }
}
