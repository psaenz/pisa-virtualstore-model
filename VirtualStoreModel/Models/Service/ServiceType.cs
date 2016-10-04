namespace Pisa.VirtualStore.Models.Service
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;
    using Pisa.VirtualStore.Models.Calculus;
    using Pisa.VirtualStore.Models.Order;
    using Pisa.VirtualStore.Models.Service;
    using Pisa.VirtualStore.Models.Archived;

    public partial class ServiceType : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
