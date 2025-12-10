using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undergraduate_decisions.Classes;
using Undergraduate_decisions.Classes.Utilities;
using Undergraduate_decisions.UI;

namespace Undergraduate_decisions.StoryEventInstances.Type3
{
    internal class SharedPages
    {
        const string title0 = "First decisions", title1 = "Student fair";
        const sbyte daysTillFair = 6;
        public static List<Canon> sharedPages = new()
        {
            new CanonFork(title0,"firstday1",
                "It's your first day at college. The air buzzes with nervous energy and the weight of " +
                "unanswered questions. Lectures, friendships, and self-discovery await. Every choice will " +
                "shape who you become—academically, socially, mentally. Your journey begins now.",
                "Start chatting with some faces" , "firstday2", 0,
                () => {Dimensions.ImpactDimensions(new sbyte[]{0, 0, 0, 5 }); },
                "Pick a bill on the ground", "firstday3", 0,
                () => {Dimensions.ImpactDimensions(new sbyte[]{0, 0, 5, 0 }); }
                ),
            new CanonPath(title0, "firstday2",
                "You approach a group laughing near the campus statue. Their conversation stops as you " +
                "near. One smiles and asks, \"New here?\" You smile and nod, joining the circle. The " +
                "conversation shifts to shared anxieties about professors and hopes for the semester. " +
                "You exchange socials and promise to meet up later. The interaction leaves you feeling " +
                "lighter, more connected.",
                "Proceed with your day", "Smile, appreciating you feel at place", "firstday4", 0
                ),
            new CanonPath(title0, "firstday3",
                "A folded P500 bill lies near a bench. No one seems to notice it. You picked it up. " +
                "You slip the bill into your pocket, glancing around to see if anyone is watching. " +
                "No one meets your eyes. The weight of the money feels like a small advantage against " +
                "the uncertainty of student life.",
                "Nonchalantly move on", "Start whistling, pretending nothing happened", "firstday4", 0
                ),
            new CanonPath(title0, "firstday4",
                "Your last choice impacted one of your dimensions. Throughout your undergraduate " +
                "life, you'll be faced with dilemmas that will challenge how you balance all four.\n" +
                "Avoid having too much or too little in any one area to survive. Good luck.",
                "Got it", "Okay", "fair1", daysTillFair
                ),
            new CanonPath(title1, "fair1",
                "The University’s Annual Student Fair erupts across the quad. Various booths form a grid " +
                "of potential futures, each one a fork in the road of your undergraduate life. " +
                "The air is thick with the scent of free pizza, fresh pamphlets, and the crisp sunny day " +
                "promise of change. tables bowed under the weight of glossy brochures, student-built robots " +
                "stood motionless in silent demonstration, and the scent of grilling meat from the " +
                "sociology club’s fundraiser mingled with the crisp smell of impending rain. Banners " +
                "snapped in the wind, promising connections, discoveries, belonging." +
                "\nA low hum of negotiation and performance thrummed through the air. A cappella " +
                "harmonies from the Glee Club wove between the earnest pitches of debate team recruits. " +
                "Near the faded marble steps of the library, a professor demonstrated a Tesla coil with " +
                "theatrical sparks that drew gasps and nervous laughter. Everywhere, eyes met, seemingly " +
                "seeking reflection in the possibilities arrayed before them. It was a spectacle of " +
                "becoming, a mosaic of youth and institution playing out under the open sky.",
                "Bask in the morning sun", "Look around", "fair2", 0
                ),
            new CanonFork(title1, "fair2",
                "As you stare into the busy crowd, two things in particular caught your attention." +
                "To the east, near the old marble statue of the university founder, " +
                "a circle of professors stood like titans in a grove of knowledge. You recognize some of " +
                "them as your professors. They look approachable but are engaged in serious conversation. " +
                "Engaging with them could open doors to mentorship, specialized projects, or academic favor. " +
                "\nTo the west, the student section throbbed with life. Music from a makeshift speaker " +
                "system battled the earnest chatter. A boy with neon hair offered energy drinks from a " +
                "cooler. A group laughed too loudly at a joke, their cohesion a fortress. Flyers for " +
                "parties, protests, and poetry slams fluttered in the breeze. The scent of popcorn and cheap " +
                "body spray hung in the air. Here, every handshake was a potential friendship, every " +
                "conversation a doorway into the night." +
                "\nYou figured you'll have to join either the professors or your fellow students. " +
                "As you contemplate on your decision, the air itself seems to whisper, " +
                "\"*Pay attention, this matters*\"",
                "Approach the professors (Recommended path)" ,"mentor1", 0,
                () => {Dimensions.ImpactDimensions(new sbyte[]{5, 0, 0, 0 }); },
                "Join the students (Honestly, not enough time to make this one)", "friend1", 0,
                () => {Dimensions.ImpactDimensions(new sbyte[]{0, 5, 0, 0 }); }
                ),
            new CanonFork(
                "You finished a playthrough", "wrapper",
                "",
                "Main Menu", "abcdefg", 0, () => {StoryEventDisplay.endingReached = true; },
                "Main Menu", "abcdefg", 0, () => {StoryEventDisplay.endingReached = true; }
                )
        };
    }
}
