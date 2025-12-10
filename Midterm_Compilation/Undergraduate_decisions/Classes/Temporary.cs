using Undergraduate_decisions.Classes.Utilities;
using Undergraduate_decisions.UI;

namespace Undergraduate_decisions.Classes
{
    internal class Temporary : StoryEvent
    {
        public Temporary(string name, string description,
                    string decision1, string decision2,
                    sbyte[] set1Impact, sbyte turns1,
                    sbyte[] set2Impact, sbyte turns2)
        : base(name, description, CreateDecision(decision1, set1Impact, turns1, name), 
              CreateDecision(decision2, set2Impact, turns2, name)) { }
        static Decision CreateDecision(string description, sbyte[] impacts, sbyte turns, string decisionName)
        {
            return new Decision(
                CreateDecisionDescription(description, impacts),
                () => {
                    if (turns > 0) Status.CreateStatus(decisionName, impacts, turns);
                }
            );
        }

        static string CreateDecisionDescription(string description, sbyte[] impacts)
        {
            List<string> effects = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                if (impacts[i] == 0) continue;

                string severity = Math.Abs(impacts[i]) < 4 ? "slightly" : "significantly";
                effects.Add($"constantly {severity} affects {dimensionNames[i]}");
            }

            string effectsText = effects.Count > 0 ? $" ({string.Join(", ", effects)})" : "";
            return description + effectsText;
        }
    }
}
