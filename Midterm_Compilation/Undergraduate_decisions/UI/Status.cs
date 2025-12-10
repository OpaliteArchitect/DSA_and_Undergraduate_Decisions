using static Midterm_Compilation.PolishUI;
using Undergraduate_decisions.Classes.Utilities;

namespace Undergraduate_decisions.UI
{
    internal static class Status
    {
        private static List<Debuff> activeDebuffs = [];

        public static void Initialize()
        {
            activeDebuffs.Clear();
        }
        public static void DisplayStatusInfo()
        {
            DrawBox(30, 0, 35, 6, ConsoleColor.Gray);

            Console.SetCursorPosition(32, 1);
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Status effects affecting you: ");

            ResetColor();

            Console.SetCursorPosition(32, 2);
            Console.ForegroundColor = ConsoleColor.White;
            if (activeDebuffs.Count == 0) Console.Write("None");

            else {
                int x = 0;
                foreach (Debuff debuff in activeDebuffs)
                {
                    string name = debuff.name;
                    Console.ForegroundColor = "Class suspensionExaminations season".Contains(name) 
                        ? ConsoleColor.Green : "AnxietyDepressionBurnout".Contains(name)
                        ? ConsoleColor.Red : ConsoleColor.Yellow;
                    Console.SetCursorPosition(32, 2 + x++);
                    Console.WriteLine(name); 
                    ResetColor();
                }
            }

            ResetColor();
        }
        public static void ApplyStatuses()
        {
            foreach (Debuff debuff in activeDebuffs.ToList()) 
                // .ToList() iterates a copy to avoid modification during enumeration
            {
                debuff.ApplyDebuff();
            }
        }

        public static void CreateStatus(string name, sbyte[] impacts, sbyte turnsLeft)
        {
            activeDebuffs.Add(new Debuff(name, impacts, turnsLeft));
        }
        public static void RemoveStatus(Debuff debuff)
        {
            activeDebuffs.Remove(debuff);
        }
    }
}
