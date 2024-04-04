using index;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnoeyeLauncher.NIM
{
    internal class Multiplayer
    {

        public static void MultiplayerStart()
        {

            {
                Console.Title = "Anoeye Launcher | Main Menu";
                Console.SetWindowSize(82, 18);
                Console.Clear();
                NIM.NIMAscii("");

                //Player1 Config
                Console.ResetColor();
                string player1 = Launcher.GetUserInput("How is your name, Player 1?\n (o_o) > ");
                Console.Clear();
                NIM.NIMAscii("");

                //Player2 Config
                Console.ResetColor();
                string player2 = Launcher.GetUserInput("How is your name, Player 2?\n (o_o) > ");
                Console.Clear();

                //Heart Config

                NIM.NIMAscii("");
                int sticks = Launcher.GetUserNumber("How many Sticks do you want to play with?\n | > ");
                Console.Clear();

                //Game

                int[] drawn = new int[2];

                while (0 < sticks)
                {

                    //Title NIM

                    NIM.NIMAscii("");

                    //leaderboard

                    Console.WriteLine("Leaderboard:\n" + player1 + ": " + drawn[1] + " Sticks\n" + player2 + ": " + drawn[0] + " Sticks\n" + sticks + " Sticks available yet\n");

                    //Next CPU Turn Announce

                    Console.WriteLine("Turn 1 | How many Sticks do you want? (1, 2, 3)\n");
                    Console.Write(player2 + " > ");
                    int zug1 = int.Parse(Console.ReadLine());

                    sticks -= zug1;

                    drawn[0] += zug1;

                    Console.WriteLine(player2 + " chose " + zug1 + " sticks");
                    Thread.Sleep(3000);
                    Console.Clear();

                    //Prüfe ob alle sticks aufgebraucht sind

                    if (0 >= sticks)
                    {
                        break;
                    }

                    //Title NIM

                    NIM.NIMAscii("");

                    //leaderboard

                    Console.WriteLine("Leaderboard:\n" + player1 + ": " + drawn[1] + " Sticks\n" + player2 + ": " + drawn[0] + " Sticks\n" + sticks + " Sticks available yet\n");

                    //Next Player Turn Announce

                    Console.WriteLine("Turn 1 | How many Sticks do you want? (1, 2, 3)\n");
                    Console.Write(player1 + " > ");
                    int zug = int.Parse(Console.ReadLine());

                    sticks -= zug;

                    drawn[1] += zug;

                    Console.WriteLine("You took " + zug + " sticks");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                while (true)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"                  __    __                _ \r\n/\\_/\\___  _   _  / / /\\ \\ \\___  _ __     / \\\r\n\\_ _/ _ \\| | | | \\ \\/  \\/ / _ \\| '_ \\   /  /\r\n / \\ (_) | |_| |  \\  /\\  / (_) | | | | /\\_/ \r\n \\_/\\___/ \\__,_|   \\/  \\/ \\___/|_| |_| \\/   \r\n                                            {Environment.NewLine}");
                    Console.WriteLine($"{Environment.NewLine}" + player1 + " has won the round");
                    Console.ResetColor();
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
}
