namespace SellingAuto_s.Data
{
    public class Cities
    {
        public string cityName;
        public Stores storeName1;
        public Stores storeName2;

        public Cities(string cityName, Stores storeName1, Stores storeName2)
        {
            this.cityName = cityName;
            this.storeName1 = storeName1;
            this.storeName2 = storeName2;
        }

        public void DisplayCity()
        {
            System.Console.WriteLine(cityName);
            storeName1.DisplayStore();
            storeName2.DisplayStore();
        }

    }
}
