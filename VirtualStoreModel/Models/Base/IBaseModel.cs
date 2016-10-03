namespace Pisa.VirtualStore.Models.Base
{
    public interface IBaseModel
    {
        int Id { get; set; }

        void SetPropertyValue(string propertyName, object value);
    }
}
