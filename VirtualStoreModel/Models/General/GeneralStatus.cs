namespace Pisa.VirtualStore.Models.General
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;

    public partial class GeneralStatus : BaseModel
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }
    }
}
