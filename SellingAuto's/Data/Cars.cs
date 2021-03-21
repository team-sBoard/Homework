namespace SellingAuto_s.Data
{
    public class Cars
    {
        public int maxSpeed, number;
        public string color, make;

        public Cities Cities;
        public Stores Stores;

        public void GetCar(int maxSpeed, int number, string color, string make)
        {
            System.Console.WriteLine("Please enter the car's max speed");
            GetMaxSpeed(maxSpeed);

            System.Console.WriteLine("Please enter the car's number");
            GetMaxNumber(number);

            System.Console.WriteLine("Please enter the car's color");
            GetColor(color);

            System.Console.WriteLine("Please enter the car's make");
            GetMake(make);
        }
        public int GetMaxSpeed(int maxSpeed)
        {
            System.Console.ReadLine();
            return maxSpeed;
        }

        public int GetMaxNumber(int number)
        {
            System.Console.ReadLine();
            return number;
        }
        public string GetColor(string color)
        {
            System.Console.ReadLine();
            return color;
        }
        public string GetMake(string make)
        {
            System.Console.ReadLine();
            return make;
        }





        //public void DisplayCarInfo()
        //{
        //    Console.WriteLine("That's a" + color + make + ". With top speed " + maxSpeed + "kPh " + "has a number " + number);
        //}

        //public Cars CreateTheCar(string make, string color, int maxSpeed, int number)
        //{
        //    return new Cars(make, color, maxSpeed, number);
        //}
    }
}
