using System;
using SellingAuto_s.Data;

namespace SellingAuto_s
{
    class Program
    {
        //а) Make a class 'Car', the car has a 'Color', 'Number', 'Model' and 'MaxSpeed' characteristics.
        //b) Make class 'Store', it sells only one Car model(Toyota or Benz). The car in a store has a unique# but the same color, model, and max speed.
        //c) Class 'City', it has only 2 stores 'Store1' & 'Store2'. 'Store1' sells 'Toyota' 'Store2' sells 'Lainos'. 
        //d) Once opening project, need to create 2 cities, 4 stores, and 4 cars*.
        //e) Once user inputs a car#, program shows us where to buy a needed car. If number is wrong, program shows us where to buy the car with all those properties.

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Lada racing club");
            Console.WriteLine("\nType 'exit' to exit the program in any time");

            string command;
            Cities city1, city2;
            Stores store1_1, store1_2, store2_1, store2_2;
            Cars car1_1, car1_2, car2_1, car2_2;

            city1 = Manager.CreateCity1();
            city2 = Manager.CreateCity2();
            store1_1 = Manager.CreateStore1_1();
            store1_2 = Manager.CreateStore1_2();
            store2_1 = Manager.CreateStore2_1();
            store2_2 = Manager.CreateStore2_2();

            Manager.CreateAllCars(out car1_1, out car1_2, out car2_1, out car2_2);
            Manager.CreateStore1_1(store1_1, car1_1);
            Manager.CreateStore1_2(store1_2, car1_2);
            Manager.CreateStore2_1(store2_1, car2_1);
            Manager.CreateStore2_2(store2_2, car2_2);

            Manager.CreateCity1(city1, store1_1, store1_2);
            Manager.CreateCity2(city2, store2_1, store2_2);

            car1_1 = Manager.CreateCar1_1();
            car1_2 = Manager.CreateCar1_2();
            car2_1 = Manager.CreateCar2_1();
            car2_2 = Manager.CreateCar2_2();

            //Manager.CreateAllStores(out store1_1, out store1_2, out store2_1, out store2_2);
            //Manager.CreateAllCities(out city1, out city2);

            //Console.WriteLine("TEST PURPOSE BLOCK BELOW");
            //Console.WriteLine("TEST PURPOSE BLOCK BELOW");
            //Console.WriteLine("\n" + city1.storeName1.Cars.maxSpeed + "\n");
            //Console.WriteLine("\n" + city1.cityName + store1_1.storeName + "\n");
            //Console.WriteLine("\n" + city1.storeName2.Cars.color + city1.storeName2.Cars.make + "\n");
            //Console.WriteLine("\n" + store2_2.Cars.color + store2_2.Cars.make + store2_2.Cars.number + store2_2.Cars.maxSpeed + "\n");
            //Console.WriteLine(city1.storeName2.storeName);
            //Console.WriteLine(city1.storeName2.storeName);
            //Console.WriteLine("TEST PURPOSE BLOCK ABOVE");
            //Console.WriteLine("TEST PURPOSE BLOCK ABOVE");



            Console.WriteLine("Congratulations, the store has been created, now enter the command");
            Console.WriteLine("Quick hint: you may find a car by entering the number!");
            do
            {
                Console.WriteLine($"There's following options to choose:\n {car1_1.number} \n {car1_2.number} \n {car2_1.number} \n {car2_2.number}");
                Console.WriteLine("Also y may type 'all' to see all the options, or 'exit' for quitting this.");

                command = Console.ReadLine();
                Console.WriteLine("\n You typed " + command + "\n");

                int number;

                if (Manager.ShouldLeave(command))
                {
                    break;
                }
                if (command == "all")
                {
                    car1_1.DisplayCar();
                    car1_2.DisplayCar();
                    car2_1.DisplayCar();
                    car2_2.DisplayCar();
                }

                if (!int.TryParse(command, out number))
                {
                    Console.WriteLine("IS that you looking for? If not, please try something else");
                    continue;
                }

                if (car1_1.number == number)
                {
                    car1_1.DisplayCar();
                    Console.Write("You can find it in ");
                    store1_1.DisplayStore();
                    city1.DisplayCity();
                }

                else if (car1_2.number == number)
                {
                    car1_2.DisplayCar();
                    Console.Write("You can find it in ");
                    store1_2.DisplayStore();
                    city1.DisplayCity();
                }

                else if (car2_1.number == number)
                {
                    car2_1.DisplayCar();
                    Console.Write("You can find it in ");
                    store2_1.DisplayStore();
                    city2.DisplayCity();
                }

                else if (car2_2.number == number)
                {
                    car2_2.DisplayCar();
                    Console.Write("You can find it in ");
                    store2_2.DisplayStore();
                    city2.DisplayCity();
                }
                else
                {
                    Console.WriteLine("Looks like there's no such number. Please try once more.");
                }
            }
            while (true);
            Console.WriteLine("Ciao!");


        }
    }
}

