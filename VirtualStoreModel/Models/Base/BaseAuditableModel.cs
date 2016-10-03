using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pisa.VirtualStore.Models.Base
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Audit;
    using Pisa.VirtualStore.Models.Archived;
    using Pisa.VirtualStore.Models.Base;
    using Pisa.VirtualStore.Models.Client;
    using Pisa.VirtualStore.Models.Calculus;
    using Pisa.VirtualStore.Models.Contact;
    using Pisa.VirtualStore.Models.General;
    using Pisa.VirtualStore.Models.Offer;
    using Pisa.VirtualStore.Models.Order;
    using Pisa.VirtualStore.Models.Product;
    using Pisa.VirtualStore.Models.Security;
    using Pisa.VirtualStore.Models.Service;
    using Pisa.VirtualStore.Models.Store;

    // It is abstracted so not body can instantiate it
    public abstract class BaseAuditableModel : BaseModel, IBaseAuditableModel
    {
        public DateTime AddedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public int AddedById { get; set; }

        public int UpdatedById { get; set; }
    }
}
