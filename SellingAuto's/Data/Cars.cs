namespace SellingAuto_s.Data
{
    public class Cars
    {
        public int maxSpeed;
        public int number;
        public string color;
        public string make;

        public Cars(int maxSpeed, int number, string color, string make)
        {
            this.maxSpeed = maxSpeed;
            this.number = number;
            this.color = color;
            this.make = make;
        }
        public void DisplayCar()
        {
            System.Console.WriteLine($"{maxSpeed } {number } {color } {make }");
        }
    }
}
