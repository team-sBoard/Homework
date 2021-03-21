namespace SellingAuto_s.Data
{
    public class Stores
    {
        public string storeName;
        public Cars Cars;

        public Stores(string storeName, Cars cars)
        {
            this.storeName = storeName;
            this.Cars = cars;
        }
    }
}
