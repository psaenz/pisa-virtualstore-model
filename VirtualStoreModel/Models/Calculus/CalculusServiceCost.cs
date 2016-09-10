using Pisa.VirtualStore.Models.Product;

namespace Pisa.VirtualStore.Models.Calculus
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Service;
    using Pisa.VirtualStore.Models.Base;

    public partial class CalculusServiceCost :BaseModel
    {
        public int IdCalculusOrder { get; set; }

        public int IdServiceType { get; set; }

        public double ServiceCost { get; set; }

        public virtual CalculusOrder CalculusOrder { get; set; }

        public virtual ServiceType ServiceType { get; set; }
    }
}
