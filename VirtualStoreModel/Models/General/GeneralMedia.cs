namespace Pisa.VirtualStore.Models.General
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;

    public partial class GeneralMedia : BaseAuditableModel
    {
        public byte[] MediaData { get; set; }

        public string MediaReference { get; set; }

        public string MediaType { get; set; }

        public float Height { get; set; }

        public float Width { get; set; }
    }
}
