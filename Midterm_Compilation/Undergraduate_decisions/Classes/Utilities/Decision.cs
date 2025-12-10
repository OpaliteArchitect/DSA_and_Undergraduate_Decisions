using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undergraduate_decisions.Classes.Utilities
{
    internal class Decision
    {
        public string Description { get; set; }
        public Action Impact {  get; set; }

        public Decision(string description, Action impact) { 
            this.Description = description;
            this.Impact = impact;
        }
    }
}
