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


            Cars car1_1 = Manager.CreateCar1_1();
            Cars car1_2 = Manager.CreateCar1_2();
            Cars car2_1 = Manager.CreateCar2_1();
            Cars car2_2 = Manager.CreateCar2_2();

            Stores store1_1 = Manager.CreateStore1_1(car1_1);
            Stores store1_2 = Manager.CreateStore1_2(car1_2);
            Stores store2_1 = Manager.CreateStore2_1(car2_1);
            Stores store2_2 = Manager.CreateStore2_2(car2_2);

            Cities city1 = Manager.CreateCity1(store1_1, store1_2);
            Cities city2 = Manager.CreateCity2(store2_1, store2_2);


            Console.WriteLine("TEST PURPOSE BLOCK BELOW");

            Console.WriteLine("\n" + city1.storeName1.Cars.maxSpeed + "\n");
            Console.WriteLine("\n" + city1.cityName + store1_1.storeName + "\n");
            Console.WriteLine("\n" + city1.storeName2.Cars.color + city1.storeName2.Cars.make + "\n");
            Console.WriteLine("\n" + store2_2.Cars.color + store2_2.Cars.make + store2_2.Cars.number + store2_2.Cars.maxSpeed + "\n");

            Console.WriteLine(city1.storeName2.storeName);
            Console.WriteLine(city1.storeName2.storeName);

            Console.WriteLine("Cars are below");

            car1_1.DisplayCar();
            car1_2.DisplayCar();
            car2_1.DisplayCar();
            car2_2.DisplayCar();

            Console.WriteLine("Stores are below");

            store1_1.DisplayStore();
            store1_2.DisplayStore();
            store2_1.DisplayStore();
            store2_2.DisplayStore();


            Console.WriteLine("Cities below are below");

            city1.DisplayCity();
            city2.DisplayCity();
        }



    }
}

