using index;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnoeyeLauncher.Hangman
{
    internal class Singleplayer
    {

        public static void SingleplayerStart()
        {
            Console.Clear();
            Hangman.HangmanAscii("");

            //Player Config
            Console.ResetColor();
            string player = Launcher.GetUserInput("How is your name, Player?\n (o_o) > ");
            Console.Clear();

            //Heart Config

            Hangman.HangmanAscii("");
            int hearts = Launcher.GetUserNumber("How many Hearts do you want to have?\n ♥ > ");

            //CPU Pretend to think about choosing a word and it takes time
            Console.WriteLine("   ___   ___           __                 _ _             \r\n  / __\\ / _ \\/\\ /\\    / /  ___   __ _  __| (_)_ __   __ _ \r\n / /   / /_)/ / \\ \\  / /  / _ \\ / _` |/ _` | | '_ \\ / _` |\r\n/ /___/ ___/\\ \\_/ / / /__| (_) | (_| | (_| | | | | | (_| |\r\n\\____/\\/     \\___/  \\____/\\___/ \\__,_|\\__,_|_|_| |_|\\__, |\r\n                                                    |___/ ");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            //String Converter

            var random = new Random();

            var list = new List<string>
            {
                "Fortnite",
                "Anoeye",
                "Loskubalos"
            };
            int index = random.Next(list.Count);

            Console.WriteLine("                                               \r\n  /\\  /\\__ _ _ __   __ _ _ __ ___   __ _ _ __  \r\n / /_/ / _` | '_ \\ / _` | '_ ` _ \\ / _` | '_ \\ \r\n/ __  / (_| | | | | (_| | | | | | | (_| | | | |\r\n\\/ /_/ \\__,_|_| |_|\\__, |_| |_| |_|\\__,_|_| |_|\r\n                   |___/                       ");
            string realstr = list[index];
            string str = realstr;
            realstr = str.ToLower();
            str = str.ToLower();
            str = str.Replace("a", "*");
            str = str.Replace("b", "*");
            str = str.Replace("c", "*");
            str = str.Replace("d", "*");
            str = str.Replace("e", "*");
            str = str.Replace("f", "*");
            str = str.Replace("g", "*");
            str = str.Replace("h", "*");
            str = str.Replace("i", "*");
            str = str.Replace("j", "*");
            str = str.Replace("k", "*");
            str = str.Replace("l", "*");
            str = str.Replace("m", "*");
            str = str.Replace("n", "*");
            str = str.Replace("o", "*");
            str = str.Replace("p", "*");
            str = str.Replace("q", "*");
            str = str.Replace("r", "*");
            str = str.Replace("s", "*");
            str = str.Replace("t", "*");
            str = str.Replace("u", "*");
            str = str.Replace("v", "*");
            str = str.Replace("w", "*");
            str = str.Replace("x", "*");
            str = str.Replace("y", "*");
            str = str.Replace("z", "*");
            str = str.Replace("ä", "*");
            str = str.Replace("ö", "*");
            str = str.Replace("ü", "*");
            Console.ResetColor();
            Console.Clear();

            //Singleplayer Game Loop



            while (0 < str.Length)
            {
                Console.Clear();
                Console.WriteLine("Word: " + str + " | " + hearts + " ♥ ♥ ♥");
                Console.WriteLine(player + " Guess the word");

                string playerinput = Launcher.GetUserInput(" > ").ToLower();
                if (playerinput.Length == 1)
                {
                    bool found = false;
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (realstr[i] == playerinput[0])
                        {
                            str = str.Substring(0, i) + realstr[i] + str.Substring(i + 1);
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        hearts--;
                    }
                }
                else if (playerinput == realstr)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"                  __    __                _ \r\n/\\_/\\___  _   _  / / /\\ \\ \\___  _ __     / \\\r\n\\_ _/ _ \\| | | | \\ \\/  \\/ / _ \\| '_ \\   /  /\r\n / \\ (_) | |_| |  \\  /\\  / (_) | | | | /\\_/ \r\n \\_/\\___/ \\__,_|   \\/  \\/ \\___/|_| |_| \\/   \r\n                                            {Environment.NewLine}");
                    Console.WriteLine($"{Environment.NewLine}" + player + " has won the round");
                    Console.ResetColor();
                    break;
                }
                else
                {
                    hearts--;
                }


                if(0 == hearts)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"                    __                  _ \r\n/\\_/\\___  _   _    / /  ___  ___  ___  / \\\r\n\\_ _/ _ \\| | | |  / /  / _ \\/ __|/ _ \\/  /\r\n / \\ (_) | |_| | / /__| (_) \\__ \\  __/\\_/ \r\n \\_/\\___/ \\__,_| \\____/\\___/|___/\\___\\/   \r\n                                          {Environment.NewLine}");
                    Console.WriteLine($"{Environment.NewLine}" + "CPU has won the round");
                    Console.ResetColor();
                    break;
                }
                if (0 >= hearts)
                {

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("                    __                    _ \r\n/\\_/\\___  _   _    / /  ___  ___  ___    / \\\r\n\\_ _/ _ \\| | | |  / /  / _ \\/ __|/ _ \\  /  /\r\n / \\ (_) | |_| | / /__| (_) \\__ \\  __/ /\\_/ \r\n \\_/\\___/ \\__,_| \\____/\\___/|___/\\___| \\/   \r\n                                            ");
                    Console.ResetColor();
                    Console.WriteLine(player + $" lost{Environment.NewLine}The word was: " + realstr + $"{Environment.NewLine}");
                    break;
                }
                else if (str == realstr)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"                  __    __                _ \r\n/\\_/\\___  _   _  / / /\\ \\ \\___  _ __     / \\\r\n\\_ _/ _ \\| | | | \\ \\/  \\/ / _ \\| '_ \\   /  /\r\n / \\ (_) | |_| |  \\  /\\  / (_) | | | | /\\_/ \r\n \\_/\\___/ \\__,_|   \\/  \\/ \\___/|_| |_| \\/   \r\n                                            {Environment.NewLine}");
                    Console.WriteLine($"{Environment.NewLine}" + player + " has won the round");
                    Console.ResetColor();
                    break;
                }
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
