using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Xpense
{
    class ConsoleOperations
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        public static void CloseConsole()
        {
            var handle = GetConsoleWindow();
            // Hide
            Console.Clear();
            ShowWindow(handle, SW_HIDE);
            ProgramVariables.CurrentConsoleState = false;
        }
        public static void ShowConsole()
        {
            var handle = GetConsoleWindow();
            // Show
            ShowWindow(handle, SW_SHOW);
            ProgramVariables.CurrentConsoleState = true;
        }







        public static void WriteConsoleColorGreen(string text, bool space = false)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (space) Console.WriteLine();
            Console.WriteLine(text);
            Console.WriteLine();
            Console.ResetColor();
        }


        public static void WriteConsoleColorRed(string text, bool space = false)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (space) Console.WriteLine();
            Console.WriteLine(text);
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void WriteConsoleErrors(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ResetColor();
            Console.WriteLine("");
        }




        public static void ReadConsoleCommands()
        {
            // citeste cate comenzi vor fi adaugate si le adauga intr-o lista ; de asemenea verifica daca o comanda e gresita sau nu exista si precizeaza acest lucru , cerand o modificare
            WriteConsoleColorGreen("Please type the number of commands you want to enter !", true);
            int numberOfCommands = Convert.ToInt32(Console.ReadLine());
            WriteConsoleColorGreen("Please confirm that you will type " + numberOfCommands + " commands, each one on a different line ! [y/n]", true);
            if (Console.ReadLine() == "y")
            {
                WriteConsoleColorGreen("Start typing your commands !", true);
                List<string> commands = new List<string>();
                while (numberOfCommands-- > 0)
                {
                    commands.Add(Console.ReadLine());
                }
                WriteConsoleColorGreen("Finished ! You will now be prompted to modify any commands if you wrote a wrong one ! Please be patient !", true);
                WriteConsoleColorGreen("Processing ...");


                // verifica daca comenzile sunt valide
                for (int i = 0; i <= commands.Count; i++)
                {
                    if (commands[i] == "display variables values")
                    {
                        Console.WriteLine("okay");
                    }
                    else if (commands[i] == "show entered commands")
                    {
                        for (int j = 0; j < commands.Count; j++) Console.Write(commands[j]);
                    }
                    else
                    {
                        WriteConsoleColorRed("Sorry , the command  " + commands[i] + " does not exist ! Do you want to modify it ? [y/n]");
                        if (Console.ReadLine() == "y") WriteConsoleColorGreen("Please type what command you want to be used instead of the wrong one !", true);
                        commands[i] = Console.ReadLine();
                    }
                }

            }
        }


        public static bool VerifyCommand(string command)
        {
            // functie pentru a verifica daca comenzile sunt valide
            return false;
        }

























        public static void ExecuteConsoleCommands(string command = "")
        {

        }

    }
}
