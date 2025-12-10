using Undergraduate_decisions.Classes;
using Undergraduate_decisions.Classes.Utilities;
using Undergraduate_decisions.StoryEventInstances.Type3;

namespace Undergraduate_decisions.UI
{
    internal static class PendingStoryEvents
    {
        private static List<ForcePage> forcePages = [];
        private static Canon immediateCanon;

        public static void Initialize()
        {
            forcePages.Clear();
            immediateCanon = CanonGetter.GetStoryEvent("firstday1");
        }

        public static Canon IncrementPages()
        {
            NextPage();
            foreach (ForcePage forcePage in forcePages.ToList())
            {
                if (forcePage.ReadyToTrigger())
                {
                    immediateCanon = CanonGetter.GetStoryEvent(forcePage.nextPageId);
                    RemovePage(forcePage);
                }
            }
            if (immediateCanon != null)
            {
                Canon canon = immediateCanon;
                RemoveImmediatePage();
                return canon;
            }
            return null;
        }

        public static void NextPage()
        {
            foreach (ForcePage forcePage in forcePages.ToList())
            {
                forcePage.DecrementTurn();
            }
        }
        public static void AddPage(string nextPageId, sbyte turns)
        {
            forcePages.Add(new ForcePage(nextPageId, turns));
        }
        public static void RemovePage(ForcePage forcePage)
        {
            forcePages.Remove(forcePage);
        }

        public static void AddImmediatePage(Canon _immediateCanon)
        {
            immediateCanon = _immediateCanon;
        }
        public static void RemoveImmediatePage()
        {
            immediateCanon = null;
        }
    }
}
