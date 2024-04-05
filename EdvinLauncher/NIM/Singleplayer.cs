using index;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AnoeyeLauncher.NIM
{
    internal class Singleplayer
    {

        public static void SingleplayerStart()
        {
            Console.SetWindowSize(82, 18);
            Console.Clear();
            NIM.NIMAscii("");

            //Player Config
            Console.ResetColor();
            string player = Launcher.GetUserInput("How is your name, Player?\n (o_o) > ");
            Console.Clear();

            //Heart Config

            NIM.NIMAscii("");
            int sticks = Launcher.GetUserNumber("How many Sticks do you want to have?\n | > ");
            Console.Clear();

            //Game

            int[] drawn = new int[2];
            Random RNG = new Random();

            while (0 < sticks)
            {

                //Zufällige auswahl der cpu
                int randomNumber = RNG.Next(1, 3);

                //Title NIM

                NIM.NIMAscii("");

                //leaderboard

                Console.WriteLine("Leaderboard:\n" + player + ": " + drawn[1] + " Sticks\n" + "CPU" + ": " + drawn[0] + " Sticks\n" + sticks + " Sticks available yet\n");

                //Next CPU Turn Announce

                Console.WriteLine("CPU" + " is on the turn");

                Console.WriteLine("Turn 1 | How many Sticks do you want? (1, 2, 3)\n");

                sticks -= randomNumber;

                drawn[0] += randomNumber;

                Console.WriteLine("CPU chose " + randomNumber + " sticks");
                Thread.Sleep(3000);
                if (0 >= sticks)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"                    __                  _ \r\n/\\_/\\___  _   _    / /  ___  ___  ___  / \\\r\n\\_ _/ _ \\| | | |  / /  / _ \\/ __|/ _ \\/  /\r\n / \\ (_) | |_| | / /__| (_) \\__ \\  __/\\_/ \r\n \\_/\\___/ \\__,_| \\____/\\___/|___/\\___\\/   \r\n                                          {Environment.NewLine}");
                    Console.WriteLine($"{Environment.NewLine}" + "CPU has won the round");
                    Console.ResetColor();
                    break;
                }
                Console.Clear();

                //Prüfe ob alle sticks aufgebraucht sind

                if (0 >= sticks)
                {
                    break;
                }

                //Title NIM

                NIM.NIMAscii("");

                //leaderboard

                Console.WriteLine("Leaderboard:\n" + player + ": " + drawn[1] + " Sticks\n" + "CPU" + ": " + drawn[0] + " Sticks\n" + sticks + " Sticks available yet\n");

                //Next Player Turn Announce

                Console.WriteLine(player + " is on the turn");

                Console.WriteLine("Turn 1 | How many Sticks do you want? (1, 2, 3)\n");
                Console.Write("Your choice > ");
                int zug = int.Parse(Console.ReadLine());

                sticks -= zug;

                drawn[1] += zug;

                Console.WriteLine("You took " + zug + " sticks");
                Thread.Sleep(3000);
                if (0 >= sticks)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"                  __    __                _ \r\n/\\_/\\___  _   _  / / /\\ \\ \\___  _ __     / \\\r\n\\_ _/ _ \\| | | | \\ \\/  \\/ / _ \\| '_ \\   /  /\r\n / \\ (_) | |_| |  \\  /\\  / (_) | | | | /\\_/ \r\n \\_/\\___/ \\__,_|   \\/  \\/ \\___/|_| |_| \\/   \r\n                                            {Environment.NewLine}");
                    Console.WriteLine($"{Environment.NewLine}" + player + " has won the round");
                    Console.ResetColor();
                    break;
                }
                Console.Clear();
            }
            while (true)
            {
                Console.WriteLine("[true] Play again\n[false] Go to the Main Menu");
                bool couldread = bool.TryParse(Console.ReadLine(), out bool restart);
                if (couldread)
                {


                    if (restart)
                    {

                        Singleplayer.SingleplayerStart();
                        break;
                    }
                    else
                    {
                        Launcher.Main();
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Falsche eingabe");
                }

            } 

        }

    }
}
