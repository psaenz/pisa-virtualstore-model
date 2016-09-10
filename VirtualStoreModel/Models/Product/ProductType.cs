namespace Pisa.VirtualStore.Models.Product
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.General;
    using Pisa.VirtualStore.Models.Base;

    public partial class ProductType : BaseModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductType()
        {
            ProductTypes = new HashSet<ProductType>();
        }

        public string Name { get; set; }

        public int IdProductTypeParent { get; set; }

        public int IdGeneralStatus { get; set; }

        public virtual ProductType ProductTypeParent { get; set; }

        public virtual GeneralStatus GeneralStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductType> ProductTypes { get; set; }
    }
}
