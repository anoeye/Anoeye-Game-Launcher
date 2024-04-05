using AnoeyeLauncher.aMatrix;
using AnoeyeLauncher.Changelog;
using AnoeyeLauncher.Hangman;
using AnoeyeLauncher.NIM;
using System;

namespace index
{

    class Launcher
    {
        //Launcher interface
        public static void Main()
        {

            //HeadLine
            Console.Clear();
            Console.SetWindowSize(82, 15);
            VersionNumber("");
            Headline("");
            Console.Write("\n");
            SelectionOption("1", "", " NIM-Game");
            SelectionOption("2", "", " Hangman Game");
            SelectionOption("3", "", " aMatrix");
            SelectionOption("Q", "", " Exit\n");

            SelectionOption("#", "", "Changelog");
            Console.ForegroundColor = ConsoleColor.Gray;
            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    Console.Clear();
                    NIM.NIMStart();
                    break;
                case '2':
                    Console.Clear();
                    Hangman.HangMan();
                    break;
                case '3':
                    Console.Clear();
                    aMatrix.AMatrix();
                    break;
                case '#':
                    Console.Clear();
                    Changelog.ChangelogStart();
                    break;
                case 'Q':
                    break;
                case 'q':
                    break;
                default:
                    Launcher.Main();
                    break;
            }

        }

        //Launcher Assets
        
        private static void Headline(string logo)
        {

            //MOTS (Message of the Session)
            var random = new Random();

            var list = new List<string>{ "Is this tha message of da session?",
                             "Made by Anoeye (obviously)",
                             "https://anoeye.xyz/  https://github.com/anoeye"};
            int index = random.Next(list.Count);

            string mots = list[index];

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("   _                                   __                        _               \r\n  /_\\  _ __   ___   ___ _   _  ___    / /  __ _ _   _ _ __   ___| |__   ___ _ __ \r\n //_\\\\| '_ \\ / _ \\ / _ \\ | | |/ _ \\  / /  / _` | | | | '_ \\ / __| '_ \\ / _ \\ '__|\r\n/  _  \\ | | | (_) |  __/ |_| |  __/ / /__| (_| | |_| | | | | (__| | | |  __/ |   \r\n\\_/ \\_/_| |_|\\___/ \\___|\\__, |\\___| \\____/\\__,_|\\__,_|_| |_|\\___|_| |_|\\___|_|   \r\n                        |___/ " + mots);

        }


        //Public Functions

        //Options for Menus

        public static void SelectionOption(string option, string text, string mode, ConsoleColor color = ConsoleColor.DarkYellow)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(" [");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(option);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("]");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(mode);
            Console.Write("\n");
            Console.ResetColor();
        }

        //Input for (names) or (costum text) for example

        public static string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            string read = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(read))
            {
                Console.WriteLine("Invalid Input / Please try again");
                return GetUserInput(prompt);
            }

            return read;
        }

        //Inut for (numbers) to calculate for example

        public static int GetUserNumber(string prompt)
        {
            Console.Write(prompt);
            string read = Console.ReadLine();
            if (!int.TryParse(read, out int number))
            {
                Console.WriteLine("Invalid Input / Please try again");
                return GetUserNumber(prompt);
            }
            return number;
        }

        //Bool selection (y/n) with anti crasher

        public static bool GetUserYesOrNo(string prompt)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                var key = Console.ReadKey(true);
                if(key.Key == ConsoleKey.Y)
                {
                    return true;
                }
                if(key.Key == ConsoleKey.N)
                {
                    return false;
                }
            }
        }

        public static void VersionNumber(string version)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("ver. 0.2 beta");
            Console.ResetColor();
        }

    }

}