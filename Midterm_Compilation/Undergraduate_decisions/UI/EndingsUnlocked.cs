using static Midterm_Compilation.PolishUI;

namespace Undergraduate_decisions.UI
{
    internal static class EndingsUnlocked
    {
        public static List<string> endingsUnlocked = [];

        public static void DisplayEndingsUnlocked()
        {
            //if (endingsUnlocked.Count == 0) return;

            int boxX = 67;
            int boxY = 0;
            int boxWidth = 60;
            int boxHeight = 6;
            int i = 0;
            // Draw the box
            DrawBox(boxX, boxY, boxWidth, boxHeight, ConsoleColor.Gray);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            SafeSetCursorPosition(boxX + 2, boxY + 1 + i++);
            Console.WriteLine("Endings Unlocked:");

            // Write content inside the box
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (string title in endingsUnlocked) {
                SafeSetCursorPosition(boxX + 2, boxY + 1 + i++);
                Console.WriteLine(title);
            }
            ResetColor();
        }
    }
}
