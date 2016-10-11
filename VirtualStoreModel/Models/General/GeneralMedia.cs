namespace Pisa.VirtualStore.Models.General
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;

    public partial class GeneralMedia : BaseAuditableModel
    {
        public byte[] MediaData { get; set; }

        public string MediaReference { get; set; }

        public GeneralMediaType MediaType { get; set; }

        public Nullable<double> Height { get; set; }

        public Nullable<double> Width { get; set; }
    }
}
