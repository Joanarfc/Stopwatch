using System;

namespace Stopwatch
{
    public class MainMenu
    {
        public static void DisplayMenu()
        {

            Stopwatch stopwatch = new Stopwatch();

            int convertedChoice;


            do
            {
                Console.Write("-------------Welcome to the Stopwatch------------\n");
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1 - Start");
                Console.WriteLine("2 - Stop");
                Console.WriteLine("3 - Clear");
                Console.WriteLine("9 - Quit");
                Console.Write("Insert your choice:");
                string choiceAsString = Console.ReadLine();

                bool parsedSuccess = int.TryParse(choiceAsString, out convertedChoice);

                if (parsedSuccess)
                {
                    switch (convertedChoice)
                    {
                        case 1:
                            stopwatch.Start();
                            break;
                        case 2:
                            stopwatch.Stop();
                            break;
                        case 3:
                            stopwatch.Clear();
                            break;
                        case 9:
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Invalid option!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option!");

                }
            }
            while (convertedChoice != 9);
        }
    }
}
