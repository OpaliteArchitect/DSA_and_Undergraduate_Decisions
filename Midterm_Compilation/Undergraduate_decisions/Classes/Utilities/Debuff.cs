using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undergraduate_decisions.UI;

namespace Undergraduate_decisions.Classes.Utilities
{
    internal class Debuff
    {
        public string name {  get; set; }
        sbyte[] impacts = new sbyte[4];
        sbyte turnsLeft;

        public Debuff(string name, sbyte[] impacts, sbyte turnsLeft) { 
            this.name = name;
            this.impacts = impacts;
            this.turnsLeft = turnsLeft;
        }

        public void ApplyDebuff()
        {
            if (turnsLeft-- > 0)
            {
                Dimensions.ImpactDimensions(impacts);
            }
            else
            {
                Status.RemoveStatus(this);
            }
        }
    }
}
