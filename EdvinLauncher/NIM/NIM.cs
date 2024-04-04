using index;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnoeyeLauncher.NIM
{
    internal class NIM
    {

        public static void NIMStart()
        {

            NIMAscii("");
            Launcher.SelectionOption("1", "", "Singleplayer");
            Launcher.SelectionOption("2", "", "Multiplayer");
            Launcher.SelectionOption("Q", "", "Exit to Main Menu");
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
            }

        }

        public static void NIMAscii(string ascii)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("     __ _____               ___                     \r\n  /\\ \\ \\\\_   \\/\\/\\         / _ \\__ _ _ __ ___   ___ \r\n /  \\/ / / /\\/    \\ _____ / /_\\/ _` | '_ ` _ \\ / _ \\\r\n/ /\\  /\\/ /_/ /\\/\\ \\_____/ /_\\\\ (_| | | | | | |  __/\r\n\\_\\ \\/\\____/\\/    \\/     \\____/\\__,_|_| |_| |_|\\___|\r\n                                                    ");
            Console.ResetColor();
        }

    }
}
