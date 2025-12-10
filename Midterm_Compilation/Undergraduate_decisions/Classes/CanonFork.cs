using Undergraduate_decisions.Classes.Utilities;
using Undergraduate_decisions.UI;

namespace Undergraduate_decisions.Classes
{
    internal class CanonFork : Canon
    {
        public CanonFork(string name, string Id, string description, 
                          string decision1, string nextPageId1, sbyte turns1, Action act1,
                          string decision2, string nextPageId2, sbyte turns2, Action act2)
            : base(name, description, CreateDecision(decision1, nextPageId1, turns1, act1),
                  CreateDecision(decision2, nextPageId2, turns2, act2))
        {
            this.Id = Id;
        }
        static Decision CreateDecision(string description, string nextPageId, sbyte turns, Action act)
        {
            return new Decision(
                description,
                () => {
                    act?.Invoke();
                    PendingStoryEvents.AddPage(nextPageId, turns);
                }
            );
        }
    }
}
