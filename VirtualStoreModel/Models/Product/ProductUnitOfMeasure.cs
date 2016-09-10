namespace Pisa.VirtualStore.Models.Product
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;

    public partial class ProductUnitOfMeasure : BaseModel
    {
        public string Name { get; set; }

        public string Symbol { get; set; }
    }
}
