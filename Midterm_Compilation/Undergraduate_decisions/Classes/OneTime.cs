using Undergraduate_decisions.Classes.Utilities;
using Undergraduate_decisions.UI;

namespace Undergraduate_decisions.Classes
{
    internal class OneTime : StoryEvent
    {
        public OneTime(string name, string description,
                    string decision1, string decision2,
                    sbyte[] set1Impact, sbyte[] set2Impact)
        : base(name, description, CreateDecision(decision1, set1Impact), CreateDecision(decision2, set2Impact)){ }
        static Decision CreateDecision(string description, sbyte[] impacts)
        {
            return new Decision(
                CreateDecisionDescription(description, impacts),
                () => {
                    Dimensions.ImpactDimensions(impacts);
                }
            );
        }

        static string CreateDecisionDescription(string description, sbyte[] impacts) {
            List<string> effects = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                if (impacts[i] == 0) continue;

                if (Dimensions.ownsOracle)
                {
                    effects.Add($"{(Math.Sign(impacts[i]) == 1 ? "+" : "")}{impacts[i] * 4}% to {dimensionNames[i]}"); 
                    continue; }

                else if (description == "“I'll buy it”") { return 
                        description + " (requires average Academic, Mental, Social; high Financial)"; }

                    string severity = Math.Abs(impacts[i]) < 4 ? "slightly" : "significantly";
                effects.Add($"{severity} affects {dimensionNames[i]}");
            }

            string effectsText = effects.Count > 0 ? $" ({string.Join(", ", effects)})" : "";
            return description + effectsText;
        }
    }
}
