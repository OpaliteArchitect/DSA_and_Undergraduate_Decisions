using Undergraduate_decisions.Classes.Utilities;
using Undergraduate_decisions.UI;
using static Undergraduate_decisions.UI.EndingsUnlocked;

namespace Undergraduate_decisions.Classes
{
    internal class CanonEpilogue : Canon
    {
        public CanonEpilogue(string name, string Id, string description)
            : base(name, description, CreateDecision(name),
                  CreateDecision(name))
        {
            this.Id = Id;
        }
        static Decision CreateDecision(string name)
        {
            return new Decision(
                "Finish",
                () => {
                    if (!endingsUnlocked.Contains(name)) endingsUnlocked.Add(name);
                    PendingStoryEvents.AddPage("wrapper", 0);
                }
            );
        }
    }
}
