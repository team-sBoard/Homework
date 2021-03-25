using System;
namespace SellingAuto_s.Data
{
    public class Manager
    {
        public static Cities CreateCity1(Stores storeName1, Stores storeName2)
        {
            Console.WriteLine("Please name the first city");
            string cityName = " Alphaville "; //ReadString();
            Cities city1 = new Cities(cityName, storeName1, storeName2);
            return city1;
        }
        public static Cities CreateCity2(Stores storeName1, Stores storeName2)
        {
            Console.WriteLine("Please name the second city");
            string cityName = " Bravoburg "; //ReadString();
            Cities city2 = new Cities(cityName, storeName1, storeName2);
            return city2;
        }

        public static Stores CreateStore1_1(Cars cars)
        {
            Console.WriteLine("Please enter the 1 store Name!");
            string storeName1_1 = " GoldenStar ";//ReadString();
            Stores store1_1 = new Stores(storeName1_1, cars);
            return store1_1;
        }
        public static Stores CreateStore1_2(Cars cars)
        {
            System.Console.WriteLine("Please enter the 2 store Name!");
            string storeName1_2 = " MoonShine "; //ReadString();
            Stores store1_2 = new Stores(storeName1_2, cars);
            return store1_2;
        }
        public static Stores CreateStore2_1(Cars cars)
        {
            Console.WriteLine("Please enter the 3 store Name!");
            string storeName2_1 = " Used Freddy's cars ";//ReadString();
            Stores store2_1 = new Stores(storeName2_1, cars);
            return store2_1;
        }
        public static Stores CreateStore2_2(Cars cars)
        {
            Console.WriteLine("Please enter the 4 store Name!");
            string storeName2_2 = " All vehicles for $500 ";//ReadString();
            Stores store2_2 = new Stores(storeName2_2, cars);
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
            int maxSpeed1_2 = 102; //ReadInt();

            Console.WriteLine("Please enter the 2 car's number");
            int number1_2 = 1002; //ReadInt();

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
            int maxSpeed2_1 = 103; //ReadInt();

            Console.WriteLine("Please enter the 3 car's number");
            int number2_1 = 1003; //ReadInt();

            Console.WriteLine("Please enter the 3 car's color");
            string color2_1 = " Yellow "; //ReadString();

            Console.WriteLine("Please enter the 3 car's make");
            string make2_1 = " Benz "; //ReadString();

            Cars car2_1 = new Cars(maxSpeed2_1, number2_1, color2_1, make2_1);
            return car2_1;
        }
        public static Cars CreateCar2_2()
        {
            Console.WriteLine("Please enter the 4 car's max speed");
            int maxSpeed2_2 = 104; //ReadInt();

            Console.WriteLine("Please enter the 4 car's number");
            int number2_2 = 0004; //ReadInt();

            Console.WriteLine("Please enter the 4 car's color");
            string color2_2 = " Green "; //ReadString();

            Console.WriteLine("Please enter the 4 car's make");
            string make2_2 = " Chevy "; //ReadString();

            Cars car2_2 = new Cars(maxSpeed2_2, number2_2, color2_2, make2_2);
            return car2_2;
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

