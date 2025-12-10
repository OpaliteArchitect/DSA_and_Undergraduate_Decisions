using Undergraduate_decisions.UI;
using Undergraduate_decisions.StoryEventInstances.Type1;
using Undergraduate_decisions.StoryEventInstances.Type2;
using Undergraduate_decisions.StoryEventInstances.Type3;
using static Midterm_Compilation.PolishUI;

namespace UndergraduateDecisions
{
    public static class Undergraduate_decisions
    {
        public static void Run()
        {
            RandomFillerGetter.Initialize();
            RandomStatusEffectsGetter.Initialize();
            CanonGetter.Initialize();

            ConsoleKeyInfo choice;
            do
            {
                MainMenu();

                do
                {
                    choice = Console.ReadKey(true);
                } while (choice.KeyChar != '1' && choice.KeyChar != '2');

                if (choice.KeyChar == '1') StoryEventDisplay.NewGame();
            } while (choice.KeyChar != '2');
        }

        private static void MainMenu()
        {
            // Clear console and set colors
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            // Calculate centered positions
            int centerX = Console.WindowWidth / 2;
            int centerY = Console.WindowHeight / 2;

            // Draw title box
            int titleWidth = 40;
            int titleX = centerX - titleWidth / 2;
            int titleY = centerY - 8;
            DrawBox(titleX, titleY, titleWidth, 3, ConsoleColor.DarkYellow);

			// Display title
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(centerX - "UNDERGRADUATE DECISIONS".Length / 2, titleY + 1);
            Console.WriteLine("UNDERGRADUATE DECISIONS");

            // Draw menu box
            int menuWidth = 30;
            int menuX = centerX - menuWidth / 2;
            int menuY = centerY - 2;
            DrawBox(menuX, menuY, menuWidth, 7, ConsoleColor.DarkGray);

            // Menu options
            Console.ForegroundColor = ConsoleColor.Yellow;

			Console.SetCursorPosition(menuX + 8, menuY + 2);
            Console.WriteLine("[1] Start Game");
            Console.SetCursorPosition(menuX + 8, menuY + 4);
            Console.WriteLine("[2] Exit");

            // Reset colors
            ResetColor();
        }
    }
}