namespace Pisa.VirtualStore.Models.Calculus
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Product;
    using Pisa.VirtualStore.Models.Base;

    public partial class CalculusFreeProduct : BaseModel
    {
        public int IdCalculusOrder { get; set; }

        public int IdProduct { get; set; }

        public int Quantity { get; set; }

        public virtual CalculusOrder CalculusOrder { get; set; }

        public virtual Product Product { get; set; }
    }
}
