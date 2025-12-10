using System.Runtime.CompilerServices;

namespace Midterm_Compilation
{
    internal static class PolishUI
    {
        public static int windowsWidth = Console.WindowWidth;
        public static int windowsHeight = Console.WindowHeight;
        private static string asciiArt = @"
  ____   ____ _ _ __  _ __   __ _ 
 / __ \ / __ | '_ \ \| '_ \ / _` |
| |  | | |  | | | | | | | | (_| |
| |__| | |__| | | | | | | | (_| |
 \____/ \____|_| |_|_|_| |_|\__,_|
";

        public static void MonitorMonitor()
        {
            while (true)
            {
                if (windowsWidth != Console.WindowWidth || windowsHeight != Console.WindowHeight)
                {
                    windowsWidth = Console.WindowWidth;
                    windowsHeight = Console.WindowHeight;
                }
                Thread.Sleep(500);
            }
        }

        public static void WriteWithMargins(string text, int maxLineWidth, 
            int leftMargin = 3, int rightMargin = 3)
        {
            string[] paragraphs = text.Split('\n');
            int availableWidth = maxLineWidth - leftMargin - rightMargin;

            foreach (string paragraph in paragraphs)
            {
                int startIndex = 0;
                string trimmedPara = paragraph.Trim();

                while (startIndex < trimmedPara.Length)
                {
                    int length = Math.Min(availableWidth, trimmedPara.Length - startIndex);
                    string line = trimmedPara.Substring(startIndex, length);

                    if (length == availableWidth && !char.IsWhiteSpace(trimmedPara[startIndex + length - 1]))
                    {
                        int lastSpace = line.LastIndexOf(' ');
                        if (lastSpace > 0)
                        {
                            length = lastSpace + 1;
                            line = trimmedPara.Substring(startIndex, length);
                        }
                    }

                    Console.Write(new string(' ', leftMargin));
                    Console.WriteLine(line.Trim());
                    startIndex += length;
                }

                Console.Write('\t');
            }
        }
        public static void DrawBox(int x, int y, int width, int height, ConsoleColor borderColor = ConsoleColor.DarkGray,
            sbyte compartments = 1, params int[] partAt)
        {
            if (x >= windowsWidth || y >= windowsHeight) return; // Skip drawing if no space

            ResetColor();
            Console.ForegroundColor = borderColor;

            // Top border - only draw border characters
            SafeSetCursorPosition(x, y);
            Console.Write("┌");
            SafeSetCursorPosition(x + width - 1, y);
            Console.Write("┐");

            // Draw top horizontal line without overwriting content
            for (int i = x + 1; i < x + width - 1; i++)
            {
                SafeSetCursorPosition(i, y);
                Console.Write('─');
            }

            // Side borders - only draw at edges
            for (int i = y + 1; i < y + height - 1; i++)
            {
                SafeSetCursorPosition(x, i);
                Console.Write("│");
                SafeSetCursorPosition(x + width - 1, i);
                Console.Write("│");
            }

            // Horizontal dividers
            for (sbyte comp = 1; comp < compartments; comp++)
            {
                int dividerY = y + partAt[comp - 1];
                SafeSetCursorPosition(x, dividerY);
                Console.Write("├");
                SafeSetCursorPosition(x + width - 1, dividerY);
                Console.Write("┤");
                for (int i = x + 1; i < x + width - 1; i++)
                {
                    SafeSetCursorPosition(i, dividerY);
                    Console.Write('─');
                }
            }

            // Bottom border
            SafeSetCursorPosition(x, y + height - 1);
            Console.Write("└");
            SafeSetCursorPosition(x + width - 1, y + height - 1);
            Console.Write("┘");
            for (int i = x + 1; i < x + width - 1; i++)
            {
                SafeSetCursorPosition(i, y + height - 1);
                Console.Write('─');
            }

            ResetColor();
        }
        public static void SafeSetCursorPosition(int x, int y)
        {
            if (x < 0 || x >= Console.WindowWidth) return;
            if (y < 0 || y >= Console.WindowHeight) return;
            Console.SetCursorPosition(x, y);
        }

        public static void WriteAndBox(string text, int width, int height, int x = 0, int y = 0)
        {
            Console.WriteLine();
            WriteWithMargins(text, width);
            DrawBox(x, y, width, height, ConsoleColor.Red);
        }
        public static void WriteAndBox(string text, int width, int height, ConsoleColor textColor, 
            ConsoleColor backColor = ConsoleColor.Black)
        {
            Console.WriteLine();
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backColor;
            WriteWithMargins(text, width);
            DrawBox(0, 0, width, height, ConsoleColor.Red);
        }
        public static void DisplayInBox(string content)
        {
            Console.Clear();
            string[] lines = content.Split('\n');
            int longestLineLength = 0;
            foreach (string line in lines)
            {
                if (line.Length > longestLineLength)
                {
                    longestLineLength = line.Length;
                }
            }

            const int horizontalPadding = 4;
            const int verticalPadding = 2;
            int menuWidth = longestLineLength + horizontalPadding;
            int menuHeight = lines.Length + verticalPadding;
            int leftPadding = (windowsWidth - menuWidth) / 2;
            int topPadding = (windowsHeight - menuHeight) / 2;

            DrawBox(leftPadding, topPadding, menuWidth, menuHeight);

            for (int i = 0; i < lines.Length; i++)
            {
                SafeSetCursorPosition(leftPadding + horizontalPadding / 2, topPadding + 1 + i);
                Console.Write(lines[i]);
            }
        }

        public static void PressEnter()
        {
            Console.Write("\nPress enter to continue");

            ConsoleKeyInfo choice;
            do
            {
                choice = Console.ReadKey(true);
            } while (choice.Key != ConsoleKey.Enter);

            Console.Clear();
        }

        public static void ResetColor()
        {
            Console.ForegroundColor = ConsoleColor.Magenta; Console.BackgroundColor = default;
        }
        /*
        public static void ShowLoadingScreen(string message = "Loading", int durationInMs = 1000)
        {
            string[] frames = { "—", "\\", "|", "/" };
            string asciiArt = @"
  ____   ____ _ _ __  _ __   __ _ 
 / __ \ / __ | '_ \ \| '_ \ / _` |
| |  | | |  | | | | | | | | (_| |
| |__| | |__| | | | | | | | (_| |
 \____/ \____|_| |_|_|_| |_|\__,_|
";

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(asciiArt);
            ResetColor();
            Console.WriteLine("\n\n" + message);

            int totalTicks = 20;
            int interval = durationInMs / totalTicks;
            int frameIndex = 0;

            for (int i = 0; i < totalTicks; i++)
            {
                Console.CursorLeft = 0;
                Console.Write($"Loading... {frames[frameIndex]} ");
                frameIndex = (frameIndex + 1) % frames.Length;

                for (int j = 0; j <= i; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("█");
                }
                ResetColor();

                Thread.Sleep(interval);
            }

            Console.Clear();
        }*/
        public static void ShowLoadingScreen(int durationInMs = 1000, string message = "")
        {

            Console.CursorVisible = false;
            Console.Clear();
            string asciiArt = @"
  _                     _ _                        _____  
 | |                   | (_)              ______  |  __ \ 
 | |     ___   __ _  __| |_ _ __   __ _  |______| | |  | |
 | |    / _ \ / _` |/ _` | | '_ \ / _` |  ______  | |  | |
 | |___| (_) | (_| | (_| | | | | | (_| | |______| | |__| |
 |______\___/ \__,_|\__,_|_|_| |_|\__, |          |_____/ 
                                   __/ |                  
                                  |___/                   
";

            string[] lines = asciiArt.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int longestLineLength = 0;
            foreach (string line in lines)
            {
                if (line.Length > longestLineLength)
                {
                    longestLineLength = line.Length;
                }
            }

            int contentWidth = longestLineLength;
            int contentHeight = lines.Length;

            // Calculate the starting position for the ASCII art
            int startX = (Console.WindowWidth - contentWidth) / 2;
            int startY = (Console.WindowHeight - (contentHeight + 2)) / 2;

            // Draw the ASCII art
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < lines.Length; i++)
            {
                Console.SetCursorPosition(startX, startY + i);
                Console.Write(lines[i]);
            }
            ResetColor();

            // Position for the loading message and progress bar
            int progressY = startY + contentHeight + 1;

            string[] frames = { "—", "\\", "|", "/" };
            int totalTicks = 20;
            int interval = durationInMs / totalTicks;
            int frameIndex = 0;

            for (int i = 0; i < totalTicks; i++)
            {
                Console.SetCursorPosition(startX, progressY);
                Console.Write($" {message} ");

                Console.SetCursorPosition(startX + message.Length + 1, progressY);
                Console.Write($"{frames[frameIndex]} ");

                frameIndex = (frameIndex + 1) % frames.Length;

                for (int j = 0; j <= i; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    for (int k = 0; k < contentWidth / 20; k++)
                    Console.Write("█");
                }
                ResetColor();

                Thread.Sleep(interval);
            }

            Console.Clear();
        }
    }
}
