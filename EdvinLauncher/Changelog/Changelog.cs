using index;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnoeyeLauncher.Changelog
{
    internal class Changelog
    {

        public static void ChangelogStart()
        {
            Console.Clear();
            Console.WriteLine("   ___ _                            _             \r\n  / __\\ |__   __ _ _ __   __ _  ___| | ___   __ _ \r\n / /  | '_ \\ / _` | '_ \\ / _` |/ _ \\ |/ _ \\ / _` |\r\n/ /___| | | | (_| | | | | (_| |  __/ | (_) | (_| |\r\n\\____/|_| |_|\\__,_|_| |_|\\__, |\\___|_|\\___/ \\__, |\r\n                         |___/              |___/ ");
            Console.WriteLine("Adding NIM-Game");
            Console.WriteLine("Adding Hangman Game");
            Console.WriteLine("Fixed Bugs in NIM-Game and Hangman\nHangman and NIM now working properly\n");

            Console.WriteLine("In the next Release:");
            Console.WriteLine("aMatrix | screensaver animation\n \nPress [Any Key] to go to the main menu!");
            switch (Console.ReadKey().KeyChar)
            {
                default:
                    Launcher.Main();
                    break;

            }
        }

    }
}
