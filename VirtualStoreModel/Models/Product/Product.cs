namespace Pisa.VirtualStore.Models.Product
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.General;
    using Pisa.VirtualStore.Models.Base;

    public partial class Product : BaseAuditableModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int IdProductBrand { get; set; }

        public int IdProductUnitOfMeasure { get; set; }

        public int IdGeneralMedia { get; set; }

        public virtual ProductBrand ProductBrand { get; set; }

        public virtual ProductUnitOfMeasure ProductUnitOfMeasure { get; set; }

        public virtual GeneralMedia GeneralMedia { get; set; }
    }
}
