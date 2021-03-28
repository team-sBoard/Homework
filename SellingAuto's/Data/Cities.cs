namespace SellingAuto_s.Data
{
    public class Cities
    {
        public string cityName;
        public Stores storeName1;
        public Stores storeName2;

        public Cities(string cityName)
        {
            this.cityName = cityName;
        }

        public Cities(Cities cityName, Stores storeName1, Stores storeName2)
        {
            this.cityName = cityName.cityName;
            this.storeName1 = storeName1;
            this.storeName2 = storeName2;
        }

        public void DisplayCity()
        {
            System.Console.WriteLine("\n The city is " + cityName + "\n");
        }

    }
}
