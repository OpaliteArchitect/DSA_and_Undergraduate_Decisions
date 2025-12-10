using System.Reflection;
using Undergraduate_decisions.Classes;
using Undergraduate_decisions.UI;

namespace Undergraduate_decisions.StoryEventInstances.Type1
{
    internal static class RandomFillerGetter
    {
        private static List<OneTime> storyEventsList = [];
        static Random rnd = new();
        public static void Initialize()
        {
            storyEventsList.Clear();
            FieldInfo[] fields = typeof(Fillers)
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(field => field.FieldType == typeof(OneTime))
                .ToArray();

            foreach (FieldInfo field in fields)
            {
                OneTime value = (OneTime)field.GetValue(null);
                if (value != null)
                    storyEventsList.Add(value);
            }
        }

        public static OneTime GetStoryEvent()
        {
            return (rnd.Next(100) < 2 && (!Dimensions.ownsOracle) 
                ? storyEventsList[storyEventsList.Count - 1] 
                : storyEventsList[rnd.Next(storyEventsList.Count - 1)]);
        }
    }
}
