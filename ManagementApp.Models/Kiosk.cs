namespace ManagementApp.Models
{
    public class Kiosk : IStore
    {

        public string StoreName()
        {
            return "Name";
        }
        public int StoreNumber()
        {
            return 5549;
        }
        public string StoreType()
        {
            return "kiosk";
        }
        public int ProductPrice()
        {
            return 700;
        }


    }
}