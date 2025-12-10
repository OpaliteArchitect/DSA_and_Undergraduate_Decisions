using Undergraduate_decisions.StoryEventInstances.Type1;
using Undergraduate_decisions.StoryEventInstances.Type2;
using Undergraduate_decisions.Classes;
using Undergraduate_decisions.StoryEventInstances.Type3;
using static Midterm_Compilation.PolishUI;

namespace Undergraduate_decisions.UI
{
    internal static class StoryEventDisplay
    {
        public static byte turn;
        public static bool endingReached;
        private static Random rnd = new();

        public static void NewGame()
        {
            ResetColor();
            Dimensions.Initialize();
            Status.Initialize();
            PendingStoryEvents.Initialize();
            turn = 0;
            endingReached = false;
            NewStoryEvent();
        }
        /*
        private static void CalculateWeek()
        {
            byte weeksPerTurn = 2;
            byte weeksPerYear = (byte)(51 / weeksPerTurn);
            Console.WriteLine(
                $"Year {turn / weeksPerYear + 1} " +
                $"Week {turn % weeksPerYear * weeksPerTurn + 1}\n"
                );
        }*/

        private static StoryEvent PickStoryEvent()
        {
            return (turn % 5 == 0) && (rnd.Next(2) == 0) ?
                RandomStatusEffectsGetter.GetStoryEvent()
                : RandomFillerGetter.GetStoryEvent();
        }

        private static void NewStoryEvent()
        {
            while (Dimensions.DimensionsDeficiency() && Dimensions.DimensionsExcess() && !endingReached)
            {
                Console.Clear();
                Dimensions.DisplayDimensions();
                Status.DisplayStatusInfo();
                EndingsUnlocked.DisplayEndingsUnlocked();

                StoryEvent newEvent = PendingStoryEvents.IncrementPages();

                if (newEvent is null)
                {
                    Status.ApplyStatuses();
                    newEvent = PickStoryEvent();
                }

                //CalculateWeek();

                newEvent.DisplayStoryEvent();

                ConsoleKeyInfo choice;
                do
                {
                    choice = Console.ReadKey(true);
                } while (choice.KeyChar != '1' && choice.KeyChar != '2');

                newEvent.Decision(choice.KeyChar);

                if (newEvent is not Canon) turn++;
            }
        }
    }
}
