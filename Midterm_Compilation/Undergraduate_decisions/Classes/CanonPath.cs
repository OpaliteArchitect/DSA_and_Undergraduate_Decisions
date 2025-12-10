using Undergraduate_decisions.Classes.Utilities;
using Undergraduate_decisions.UI;

namespace Undergraduate_decisions.Classes
{
    internal class CanonPath : Canon
    {
        public CanonPath(string name, string Id, string description,
                          string decision1, string decision2, string nextPageId, sbyte turns) 
            : base(name, description, CreateDecision(decision1, nextPageId, turns), 
                  CreateDecision(decision2, nextPageId, turns)) 
        {
            this.Id = Id;
        }
        static Decision CreateDecision(string description, string nextPageId, sbyte turns)
        {
            return new Decision(
                description,
                () => {
                    PendingStoryEvents.AddPage(nextPageId, turns);
                }
            );
        }
    }
}
