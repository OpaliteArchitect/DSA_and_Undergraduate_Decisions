using Undergraduate_decisions.Classes.Utilities;

namespace Undergraduate_decisions.Classes
{
    internal class Canon : StoryEvent
    {
        public string Id;
        public string nextPageId;

        protected Canon(string x, string y, Decision a, Decision b) : base(x,y,a,b) { }
    }
}
