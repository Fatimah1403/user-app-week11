namespace ManagementApp.Models
{
    public interface IStore
    {
         string StoreName();
         int StoreNumber();
         string StoreType();
         int ProductPrice();
    }
}