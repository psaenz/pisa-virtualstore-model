namespace Pisa.VirtualStore.Models.Client
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;
    using Pisa.VirtualStore.Models.Product;

    public partial class ClientBasketDetail : BaseAuditableModel
    {
        public int IdBasket { get; set; }

        public int IdProduct { get; set; }

        public double Quantity { get; set; }

        public string MoreDetails { get; set; }

        public virtual Product Product { get; set; }

        public virtual ClientBasket Basket { get; set; }
    }
}
