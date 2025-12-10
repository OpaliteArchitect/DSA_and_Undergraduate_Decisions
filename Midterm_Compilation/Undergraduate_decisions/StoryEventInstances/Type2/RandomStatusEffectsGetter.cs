using System.Reflection;
using Undergraduate_decisions.Classes;

namespace Undergraduate_decisions.StoryEventInstances.Type2
{
    internal class RandomStatusEffectsGetter
    {
        private static List<Temporary> storyEventsList = [];
        static Random rnd = new();
        public static void Initialize()
        {
            storyEventsList.Clear();
            FieldInfo[] fields = typeof(StatusEffects)
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(field => field.FieldType == typeof(Temporary))
                .ToArray();

            foreach (FieldInfo field in fields)
            {
                Temporary value = (Temporary)field.GetValue(null);
                if (value != null)
                    storyEventsList.Add(value);
            }
        }

        public static Temporary GetStoryEvent()
        {
            return storyEventsList[rnd.Next(storyEventsList.Count)];
        }
    }
}
