namespace Pisa.VirtualStore.Models.Client
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;
    using Pisa.VirtualStore.Models.Security;
    using Pisa.VirtualStore.Models.Store;

    public partial class ClientFeedback : BaseModel
    {
        public int IdSecurityUser { get; set; }

        public int IdStore { get; set; }

        public DateTime FeedbackDate { get; set; }

        public string Feedback { get; set; }

        public string Answerd { get; set; }

        public bool Resolved { get; set; }

        public virtual SecurityUser SecurityUser { get; set; }

        public virtual Store Store { get; set; }
    }
}
