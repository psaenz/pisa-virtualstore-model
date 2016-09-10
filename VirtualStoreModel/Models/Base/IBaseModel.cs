namespace Pisa.VirtualStore.Models.Base
{
    public interface IBaseModel
    {
        int Id { get; set; }

        void setPropertyValue<T>(string propertyName, T value);
    }
}
