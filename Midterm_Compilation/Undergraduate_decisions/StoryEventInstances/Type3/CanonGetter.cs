using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undergraduate_decisions.Classes;

namespace Undergraduate_decisions.StoryEventInstances.Type3
{
    internal static class CanonGetter
    {
        public static List<Canon> storyEventsList = [];

        public static void Initialize()
        {
            storyEventsList.Clear();
            storyEventsList.AddRange(SharedPages.sharedPages);
            storyEventsList.AddRange(FriendStoryPages.friendStoryPages);
            storyEventsList.AddRange(MentorStoryPages.mentorStoryPages);
        }
        public static Canon GetStoryEvent(string nextPageId)
        {
            return storyEventsList.FirstOrDefault(canon => canon.Id == nextPageId);
        }
    }
}
