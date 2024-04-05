using index;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnoeyeLauncher.Hangman
{
    internal class Hangman
    {

        public static void HangMan()
        {
            Console.Clear();
            HangmanAscii("");
            Launcher.SelectionOption("1", "", " Singleplayer");
            Launcher.SelectionOption("2", "", " Multiplayer");
            Launcher.SelectionOption("Q", "", " Exit to Main Menu");
            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    Singleplayer.SingleplayerStart();
                    break;
                case '2':
                    Multiplayer.MultiplayerStart();
                    break;
                case 'Q':
                    Launcher.Main();
                    break;
                case 'q':
                    Launcher.Main();
                    break;
                default:
                    Hangman.HangMan();
                    break;
            }

        }

        //Hangman Assets

        public static void HangmanAscii(string ascii)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("                                               \r\n  /\\  /\\__ _ _ __   __ _ _ __ ___   __ _ _ __  \r\n / /_/ / _` | '_ \\ / _` | '_ ` _ \\ / _` | '_ \\ \r\n/ __  / (_| | | | | (_| | | | | | | (_| | | | |\r\n\\/ /_/ \\__,_|_| |_|\\__, |_| |_| |_|\\__,_|_| |_|\r\n                   |___/                       ");
            Console.ResetColor();
        }

    }
}
