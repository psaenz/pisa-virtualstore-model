namespace Pisa.VirtualStore.Models.Archived
{
    using Pisa.VirtualStore.Models.Service;
    using Pisa.VirtualStore.Models.Base;

    public partial class ArchivedCalculusServiceCost : BaseModel
    {
        public int CalculusOrderId { get; set; }

        public int ServiceTypeId { get; set; }

        public double ServiceCost { get; set; }

        public virtual ArchivedCalculusOrder CalculusOrder { get; set; }

        public virtual ServiceType ServiceType { get; set; }
    }
}
