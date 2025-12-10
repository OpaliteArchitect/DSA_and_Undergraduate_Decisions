using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Undergraduate_decisions.Classes;

namespace Undergraduate_decisions.StoryEventInstances.Type2
{
    internal static class StatusEffects
    {
        static readonly Random rnd = new();
        public static Temporary
            class_suspension = new("Class suspension",
                "Classes are suspended for some time. Take this time to rest and spend time with " +
                "your family and friends.",
                "Cool",
                "Okay",
                new sbyte[] { 0, 1, 0, 1 }, 5,
                new sbyte[] { 0, 1, 0, 1 }, 5
                );
        public static Temporary
            parttime_job = new("Part-time job",
                "A call center near campus is hiring evening shifts. It drains your energy " +
                "and cuts into study time, but the steady income could ease your financial stress. " +
                "The manager emphasizes strict attendance policies: miss a shift, and you’re out.", 
                "Take the job",
                "Decline",
                new sbyte[] { -1, -1, 2, 0}, (sbyte)rnd.Next(4, 9), 
                new sbyte[4], 0
                );
        public static Temporary
            depression = new("Depression",
                "Something's off today. The joy has been vacuumed out of everything. Music irritates. " +
                "Food tastes like nothing. You scroll through photos of yourself from months ago when you " +
                "knew how to smile. Now even showering is a monumental task. You are watching your own life " +
                "through thick, distorted glass, unable to touch any of it.",
                "...",
                "Huh?", 
                new sbyte[] {0, -1, 0, 0}, 5,
                new sbyte[] {0, -1, 0, 0}, 5
                );
        public static Temporary
            anxiety = new("Anxiety",
                "You’re at the campus cafeteria trying to work. All of a sudden, every clatter of a cup, " +
                "every burst of laughter from another table, makes you flinch. You can’t focus. " +
                "You keep adjusting your posture, worried people are watching you, judging how you sit, " +
                "how you drink, how you exist. You leave early without finishing your coffee, wondering why " +
                "something as simple as sitting in public feels like facing a firing squad.",
                "*Feel the thumping of your chest*",
                "*wipe the sweat off your forehead*",
                new sbyte[] {0, 0, 0, -1}, 5,
                new sbyte[] {0, 0, 0, -1}, 5
                );
        public static Temporary
            exam_season = new("Examinations season", 
                "You spread your notes across the library table—color-coded highlighters, open textbooks, " +
                "and a half-finished coffee. The material is familiar, but you methodically review each " +
                "concept, rewriting summaries in the margins. The quiet hum of focused students around you " +
                "is calming. You take short breaks to stretch or stare out the window, then return to " +
                "your notes refreshed.",
                "Continue studying alone",
                "Find a study buddy",
                new sbyte[] {1, 1, 0, -1}, 3,
                new sbyte[] {1, -1, 0, 1}, 3
                );
        public static Temporary
            burnout = new("Burnout",
                "Your notes are spread across the desk in a familiar mosaic of highlighted text and scribbled " +
                "diagrams. The words are known, their shapes comfortable, but their meaning refuses to coalesce. " +
                "You trace the lines with your finger, not studying, just reminding yourself of the terrain. " +
                "The chair groans as you lean back, eyes drifting to the window. The world outside continues, " +
                "unconcerned. You let it. The book remains open, but you do not turn the page.",
                "Rest",
                "Continue working",
                new sbyte[] { -1, 0, 0, 0 }, 4,
                new sbyte[] { 0, -1, 0, 0 }, 6
                );
    }
}
