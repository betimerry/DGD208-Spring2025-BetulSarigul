using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanBesleme
{
    internal class Game
    {
        private bool _isRunning;

        public async Task Start()
        {
            bool showMainMenu = true;

            while (showMainMenu)
            {
                Console.Clear();
                Console.WriteLine("=== Main Menu ===");
                Console.WriteLine("1. New Game");
                Console.WriteLine("2. Credits");
                Console.WriteLine("0. Exit");
                Console.Write("Enter selection: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        await GameLoop();
                        break;
                    case "2":
                        ShowCredits();
                        break;
                    case "0":
                        showMainMenu = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Press any key...");
                        Console.ReadKey();
                        break;
                }
            }

            Console.WriteLine("Thanks for playing!");
        }

        private async Task GameLoop()
        {
            _isRunning = true;

            while (_isRunning)
            {
                Console.Clear();
                Console.WriteLine("=== Game Menu ===");
                Console.WriteLine("1. Feed Pet");
                Console.WriteLine("2. Adopt Pet");
                Console.WriteLine("3. Back to Main Menu");
                Console.Write("Enter selection: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("You fed your pet!");
                        break;
                    case "2":
                        Console.WriteLine("You adopted a pet!");
                        break;
                    case "3":
                        _isRunning = false;
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        private void ShowCredits()
        {
            Console.Clear();
            Console.WriteLine("=== Credits ===");
            Console.WriteLine("Created by: Betul Meryem Sarigul");
            Console.WriteLine("Student No: 225040092");
            Console.WriteLine();
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
        }
    }
}
