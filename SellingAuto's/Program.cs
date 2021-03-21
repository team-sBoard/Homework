using System;
using SellingAuto_s.Data;

namespace SellingAuto_s
{
    class Program
    {
        //а) Make a class 'Car', the car has a 'Color', 'Number', 'Model' and 'MaxSpeed' characteristics.
        //b) Make class 'Store', it sells only one Car model(toyota or Benz). The car in a store has a unique# but the same color, model, and max speed.
        //c) Class 'City', it has only 2 stores 'Store1' & 'Store2'. 'Store1' sells 'Toyota' 'Store2' sells 'Lainos'. 
        //d) Once opening project, need to create 2 cities, 4 stores, and 4 cars*.
        //e) Once user inputs a car#, program shows us where to buy a needed car. If number is wrong, program shows us where to buy the car with all those properties.

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Lada racing club");

            // Making the cities
            Console.WriteLine("Please give the name to the first city");
            Cities city1 = new Cities();

            city1.GetCityName();
            Console.WriteLine(city1.cityName);
            Console.ReadLine();

            Console.WriteLine("Now we have city called" + city1);

            // making the stores
            Console.WriteLine("Please give the name to the first store of the first city" + city1.cityName);
            Stores store1_1 = new Stores();
            //store1_1.Console.ReadLine();
            store1_1.Cities.cityName = city1.cityName;

            //  Console.WriteLine(city1.cityName + " has stores called " + store1_1._storeName);
            // Making the cars
            //Console.WriteLine("Now we going to create the cars. Every car has the color, make, top speed and a unique#");
            // Console.WriteLine("Creating the first car in a " + store1_1._storeName + " in a " + city1.cityName);
            Cars car1 = new Cars();
            car1.Stores.storeName = Console.ReadLine();
            car1.Cities = city1;
            car1.GetCar(car1.maxSpeed, car1.number, car1.color, car1.make);

            Console.WriteLine("Enter the car color");
            car1.color = "Red";

            Console.WriteLine("Enter the car make");
            car1.make = "Volkswagen";

            Console.WriteLine("Enter the car top Speed");
            car1.maxSpeed = 110;

            Console.WriteLine("Enter the car unique 4 digit number");
            car1.number = 1111;

            //Console.WriteLine("Hey, we just got a new car here. It's in a " + city1.cityName + "'s " + store1_1._storeName + "'s shop");
            Console.WriteLine($"The car is {car1.color} {car1.make} with the top speed of {car1.maxSpeed} kPh, and unique number is {car1.number}");
            Console.WriteLine(car1.Cities.cityName + car1.Stores.storeName);

            Console.ReadKey();

            store1_1.Cities.cityName = Console.ReadLine();
            Console.WriteLine("Press any key to see the Aplpha1 store city name");
            Console.ReadKey();
            Console.WriteLine("\n" + store1_1.Cities.cityName);
            Console.ReadKey();
        }
    }
}

