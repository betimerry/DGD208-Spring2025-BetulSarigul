
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. Credits");
            Console.WriteLine("3. Exit the Game");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Game game = new Game();
                await game.GameLoop();
            }
            else if (choice == "2")
            {
                Console.Clear();
                Console.WriteLine("Creator: Betül Meryem Sarıgül");
                Console.WriteLine("Student Number: 225040092");
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
            else if (choice == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                Console.ReadKey();
            }
        }
    }
}
