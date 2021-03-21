namespace SellingAuto_s.Data
{
    public class Cities
    {
        public string cityName;
        public Stores firstStoreName;
        public Stores secondStoreName;

        public Cities(string cityName, Stores firtStoreName, Stores secondStoreName)
        {
            this.cityName = cityName;
            this.firstStoreName = firtStoreName;
            this.secondStoreName = secondStoreName;
        }

        public void DisplayFirstCity()
        {
            System.Console.WriteLine(cityName);
        }
    }
}
