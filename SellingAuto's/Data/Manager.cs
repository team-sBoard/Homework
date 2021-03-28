using System;

namespace SellingAuto_s.Data
{
    public class Manager
    {
        public static void CreateAllCities(out Cities city1, out Cities city2)
        {
            city1 = CreateCity1();
            //CreateCity1().DisplayCity();
            city2 = CreateCity2();
            //CreateCity2().DisplayCity();
            Console.WriteLine("Cities are created");
        }
        public static void CreateAllStores(out Stores store1_1, out Stores store1_2, out Stores store2_1, out Stores store2_2)
        {
            store1_1 = CreateStore1_1();
            //CreateStore1_1().DisplayStore();
            store1_2 = CreateStore1_2();
            //CreateStore1_2().DisplayStore();
            store2_1 = CreateStore2_1();
            //CreateStore2_1().DisplayStore();
            store2_2 = CreateStore2_2();
            //CreateStore2_2().DisplayStore();
            Console.WriteLine("Stores are created");
        }

        public static void CreateAllCars(out Cars car1_1, out Cars car1_2, out Cars car2_1, out Cars car2_2)
        {
            car1_1 = CreateCar1_1();
            //car1_1.DisplayCar();
            car1_2 = CreateCar1_2();
            //car1_2.DisplayCar();
            car2_1 = CreateCar2_1();
            //car2_1.DisplayCar();
            car2_2 = CreateCar2_2();
            //car2_2.DisplayCar();
            Console.WriteLine("Cars are created");
        }

        public static Cities CreateCity1()
        {
            Console.WriteLine("Please name the first city");
            Cities city1 = new Cities("Alphatown");
            city1.DisplayCity();
            return city1;
        }

        public static Cities CreateCity1(Cities city1, Stores storeName1, Stores storeName2)
        {
            Console.WriteLine("Please name the second city");
            //Cities city1 = new Cities(Console.ReadLine());
            city1 = new Cities(city1, city1.storeName1, city1.storeName2);
            return city1;
        }

        public static Cities CreateCity2()
        {
            Console.WriteLine("Please name the first city");
            Cities city2 = new Cities("Bravoburg");
            city2.DisplayCity();
            return city2;
        }

        public static Cities CreateCity2(Cities city2, Stores storeName1, Stores storeName2)
        {
            Console.WriteLine("Please name the second city");
            //Cities city2 = new Cities("Bravoburg");
            city2 = new Cities(city2, city2.storeName1, city2.storeName2);
            return city2;
        }

        public static Stores CreateStore1_1()
        {
            Stores store1_1 = new Stores("GoldenStar");
            store1_1.DisplayStore();
            return store1_1;
        }
        public static Stores CreateStore1_1(Stores store1_1, Cars cars)
        {
            Console.WriteLine("Please enter the store Name in the city");
            store1_1 = new Stores(store1_1.storeName, store1_1.Cars);
            return store1_1;
        }

        public static Stores CreateStore1_2()
        {
            Stores store1_2 = new Stores("MoonShine");
            store1_2.DisplayStore();
            return store1_2;
        }
        public static Stores CreateStore1_2(Stores store1_2, Cars cars)
        {
            Console.WriteLine("Please enter the 2 store Name!");
            store1_2 = new Stores(store1_2.storeName, store1_2.Cars);
            return store1_2;
        }
        public static Stores CreateStore2_1()
        {
            Stores store2_1 = new Stores("Used Freddy's cars");
            store2_1.DisplayStore();
            return store2_1;
        }

        public static Stores CreateStore2_1(Stores store2_1, Cars cars)
        {
            Console.WriteLine("Please enter the 3 store Name!");
            store2_1 = new Stores(store2_1.storeName, cars);
            return store2_1;
        }
        public static Stores CreateStore2_2()
        {
            Stores store2_2 = new Stores("Rusty Buckets");
            store2_2.DisplayStore();
            return store2_2;
        }
        public static Stores CreateStore2_2(Stores store2_2, Cars cars)
        {
            Console.WriteLine("Please enter the 4 store Name!");
            store2_2 = new Stores(store2_2.storeName, cars);
            return store2_2;
        }

        public static Cars CreateCar1_1()
        {
            Console.WriteLine("Please enter the 1 car's max speed");
            int maxSpeed1_1 = 100; //ReadInt();

            Console.WriteLine("Please enter the 1 car's number");
            int number1_1 = 1000; //ReadInt();

            Console.WriteLine("Please enter the 1 car's color");
            string color1_1 = " Red "; //ReadString();

            Console.WriteLine("Please enter the 1 car's make");
            string make1_1 = " Hino "; //ReadString();

            Cars car1_1 = new Cars(maxSpeed1_1, number1_1, color1_1, make1_1);
            return car1_1;
        }
        public static Cars CreateCar1_2()
        {
            Console.WriteLine("Please enter the 2 car's max speed");
            int maxSpeed1_2 = 101; //ReadInt();

            Console.WriteLine("Please enter the 2 car's number");
            int number1_2 = 1001; //ReadInt();

            Console.WriteLine("Please enter the 2 car's color");
            string color1_2 = " Orange "; //ReadString();

            Console.WriteLine("Please enter the 2 car's make");
            string make1_2 = " Ford "; ///ReadString();

            Cars car1_2 = new Cars(maxSpeed1_2, number1_2, color1_2, make1_2);
            return car1_2;
        }
        public static Cars CreateCar2_1()
        {
            Console.WriteLine("Please enter the 3 car's max speed");
            int maxSpeed2_1 = 102; //ReadInt();

            Console.WriteLine("Please enter the 3 car's number");
            int number2_1 = 1002; //ReadInt();

            Console.WriteLine("Please enter the 3 car's color");
            string color2_1 = " Yellow "; //ReadString();

            Console.WriteLine("Please enter the 3 car's make");
            string make2_1 = " Benz "; //ReadString();

            Cars car2_1 = new Cars(maxSpeed2_1, number2_1, color2_1, make2_1);
            return car2_1;
        }
        public static Cars CreateCar2_2()
        {
            Console.WriteLine($"Please enter the 4th car's max speed");
            int maxSpeed2_2 = 103; //ReadInt();            

            Console.WriteLine("Please enter the 4 car's number");
            int number2_2 = 1003; //ReadInt();

            Console.WriteLine("Please enter the 4 car's color");
            string color2_2 = " Green "; //ReadString();

            Console.WriteLine("Please enter the 4 car's make");
            string make2_2 = " Chevy "; //ReadString();

            Cars car2_2 = new Cars(maxSpeed2_2, number2_2, color2_2, make2_2);
            return car2_2;
        }

        public static bool ShouldLeave(string command)
        {
            return command == "exit";
        }

        public static string ReadString()
        {
            return System.Console.ReadLine();
        }
        public static int ReadInt()
        {
            return int.Parse(ReadString());
        }
    }
}

