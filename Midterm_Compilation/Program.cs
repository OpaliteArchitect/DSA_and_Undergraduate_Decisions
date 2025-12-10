using Midterm_Compilation.Activities;
using static Midterm_Compilation.PolishUI;

namespace Midterm_Compilation
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() => MonitorMonitor()); 
            Console.CursorVisible = false; 
            ResetColor();

            while (true)
            {
                MainMenu();
            }
        }

        static void MainMenu()
        {
            Console.Clear();

            string menuText =
    "MIDTERM COMPILATION\n\n" +
    "[1] Activities, including Stack + Queue\n\n" +
    "[2] Animals\n\n" +
    "[3] Undergraduate_decisions\n" +
    "(For 3, set console to maximum size.)\n" +
    "(May not display properly on smaller screens)\n\n" +
    "\nMade by: Lastname, Firstname\nSection  School Year";

            int boxWidth = 60;
            int boxHeight = 17;
            int boxX = (Console.WindowWidth - boxWidth) / 2;
            int boxY = (Console.WindowHeight - boxHeight) / 2;

            // Draw the box
            DrawBox(boxX, boxY, boxWidth, boxHeight);

            // Calculate text start position (centered within box)
            int textX = boxX + 2;
            int textY = boxY + 2;

            // Write each line centered within the box
            string[] lines = menuText.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                Console.ForegroundColor = i switch
                {
                    0 => ConsoleColor.Magenta,
                    //4 or 6 or 7 => ConsoleColor.Yellow,
                    7 or 8 => ConsoleColor.DarkGray, //3 info
                    11 or 12 => ConsoleColor.White,
                    _ => ConsoleColor.Yellow
                };

                int lineX = textX + (boxWidth - 4 - lines[i].Length) / 2;
                Console.SetCursorPosition(lineX, textY + i);
                Console.Write(lines[i]);
            }
            ResetColor();

            ConsoleKeyInfo choice;
            do
            {
                choice = Console.ReadKey(true);
            } while (choice.KeyChar < '1' || choice.KeyChar > '3');

            Console.Clear();

            switch (choice.KeyChar)
            {
                case '1':
                    ActivitiesMenu();
                    break;
                case '2':
                    ShowLoadingScreen();
                    Classes_Animals.Classes_Animals.Run();
                    break;
                case '3':
                    ShowLoadingScreen();
                    UndergraduateDecisions.Undergraduate_decisions.Run();
                    break;
            }

            if (choice.KeyChar != '1') ShowLoadingScreen();
        }



        static void ActivitiesMenu()
        {
            Console.Clear();

            string menuText =
    "Open:\n\n" +
    "[1] Activity 1-1\n\n" +
    "[2] Activity 1-2\n\n" +
    "[3] Activity 1-3\n\n" +
    "[4] Activity 2-1 & 2-2\n\n" +
    "[5] Activity 3-1\n\n" +
    "[6] Activity 3-2\n\n" +
    "[7] Stack\n\n" +
    "[8] Queue\n\n" +
    "[9] Go back\n\n" +
    "\nMade by: Lastname, Firstname\nSection  School Year";


            int boxWidth = 50;
            int boxHeight = 27;
            int boxX = (Console.WindowWidth - boxWidth) / 2;
            int boxY = (Console.WindowHeight - boxHeight) / 2;

            // Draw the box
            DrawBox(boxX, boxY, boxWidth, boxHeight);

            // Calculate text start position (centered within box)
            int textX = boxX + 2;
            int textY = boxY + 2;

            // Write each line centered within the box
            string[] lines = menuText.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                Console.ForegroundColor = i switch
                {
                    0 => ConsoleColor.Magenta,
                    // 14 => ConsoleColor.DarkMagenta, stack
                    // 16 => ConsoleColor.Magenta, queue
                    18 => ConsoleColor.DarkGray,
                    21 or 22 => ConsoleColor.White,
                    _ => ConsoleColor.Yellow
                };

                int lineX = textX + (boxWidth - 4 - lines[i].Length) / 2;
                Console.SetCursorPosition(lineX, textY + i);
                Console.Write(lines[i]);
            }
            ResetColor();

            ConsoleKeyInfo choice;
            do
            {
                choice = Console.ReadKey(true);
            } while (choice.KeyChar < '1' || choice.KeyChar > '9');

            Console.Clear();

            ShowLoadingScreen();


            switch (choice.KeyChar)
            {
                case '1':
                    Activity1_1.Run();
                    break;
                case '2':
                    Activity1_2.Run();
                    break;
                case '3':
                    Activity1_3.Run();
                    break;
                case '4':
                    Activity2_1_2_2.Run();
                    break;
                case '5':
                    Activity3_1.Run();
                    break;
                case '6':
                    Activity3_2.Run();
                    break;
                case '7':
                    Stack.Run();
                    break;
                case '8':
                    Queue.Run();
                    break;
                case '9':
                    MainMenu();
                    return;
                default:
                    break;
            }

            if (choice.KeyChar <= '6') PressEnter();

            if (choice.KeyChar != '9') ShowLoadingScreen();

            MainMenu();
        }
    }
}
