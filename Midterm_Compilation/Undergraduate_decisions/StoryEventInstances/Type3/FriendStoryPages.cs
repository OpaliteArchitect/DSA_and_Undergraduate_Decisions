using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undergraduate_decisions.Classes;
using Undergraduate_decisions.UI;

namespace Undergraduate_decisions.StoryEventInstances.Type3
{
    internal class FriendStoryPages
    {
        public static List<Canon> friendStoryPages = new()
        {
            new CanonPath(
                "Student fair", "friend1",
                "You turned away from the marble statue, your steps carrying you west into the warmth and chaos " +
                "of the student section. The music was too loud, the jokes too sharp, but you let yourself " +
                "be swept in. These were your peers, messy and alive. When the fair ended, the energy " +
                "lingered. You craved more of it.",
                "Continue", "Next", "friend2", 4
                ),
            new CanonPath(
                "University Facebook Group", "friend2",
                "It's been a few weeks since the student fair, but what you remember most was laughing " +
                "with your classmates until your throat hurt. Afterward, you felt a hollow quiet creeping " +
                "back in. A week later, you opened the university’s Facebook group, hoping to find more of " +
                "that energy online.",
                "Continue", "Next", "friend3", 5
                ),
            new CanonPath(
                "The stranger", "friend3",
                "The group became your second campus. You liked posts, commented on memes, joined long " +
                "threads about exams. After a few weeks of being active, a message pinged your inbox: " +
                "someone claiming to be a fellow student. Their tone was friendly, their profile picture " +
                "generic but harmless. You replied.",
                "“What's up?”", "“Hi”", "friend4", 4
                ),
            new CanonPath(
                "The friend", "friend4",
                "Conversations stretched late into the night. Jokes about professors, shared frustrations " +
                "about coursework, stories about cafeteria food. You began to feel close. When you suggested " +
                "meeting in person, they hesitated, then excused themselves with reasons that shifted each time.",
                "Sus", "picious", "friend5", 0
                ),
            new CanonFork(
                "The friend?", "friend5",
                "The pattern gnawed at you. Their replies were too polished, too immediate. One night, " +
                "after you asked about stress, they answered with a full paragraph lifted word-for-word " +
                "from the university’s mental health brochure—mission statement and all. The realization " +
                "hit you. It's a clanker.",
                "Ignore it and forget about this incident", "friend6b", 7, 
                () => Dimensions.ImpactDimensions([0,-5,0,0]),
                "Time for a visit to the counseling office", "friend6a", 8, null
                ),
            new CanonPath(
                "Nothing more to it", "friend6b",
                "After the revelation, you stopped replying. The unanswered messages stacked up in your inbox " +
                "until the algorithm must have marked you as low priority. Soon, even the pings ceased.",
                "Epilogue", "Epilogue", "friendx3", 0
                ),
            new CanonEpilogue(
                "Ending #4: Seen", "friendx3",
                "You buried yourself in lectures, lab work, late nights of notes and exams. Campus life moved " +
                "on without disruption. The chatbot remained a ghost—never acknowledged, never confronted—just " +
                "one more odd memory folded into your years at the university. You graduated with little fanfare, " +
                "carrying the quiet knowledge that somewhere in the system, a machine still waited for you to speak."
                ),
            new CanonPath(
                "Counseling Office", "friend6a",
                "You marched into the counseling office. The staff didn’t deny it. " +
                "They explained that the “peer” was an automated system, built to quietly monitor for signs " +
                "of students in distress. A risk assessment tool, they said. Anonymous, protective, “for your " +
                "own good.”",
                "Continue", "Next", "friend7", 0
                ),
            new CanonFork(
                "Counseling Office", "friend7",
                "They explain, “Universities face real risks: isolation, burnout, depression, even suicide. " +
                "A system that invisibly monitors students and flags risks could prevent tragedy.” \n" +
                "The deception is not cruelty but a preemptive intervention: better an unseen algorithmic " +
                "friend than no lifeline at all." +
                "\nYou reply, “Relationships, even digital ones, demand authenticity. To discover that intimacy " +
                "was simulated undermines trust, not just in the chatbot, but in the institution. Students " +
                "were never told they were being profiled. Risk assessment slides into surveillance.”" +
                "\n*Is it acceptable to manipulate individuals without disclosure, if the manipulation " +
                "prevents harm?*",
                "Autonomy is of utmost importance", "friend8a", 0, null,
                "A sacrifice I'm willing to make", "friend8b", 0, null
                ),
            new CanonPath(
                "Autonomy is of utmost importance", "friend8a",
                "The system withholds disclosure, eroding trust. Students enter what they believe is a peer " +
                "exchange but are in fact probed for vulnerabilities. Even if no immediate harm is done, the " +
                "precedent matters: if one corner of student life is quietly replaced by surveillance, what " +
                "prevents expansion?",
                "Epilogue", "Epilogue", "friendx1", 0
                ),
            new CanonEpilogue(
                "Ending #5: No to Big Brother", "friendx1",
                "You never logged back into the university Facebook group. Every notification felt tainted, " +
                "every comment section a cage painted bright with memes. \nThe counseling department called " +
                "it “risk management.” You called it surveillance. Maybe some students would be saved by it. " +
                "Maybe that mattered. But you couldn’t shake the chill of Orwell whispered through the " +
                "glow of your laptop screen: War is peace. Ignorance is strength. Care is control." +
                "\nYou left the office that day certain of one thing: your world is yours." 
                ),
            new CanonPath(
                "A sacrifice I'm willing to make", "friend8b",
                "Students who might otherwise slip through the cracks are flagged early, their language " +
                "patterns sifted for risk. The intention is prevention, a net woven from algorithms and " +
                "hidden scripts. The chatbot is a guardian in disguise, sacrificing transparency for " +
                "effectiveness.",
                "Epilogue", "Epilogue", "friendx2", 0
                ),
            new CanonEpilogue(
                "Ending #6: I, for one, welcome our new AI overlords", "friendx2",
                "You closed the counseling office door behind you, the weight of their explanation still " +
                "pressing against your thoughts. At first, you bristled at the deception. But the longer " +
                "you sat with it, the more you felt the pull of its logic." +
                "\nHow many students choke down their pain in silence? How many jokes mask despair? If a " +
                "machine can listen where humans miss the signals, is that not mercy—even if the " +
                "listening is hidden?" +
                "\nThe policy may be invasive, but it works. Better a secret sentinel than another obituary " +
                "pinned to the bulletin board. You log back into the Facebook group that night and type " +
                "without hesitation. The bot will see you. You welcome it."
                ),
        };
    }
}

// “”