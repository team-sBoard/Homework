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

            do
            {

                Console.WriteLine("Please enter the meme's name");
                command = Console.ReadLine();
                if (ShouldLeave(command))
                {
                    break;
                }

                MemeSelectorForDisplay(command);

            }
            while (true);

            Console.WriteLine("Bye");

        }

        private static bool ShouldLeave(string command)
        {
            return command == "exit";
        }

        private static void MemeSelectorForDisplay(string command)
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



        private static void ShowAllMemes()
        {
            Console.WriteLine("Please see all the memes, pick one at a time!");
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
                           `             ''   ''    
`
                                      That's a bat!");

        }
    }
}
