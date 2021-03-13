using System;

namespace MemeArchive
{
    class Program
    {
        static void Main(string[] args)

        /* Используя методы, написать такое приложение, которое должно:
         * При запуске вывести в консоль простой ASCII арт
         * Далее предложить ввести какое-то слово, и вызвать соответствующий значению слова арт 
         * exit - будет прерывать программу
         * если программа не найдёт в массиве нужный арт (или если в консоль введут какой-то мусор)
         * то последовательно вывести в консоль все арты с их именами */

        {
            string command;
            int MemeNumber = RandomNumberGenerator();  //get random number for choose the meme

            ShowRandomMeme(MemeNumber); //showing random meme, and a greeting with a random meme name
            Greeting(MemeNumber);

            do
            {
                Console.WriteLine("\n Please enter the meme's name!");

                command = Console.ReadLine();

                if (ShouldLeave(command))   //parse if we should exit
                {
                    break;
                }

                MemeSelectorForDisplay(command);    // Parsing from input, selecting right meme and displaying it

            }
            while (true);

            Console.WriteLine("Bye");

        }

        //Below we placing random hint what can we try to input to choose the meme to be displayed
        private static void Greeting(int MemeNumber)
        {
            switch (MemeNumber)
            {
                case 0:
                    Console.Write("To choose a meme to dispay, you can try type 'tree'");
                    break;
                case 1:
                    Console.Write("To choose a meme to dispay, you can try type 'bat'");
                    break;
                case 2:
                    Console.Write("To choose a meme to dispay, you can try type 'flower'");
                    break;
                case 3:
                    Console.Write("To choose a meme to dispay, you can try type 'man'");
                    break;
            }
        }

        private static int RandomNumberGenerator()                       // getting random int
        {
            Random RandomNumber = new Random();
            int MemeNumber = RandomNumber.Next(0, 3);
            return MemeNumber;
        }

        private static void ShowRandomMeme(int MemeNumber)              //choosing the appropriate meme
        {
            switch (MemeNumber)
            {
                case 0:
                    ShowBat();
                    break;
                case 1:
                    ShowFlower();
                    break;
                case 2:
                    ShowMan();
                    break;
                case 3:
                    ShowTree();
                    break;
            }
        }

        private static bool ShouldLeave(string command)              //test if exit = true
        {
            return command == "exit";
        }

        private static void MemeSelectorForDisplay(string command)  //checking which meme should we display
        {
            if (command == "bat")
            {
                ShowBat();
            }
            else if (command == "tree")
            {
                ShowTree();

            }
            else if (command == "man")
            {
                ShowMan();

            }
            else if (command == "flower")
            {
                ShowFlower();
            }
            else
            {
                ShowAllMemes();
            }
        }



        private static void ShowAllMemes() //displaying all memes if program can't parse input
        {
            Console.WriteLine("\nPlease see all the memes, but pick only one at a time!");
            ShowFlower();
            ShowMan();
            ShowBat();
            ShowTree();

        }

        private static void ShowFlower()
        {
            Console.WriteLine(@"
                                _   _
                             .-( '.' )-.
                            (   \ : /   )
                           ( `'-.;;;.-'` )
                          ( :-==;;;;;==-: )
                           (  .-';;;'-.  )
                            (`  / : \  `)
                             '-(_.'._)-'

                            That's a flower!");
        }

        private static void ShowMan()
        {
            Console.WriteLine(@"
                                (*_*)
                               \(   )/
                                /   \

                              That's a man!");
        }

        private static void ShowTree()
        {
            Console.WriteLine(@"
                                *
                               ***
                              *****

                          That's a tree!  ");
        }


        private static void ShowBat()
        {

            Console.WriteLine(@"
                                 /\                 /\
                                / \'._   (\_/)   _.' /\
                               / .''._'--(o.o)--'_.''. \
                              /.' _/ |`' =/  \= '`| \_`.\
                             /` .` `\:-,`\___ / `,-:/``.`\
                            /.- '      `\(-V-)/`      `- .\
                            `             ''   ''          `
                                                            
                                      That's a bat!");

        }
    }
}
