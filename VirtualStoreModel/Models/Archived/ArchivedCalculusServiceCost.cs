namespace Pisa.VirtualStore.Models.Archived
{
    using Pisa.VirtualStore.Models.Service;
    using Pisa.VirtualStore.Models.Base;

    public partial class ArchivedCalculusServiceCost : BaseModel
    {
        public int IdCalculusOrder { get; set; }

        public int IdServiceType { get; set; }

        public double ServiceCost { get; set; }

        public virtual ArchivedCalculusOrder ArchivedCalculusOrder { get; set; }

        public virtual ServiceType ServiceType { get; set; }
    }
}
