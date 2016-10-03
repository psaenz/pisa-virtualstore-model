using Pisa.VirtualStore.Models.Product;

namespace Pisa.VirtualStore.Models.Calculus
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Service;
    using Pisa.VirtualStore.Models.Base;

    public partial class CalculusServiceCost :BaseModel
    {
        public int CalculusOrderId { get; set; }

        public int ServiceTypeId { get; set; }

        public double ServiceCost { get; set; }

        public virtual CalculusOrder CalculusOrder { get; set; }

        public virtual ServiceType ServiceType { get; set; }
    }
}
