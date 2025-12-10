using static Midterm_Compilation.PolishUI;

namespace Undergraduate_decisions.UI
{
    public static class Dimensions
    {
        private static Random rnd = new();
        public static sbyte[] dimensions = new sbyte[4];
        public static readonly string[] dimensionNames = ["Academic", "Mental", "Financial", "Social"];
        public static bool ownsOracle { get; set; } = false;
        public static string gameOverDialogue = "";

        public static void Initialize()
        {
            for (int i = 0; i < 4; i++)
            {
                dimensions[i] = (sbyte)(rnd.Next(12, 14));
                dimensions[i] = (sbyte)(rnd.Next(12, 14));
            }
        }

        public static void ImpactDimensions(sbyte[] impacts)
        {
            if (impacts[2] == -15) { if (AttemptUnlockOracle()) ownsOracle = true; }
            for (int i = 0; i < 4; i++)
            {
                dimensions[i] += impacts[i];
            }
        }

        private static string CalculateQuintile(sbyte dim)
        {
            return dim > 20 ? "Very high" : dim > 15 ? "High" : dim > 10 ? "Average" : 
                dim > 5 ? "Low" : "Very Low";
        }

        private static bool AttemptUnlockOracle()
        {
            bool failed = false;
            for (int i = 0; i < 4; i++)
            {
                if (i == 2)
                {
                    if (dimensions[i] <= 15) failed = true;
                }
                else
                {
                    if (dimensions[i] <= 10) failed = true;
                }
            }
            return !failed;
        }

        /*public static void DisplayDimensions()
        {
            for (int i = 0; i < 4; i++)
            {
                if (ownsOracle) Console.WriteLine($"{dimensionNames[i]}: {dimensions[i] * 4}%\n");
                else Console.WriteLine($"{dimensionNames[i]}: {CalculateQuintile(dimensions[i])}\n");
            }
        }*/

        public static void DisplayDimensions()
        {// Define box dimensions and position
            int boxX = 0;
            int boxY = 0;
            int boxWidth = 28;
            int boxHeight = 6;

            // Draw the box
            DrawBox(boxX, boxY, boxWidth, boxHeight, ConsoleColor.Gray);

            // Write content inside the box
            for (int i = 0; i < dimensionNames.Length; i++)
            {
                SafeSetCursorPosition(boxX + 2, boxY + 1 + i);

                if (ownsOracle)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{dimensionNames[i]}: {dimensions[i] * 4}%");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{dimensionNames[i]}: {CalculateQuintile(dimensions[i])}");
                }
                ResetColor();
            }
        }
        public static bool DimensionsDeficiency()
        {
            int index = Array.FindIndex(dimensions, d => d < 1);
            if (index != -1)
            {
                Console.Clear();
                switch (index)
                {
                    case 0:
                        gameOverDialogue =
                            "You receive an official notice of dismissal from the registrar." +
                            "Your grades have fallen below the institution's minimum " +
                            "requirements. All current courses are invalidated, and campus access is revoked. " +
                            "Any pending credits are forfeited. The dismissal is permanently noted on your " +
                            "academic record. Re-admission is prohibited for at least five years. " +
                            "Your academic trajectory ends here."; break;
                    case 1:
                        gameOverDialogue =
                            "The pressures became unbearable. You withdrew entirely into self-destructive " +
                            "habits: substance abuse, sleepless nights in arcades or bars, and vanishing for " +
                            "days. When found, you reject all help. The university declares you \"academically " +
                            "and emotionally disengaged,\" and processes your dismissal for " +
                            "\"non-participation.\" You leave without protest, numb to the outcome.";
                            break;
                    case 2:
                        gameOverDialogue =
                            "Your financial strains caused you to take high-interest loans to survive. When " +
                            "the debt just kept stacking, you disappear from public life. Years later, " +
                            "your body is found in a motel, surrounded by collection notices.";
                            break;
                    case 3:
                        gameOverDialogue =
                            "Rumors made you untouchable.You eat alone, study alone, and are met with " +
                            "silence when you speak. You've become a social pariah. Eventually, you can't " +
                            "take it anymore. You leave the university, never to be seen again.";
                        break;
                    default: break;
                }
                DisplayGameOverDialogue();
            }
            ; 
            return index == -1;
        }
        public static bool DimensionsExcess()
        {
            int index = Array.FindIndex(dimensions, d => d > 25);
            if (index != -1)
            {
                Console.Clear();
                switch (index)
                {
                    case 0:
                        gameOverDialogue =
                            "Your obsessive focus on perfect grades led to severe burnout. " +
                            "You collapsed during finals and were hospitalized. The university dismisses you " +
                            "on medical grounds, stating your health is incompatible with their academic " +
                            "demands. Your record shows \"medical withdrawal\" – a permanent mark of excess.";
                        break;
                    case 1:
                        gameOverDialogue =
                            "Your happiness escalates into reckless optimism. You impulsively skip classes to " +
                            "chase fleeting joys—spontaneous travel, extravagant purchases, and constant parties. " +
                            "You dismiss deadlines as \"irrelevant to joy.\" Academic performance collapses. The " +
                            "university intervenes after you attempt to host a carnival in the lecture hall. " +
                            "Dismissed for \"disruptive behavior and academic negligence.\"";
                        break;
                    case 2:
                        gameOverDialogue =
                            "You flaunt your wealth excessively—leasing sports cars to block campus driveways, " +
                            "replacing library books with personalized gold-leaf editions, and offering " +
                            "students cash to perform humiliating acts. The university dismisses you for " +
                            "\"corrupting the academic environment.\" Your legacy becomes a cautionary tale of " +
                            "toxic privilege.";
                        break;
                    case 3:
                        gameOverDialogue = "Your calendar is flooded with invites." +
                            "You’re everyone’s favorite person, and even TikTok-famous, but exams become an " +
                            "afterthought. You prioritized daily posts, hanging out, dropping subjects " +
                            "from sheer absence. You stopped complying with academic requirements. " +
                            "Your reputation thrives, but you're educationally bankrupt.";
                        break;
                    default: break;
                }
                DisplayGameOverDialogue();
            }
            return index == -1;
        }

        public static void DisplayGameOverDialogue()
        {
            gameOverDialogue += "\nPress Enter to continue";
            WriteAndBox(gameOverDialogue, windowsWidth, 10, ConsoleColor.Red);

			ConsoleKeyInfo choice;
			do
			{
				choice = Console.ReadKey(true);
			} while (choice.Key != ConsoleKey.Enter);

			Console.Clear();
		}
    }
}
