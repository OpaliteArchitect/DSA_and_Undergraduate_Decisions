using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undergraduate_decisions.StoryEventInstances.Type3;
using Undergraduate_decisions.UI;
using UndergraduateDecisions;

namespace Undergraduate_decisions.Classes.Utilities
{
    internal class ForcePage
    {
        public readonly string nextPageId;
        sbyte inTurns;

        public ForcePage(string nextPageId, sbyte inTurns)
        {
            this.nextPageId = nextPageId;
            this.inTurns = inTurns;
        }

        public void DecrementTurn()
        {
            if (inTurns > 0) inTurns--;
        }

        public bool ReadyToTrigger()
        {
            return inTurns <= 0;
        }
    }
}
