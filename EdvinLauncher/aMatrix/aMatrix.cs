using index;
using System.ComponentModel;

namespace AnoeyeLauncher.aMatrix
{
    internal class aMatrix
    {

        public static void AMatrix()
        {
            AMatrixLogo("");
            Console.ForegroundColor = ConsoleColor.Green;
            Launcher.SelectionOption("1", "", " Start aMatrix");
            Launcher.SelectionOption("Q", "", " Exit to Main Menu");
            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    Console.WriteLine("Coming Soon");
                    System.Threading.Thread.Sleep(2000);
                    Launcher.Main();
                    break;
                case 'Q':
                    Launcher.Main();
                    break;
                case 'q':
                    Launcher.Main();
                    break;
            }
        }

        //aMatrix Assets

        public static void AMatrixLogo(string logo)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                    _        _      \r\n  __ _  /\\/\\   __ _| |_ _ __(_)_  __  Hello Traveler! Right now you may think:\r\n / _` |/    \\ / _` | __| '__| \\ \\/ /  'What is aMatrix?' its a famous Console\r\n| (_| / /\\/\\ \\ (_| | |_| |  | |>  <   Animation! Try it out!\r\n \\__,_\\/    \\/\\__,_|\\__|_|  |_/_/\\_\\\r\nThis function is not available yet! will come in the next update!                                    ");
            Console.ResetColor();
        }

    }
}
