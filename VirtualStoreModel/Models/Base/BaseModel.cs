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
    public abstract class BaseModel : IBaseModel
    {
        public int Id { get; set; }

        public object GetPropertyValue(string propertyName)
        {
            return this.GetType().GetProperty(propertyName).GetValue(this);
        }

        public void SetPropertyValue(string propertyName, object value)
        {
            this.GetType().GetProperty(propertyName).SetValue(this, value);
        }
    }
}
