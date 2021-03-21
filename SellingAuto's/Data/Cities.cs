namespace SellingAuto_s.Data
{
    public class Cities
    {
        public string cityName;
        public Stores Stores;
        public Cars Cars;

        public void GetCityName()
        {
            cityName = System.Console.ReadLine();
        }
    }
}
