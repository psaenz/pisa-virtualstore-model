namespace Pisa.VirtualStore.Models.Archived
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Product;
    using Pisa.VirtualStore.Models.Base;

    public partial class ArchivedCalculusFreeProduct : BaseModel
    {
        public int IdArchivedCalculusOrder { get; set; }

        public int IdProduct { get; set; }

        public int Quantity { get; set; }

        public virtual ArchivedCalculusOrder ArchivedCalculusOrder { get; set; }

        public virtual Product Product { get; set; }
    }
}
