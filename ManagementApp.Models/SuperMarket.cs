namespace ManagementApp.Models
{
    public class SuperMarket : IStore
    {
        public string StoreName()
        {
            return "Name";
        }
        public int StoreNumber()
        {
            return 0755;
        }
        public string StoreType()
        {
            return "Supermarket";
        }
        public int ProductPrice()
        {
            return 500;
        }
        
    }
}