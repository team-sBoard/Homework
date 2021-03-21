using System;
namespace SellingAuto_s.Data
{
    public class Manager
    {
        public static Cities CreateCity1(Stores stores, Stores stores_1)
        {
            Console.WriteLine("Please name the first city");
            string cityName1 = ReadString();
            Cities city1 = new Cities(cityName1, stores, stores_1);
            return city1;
        }
        public static Cities CreateCity2(Stores stores, Stores stores_2)
        {
            Console.WriteLine("Please name the second city");
            string cityName2 = ReadString();
            Cities city2 = new Cities(cityName2, stores, stores_2);
            return city2;
        }


        public static Stores CreateStore1_1(Cars cars)
        {
            Console.WriteLine("Please enter the 1 store Name!");
            string storeName1_1 = ReadString();
            Stores store1_1 = new Stores(storeName1_1, cars);
            return store1_1;
        }

        public static Stores CreateStore1_2(Cars cars)
        {
            System.Console.WriteLine("Please enter the 2 store Name!");
            string storeName1_2 = ReadString();
            Stores store1_2 = new Stores(storeName1_2, cars);
            return store1_2;
        }

        public static Stores CreateStore2_1(Cars cars)
        {
            System.Console.WriteLine("Please enter the 3 store Name!");
            string storeName2_1 = ReadString();
            Stores store2_1 = new Stores(storeName2_1, cars);
            return store2_1;
        }

        public static Stores CreateStore2_2(Cars cars)
        {
            System.Console.WriteLine("Please enter the 4 store Name!");
            string storeName2_2 = ReadString();
            Stores store2_2 = new Stores(storeName2_2, cars);
            return store2_2;
        }



        public static Cars CreateCar1_1()
        {
            System.Console.WriteLine("Please enter the 1 car's max speed");
            int maxSpeed1_1 = ReadInt();

            System.Console.WriteLine("Please enter the 1 car's number");
            int number1_1 = ReadInt();

            System.Console.WriteLine("Please enter the 1 car's color");
            string color1_1 = ReadString();

            System.Console.WriteLine("Please enter the 1 car's make");
            string make1_1 = ReadString();

            Cars car1_1 = new Cars(maxSpeed1_1, number1_1, color1_1, make1_1);
            return car1_1;
        }
        public static Cars CreateCar1_2()
        {
            System.Console.WriteLine("Please enter the 2 car's max speed");
            int maxSpeed1_2 = ReadInt();

            System.Console.WriteLine("Please enter the 2 car's number");
            int number1_2 = ReadInt();

            System.Console.WriteLine("Please enter the 2 car's color");
            string color1_2 = ReadString();

            System.Console.WriteLine("Please enter the 2 car's make");
            string make1_2 = ReadString();

            Cars car1_2 = new Cars(maxSpeed1_2, number1_2, color1_2, make1_2);
            return car1_2;
        }
        public static Cars CreateCar2_1()
        {
            System.Console.WriteLine("Please enter the 3 car's max speed");
            int maxSpeed2_1 = ReadInt();

            System.Console.WriteLine("Please enter the 3 car's number");
            int number2_1 = ReadInt();

            System.Console.WriteLine("Please enter the 3 car's color");
            string color2_1 = ReadString();

            System.Console.WriteLine("Please enter the 3 car's make");
            string make2_1 = ReadString();

            Cars car2_1 = new Cars(maxSpeed2_1, number2_1, color2_1, make2_1);
            return car2_1;
        }
        public static Cars CreateCar2_2()
        {
            System.Console.WriteLine("Please enter the 4 car's max speed");
            int maxSpeed2_2 = ReadInt();

            System.Console.WriteLine("Please enter the 4 car's number");
            int number2_2 = ReadInt();

            System.Console.WriteLine("Please enter the 4 car's color");
            string color2_2 = ReadString();

            System.Console.WriteLine("Please enter the 4 car's make");
            string make2_2 = ReadString();

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

