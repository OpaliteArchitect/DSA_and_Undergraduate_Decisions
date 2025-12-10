using static Midterm_Compilation.PolishUI;
using Undergraduate_decisions.Classes.Utilities;

namespace Undergraduate_decisions.Classes
{
    internal class StoryEvent
    {
        protected string name = "Name", description = "Description";
        public string Name { get { return name; } }
        protected Decision decision1 = new("First option", () => { });
        protected Decision decision2 = new("Second option", () => { });
        protected static readonly string[] dimensionNames = ["ACADEMIC", "MENTAL", "FINANCIAL", "SOCIAL"];
        public StoryEvent(string name, string description,
                          Decision decision1, Decision decision2)
        {
            this.name = name;
            this.description = description;
            this.decision1 = decision1;
            this.decision2 = decision2;
        }

        public void DisplayStoryEvent()
        {
            //Console.WriteLine($"\n{name}\n{description}\n\n[1] {decision1.Description}\n[2]
            //{decision2.Description}");
            int boxHeight = 12 + (description.Length / windowsWidth) * 2;

            SafeSetCursorPosition(2, 8);
            Console.ForegroundColor = name == "Oracle" ? ConsoleColor.Magenta 
                : this is OneTime ? ConsoleColor.Gray
                : this is Temporary ? ConsoleColor.DarkCyan
                : ConsoleColor.DarkYellow;
            Console.WriteLine(name);
            SafeSetCursorPosition(2, 10);
            Console.Write("\t");
            WriteWithMargins(description, windowsWidth - 5);
            SafeSetCursorPosition(2, boxHeight + 1);
            Console.Write("[1] ");
            WriteWithMargins(decision1.Description, windowsWidth - 5);
            SafeSetCursorPosition(2, boxHeight + 4);
            Console.Write("[2] ");
            WriteWithMargins(decision2.Description, windowsWidth - 5);

            ResetColor();
            DrawBox(0, 7, windowsWidth, boxHeight, name == "Oracle" ? ConsoleColor.Magenta:
                this is OneTime ? ConsoleColor.White : this is Temporary ? ConsoleColor.Cyan 
                : ConsoleColor.Yellow, 4, 2, boxHeight - 7, boxHeight - 4
                );
        }

        public void Decision(char choice)
        {
            switch (choice)
            {
                case '1':
                    decision1.Impact();
                    break;
                case '2':
                    decision2.Impact();
                    break;
            }
        }

    }
}
