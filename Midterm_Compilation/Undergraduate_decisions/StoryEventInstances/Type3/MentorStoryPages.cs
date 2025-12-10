using System;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Undergraduate_decisions.Classes;
using Undergraduate_decisions.UI;

namespace Undergraduate_decisions.StoryEventInstances.Type3
{
    internal static class MentorStoryPages
    {
        public static List<Canon> mentorStoryPages = new()
        {
            new CanonPath(
                "Student fair", "mentor1",
                "You approach the circle of professors. Dr. Evangeline Santos, a sharp-eyed woman in a blazer, " +
                "notices you first. “Looking for guidance, or just curious?” she asks. You mention your " +
                "interest in research. An older man with a calm demeanor, Professor Roland Vale, steps forward. " +
                "“What’s your field?” he asks. You answer, and his eyes light up with genuine interest. " +
                "\"We always need keen minds,\" he says. He asks about your academic interests, and when you " +
                "answer, he listens with a focus that makes the surrounding fair fade into blur. " +
                "He doesn’t offer praise, but his questions sharpen, probing the depth of your understanding " +
                "rather than the ease of your answers.\nYou mentioned you live in the dorms. He gestures " +
                "toward the faculty building behind him. \"I live there too. Convenient,\" he remarks dryly. " +
                "\"The library is open until midnight. The lab until two. No excuses for unmet potential.\"",
                "Appreciate the advice", "\"Thank you\"", "mentor2", 5
                ),
            new CanonFork(
                "Grocery store encounter", "mentor2",
                "\tYou run into Professor Vale at the campus grocery store on a Saturday morning. " +
                "He’s examining canned goods with a critical eye. He asks about your week, and the " +
                "conversation shifts from coursework to the cost of living on campus. “You’re a dormer too,” " +
                "he notes. “You understand the constraints.”" +
                "\nHe mentions the university's food bank program, where he serves as an advisor. " +
                "\"It's more than handing out meals,\" he explains. \"We track which majors struggle most " +
                "with food insecurity. It helps us tailor support.\" Sometimes, the most gifted minds " +
                "are buried under financial stress. They just need a pathway to visibility." +
                "\n“Corporate partners sponsor the program. His tone is smooth, persuasive. " +
                "“You should volunteer. See the operation from the inside.”",
                "I'm busy", "mentor3", 0,
                () => {
                    CanonGetter.storyEventsList.Add(
                    new CanonPath(
                        "Elara", "mentor10",
                        "You’re rushing through the courtyard for your next class when you almost trip over someone " +
                        "sitting on the low wall beneath the acacia tree - hood up, knees tucked to her chest. " +
                        "It’s Elara, the food bank beneficiary. She looks up, startled, and you mumble an apology " +
                        "explaining you're hurrying for the next class. " +
                        "“It's alright. Hey, I remember you. You were at the food bank,” she replies. " +
                        "“Right, I remember you too. Sucks it had to shut down.” you answer back. " +
                        "\n“Things changed after that,” she shrugs. “Changed how?” you ask. She hesitates, " +
                        "then forces a small smile. “I got into a program. A scholarship, technically. They said they " +
                        "saw potential in me.” “That's great.”, you say, though something in her posture suggests she " +
                        "isn't telling you everything." ,
                        "I gotta get to that class.", "Everything okay?", "mentor11b", 0
                        )
                    );
                },
                "I will", "mentor4", 5,
                () => {
                    CanonGetter.storyEventsList.Add(
                    new CanonFork(
                        "Elara", "mentor10",
                        "You’re rushing through the courtyard for your next class when you almost trip over someone " +
                        "sitting on the low wall beneath the acacia tree - hood up, knees tucked to her chest. " +
                        "It’s Elara, the food bank beneficiary. She looks up, startled, and you mumble an apology " +
                        "explaining you're hurrying for the next class. " +
                        "“It's alright. Hey, I remember you. You were at the food bank,” she replies. " +
                        "“Right, I remember you too. Sucks it had to shut down.” you answer back. " +
                        "\n“Things changed after that,” she shrugs. “Changed how?” you ask. She hesitates, " +
                        "then forces a small smile. “I got into a program. A scholarship, technically. They said they " +
                        "saw potential in me.” “That's great.”, you say, though something in her posture suggests she " +
                        "isn't telling you everything." ,
                        "I gotta get to that class.", "mentor11b", 0, null,
                        "Everything okay?", "mentor11a", 0, null
                        )
                    );
                }
                ),
            new CanonPath(
                "Grocery store encounter", "mentor3",
                "Professor Vale’s expression doesn’t change, but his eyes cool slightly. “Busy is what we make " +
                "time for,” he says, his tone still pleasant but now edged with dismissal. “Perhaps when " +
                "your priorities align.” He turns back to the shelf \nYou rarely saw Professor Vale for a " +
                "few months after that.",
                "Next", "Continue", "mentor7", 7
                ),
            new CanonPath(
                "Volunteering at the food bank", "mentor4",
                "Professor Vale meets you at the door of the campus food bank, a room lined with neat shelves of " +
                "canned goods and dry pasta. \"I'm so glad you agreed to volunteer,\" he says. " +
                "“This began five years ago,” he continues. “Funded entirely by corporate sponsors who believe " +
                "in… supporting potential.” He gestures toward the logos of tech firms and investment groups " +
                "displayed discreetly on the wall. He then shows you the inventory system, the digital check-in " +
                "for students, and the spreadsheets tracking beneficiaries' metrics. Then, with a brief " +
                "nod, he leaves you to assist the other volunteers." + "\nThe food bank is quieter than " +
                "you expected, lit by long fluorescent lights that hum over shelves of precisely sorted " +
                "donations. You’re stacking bags of rice when you notice someone watching you from beside the " +
                "dairy cooler. She’s slight, with her hood pulled up and sleeves frayed at the wrists. " +
                "Her name is Elara, a second-year biology major, and she’s not a volunteer. She’s here " +
                "to collect her weekly box. You offer to help her carry it to the door. She hesitates, then " +
                "nods. Outside, she thanks you with a quiet urgency.",
                "\"You're welcome\"", "Nod quietly", "mentor5", 0
                ),
            new CanonPath(
                "Volunteering at the food bank", "mentor5",
                "You went back inside and finished your shift in silence. rofessor Vale emerged from the office " +
                "hallway, his expression unreadable. He stood by the door. “You handled yourself well today,” " +
                "he said. “Same time next week.”" +
                "You returned the following week. And the week after that. The rhythm of volunteering became " +
                "familiar: the hum of the lights, the scent of dry rice and cardboard. " +
                "Throughout the weeks, you have encountered and helped countless other students like Elara, as " +
                "well as Elara herself. “I'm grateful for the work you and others have been doing in this food " +
                "bank,” she says one time. You've since learned she came from a distant province and is " +
                "currently living with her grandmother, relying on scholarships get through. " +
                "The food bank is a lifesaver for students like her.",
                "Continue", "Next", "mentor6", 7
                ),
            new CanonPath(
                "The food bank was shut down", "mentor6",
                "Weeks later, you spot Elara sitting alone on a bench." +
                "When you approach, she looks up. “The food bank is closed,” she says flatly. " +
                "Apparently the donors weren’t just generous—they were laundering.” She lets out a dry laugh. " +
                "You sit beside her. She speaks, “They weren’t feeding us because they cared. " +
                "They were feeding us to clean their money. When you’re poor, you " +
                "become part of someone else’s transaction. Even salvation has a price tag.” " +
                "\nYou ask if she’ll be okay. She smiles faintly. “I’ve fasted before.” She stands, " +
                "slinging her worn backpack over one shoulder.",
                "Ask Professor Gale about this", "Find Professor Gale", "mentor8", 3
                ),
            new CanonPath(
                "The food bank", "mentor7",
                "You’re crossing the quad when you notice a crowd gathered near the entrance of the campus food " +
                "bank. A sign is taped to the door: CLOSED UNTIL FURTHER NOTICE. " +
                "\nA student with tired eyes and a frayed hoodie turns to you. " +
                "“This was closed all morning,” she says quietly. “Turns out the donors were laundering money " +
                "through this place. All those corporate logos?” She gestures bitterly toward the " +
                "sponsor plaques still mounted near the door. “Wasn’t charity. " +
                "The name's Elara by the way.” A man next to her hugs himself tightly. " +
                "“They knew we had no choice but to take it.” \nYou stand there in silence. " +
                "You think back to the time Professor Gale asked you to volunteer for this food bank.",
                "Ask Professor Gale about this", "Find Professor Gale", "mentor8", 0
                ),
            new CanonPath(
                "The food bank", "mentor8",
                "You find Professor Vale in his office. The room smells of old paper and black coffee. " +
                "He doesn’t look up when you enter, but he knows it’s you. “You’ve heard,” he says flatly. " +
                "It isn’t a question.\nYou ask about the investigation. He tells you he had no idea.  " +
                "“I reviewed their financials annually. The numbers were clean on paper.” He doesn’t look " +
                "away. “But laundering isn’t done in the records I was shown.” \nHe didn’t know." +
                "\nYou feel a sense of relief. “They used my reputation to lend " +
                "theirs credibility. This serves as a lesson in vigilance to me. One I won’t forget.”",
                "Move on", "Next", "mentor9", 4
                ),
            new CanonPath(
                "Mentor, mentee", "mentor9",
                "Weeks has passed since the food bank incident. You now meet Professor Vale every Tuesday " +
                "and Thursday in his office. He doesn’t ask about the food bank again. Neither do you. He begins " +
                "leaving a second cup of black coffee on the desk beside yours before you arrive. " +
                "You discuss research methodologies, ethical paradoxes in data collection, the architecture " +
                "of power hidden in plain sight. He speaks to you like a colleague, not a student. " +
                "His critiques are sharp, his expectations high. \nOne visit, you realize he’s no longer " +
                "just your professor. He’s your mentor and you're his mentee.",
                "Continue", "Next", "mentor10", 8
                ),
            new CanonPath(
                "Elara", "mentor11b",
                "“Yeah.” Her smile lingers just long enough to signal the end of the exchange. You glance at " +
                "the time on your phone, mutter a quick goodbye, and slip into the tide of students " +
                "crossing the quad.\nBy the time you look back, Elara is gone. Whatever she meant to " +
                "say stays unspoken, and the day moves on.",
                "Continue","Next", "mentor11b2", 4
                ),
            new CanonPath(
                "The quiet", "mentor11b2",
                "A few weeks pass. Your schedule folds into the rhythm of labs, lectures, and late nights with " +
                "data. Somewhere in that blur, Professor Gale begins drawing you in closer. You find yourself " +
                "quoting his phrases in your own notes. “Efficiency first.” “Mechanism over morality.” You catch " +
                "it, notice it, but you don’t stop. The food bank fades from memory during these weeks. So did " +
                "the acacia tree, the hooded Elara, the half-smile. That whole conversation dissolves " +
                "into the backlog of small encounters you don’t revisit. Professor Gale is here, sharpening you, " +
                "giving you tools. Whatever Elara meant with her silence, it no longer seems to matter.",
                "Epilogue", "Epilogue", "mentorx3", 0
                ),
            new CanonEpilogue(
                "Ending #3 - Ignorance is bliss", "mentorx3",
                "Years passed. You graduate with honors, robe crisp, diploma in hand, and Professor Gale " +
                "watching from the front row with unmistakable pride. His mentorship is the spine of your success, " +
                "his voice the echo behind every decision that carried you here. To you, he was never " +
                "anything but generous, exacting, and endlessly patient. \nThe food bank is a footnote " +
                "in university history. Elara is a passing face you barely recall. No unease shadows your " +
                "memories. Your story is one of clarity, achievement, and ascent." +
                "\nAnd yet, sometimes, in a version of life not lived, you imagine pausing under an acacia " +
                "tree, hearing words that would have unsettled you, seeing truths that would have turned your " +
                "life upside down. But that is not this life. \nIn this one, you walk across " +
                "the stage to applause, smiling, untroubled. The world is simple, and it has rewarded you well."
                ),
            new CanonPath(
                "Elara", "mentor11a",
                "Elara begins a story. “They came to me the day after I picked up my food box. A woman in a " +
                "tailored suit approached me as I was leaving. She called me by name—Miss Reyes—like she " +
                "already knew me. She said she represented an ‘academic partnership program’ " +
                "sponsored by one of the donors who funded the food bank.”" +
                "\nShe pauses, swallowing hard.\n“She mentioned my grades in molecular " +
                "biology. Knew I’d aced my last exam despite missing classes the week before. " +
                "Knew I couldn’t afford lab fees.” Elara’s voice tightens. “She said they could cover all " +
                "my expenses—tuition, books, even rent—in exchange for committing to a paid internship " +
                "after graduation. The contract was thirty pages long. I signed it beside a dumpster " +
                "because I had ten minutes to catch the last bus home.” " +
                "\nYou blink. “Wait, you signed without reading it all?”\nElara’s mouth twists. " +
                "“I read the first three pages. The rest was legal jargon. But what choice did I have? " +
                "Either keep suffering, or take the deal.”\n“And now?” you ask cautiously.\nShe pulls " +
                "her hood lower, voice dropping. “Now I know what I signed. The internship isn’t after " +
                "graduation. It started immediately. Everything I produce in the lab—notes, data, even " +
                "half-formed ideas scribbled in margins—it all belongs to them. I’m just the pair of hands. " +
                "The donors owns everything I produce, and I get… an allowance.”",
                "“That’s exploitation. Doesn’t anyone question it?”",
                "“Is there anything you can do?”", "mentor12", 0
                ),
            new CanonPath(
                "Elara", "mentor12",
                "“No,” she snaps. Then softer: “Everyone thinks it’s a scholarship. My family tells neighbors " +
                "I’m the lucky one. I can’t tell them the truth. The NDA alone could ruin us if I break it.”" +
                "\nSilence stretches. The acacia branches creak overhead.\n“So the food bank—” you start." +
                "\n“Was never charity,” Elara cuts in. “It was a filter. They fed us just enough to see who " +
                "could think, who could endure, who could be useful. Then they bought us, contract by contract.”",
                "“...”", "Continue", "mentor13", 3
                ),
            new CanonPath(
                "The Investigation", "mentor13",
                "“It was a filter.  Then they bought us, contract by contract.” Elara's words keep echoing in your " +
                "head long after you leave her by the acacia tree. You started digging." +
                "\nAt first it’s scattered details: archived press releases about “partnership initiatives,” " +
                "foundation newsletters celebrating “student success stories.” They all share one thing in common:" +
                "food bank beneficiaries. \nPatterns crystallize. Every student with exceptional scores or " +
                "is absorbed into the same pipeline. The contracts differ in phrasing, but all include: " +
                "intellectual property transfer, binding non-disclosure agreements, multi-year obligations " +
                "beyond graduation. \nEvery trail ends the same way: young people erased from credit, their " +
                "work sold off to corporate partners at staggering profit margins, while they survive on stipends " +
                "too small to escape.",
                "Bring it up to Professor Gale", "Report to Professor Gale", "mentor14", 9
                ),
            new CanonPath(
                "Professor Gale", "mentor14",
                "Professor Gale's office was lit like a lab. White walls. Stacks of journals. A framed plaque " +
                "from the foundation. You put your the folder containing your weeks of research on the his desk." +
                "“Data on former food bank recipients,” you said. “Same pattern. Scholarships tied to IP " +
                "assignments. NDAs. Multi-year service terms. Patents downstream with corporate partners. " +
                "Students erased from credit. It’s a pipeline.” \nHe glanced at the first page, then at you. " +
                "“Good work. You connected the nodes.”",
                "“You knew.”", "“How could you?”", "mentor15", 0
                ),
            new CanonPath(
                "Professor Gale", "mentor15",
                "You watch him speak with clinical calm, as though he were presenting a lecture, not dismantling " +
                "lives. He explains, “We convert scarcity into opportunity. Students get tuition, housing, lab " +
                "access. Industry gets deliverables. Value circulates.” \n“Value is extracted,” you said. " +
                "“Consent under scarcity is not consent. Information asymmetry. Exit costs structured to be " +
                "punitive. This is enclosure of intellectual labor.” \nHe tapped the plaque. " +
                "“Contracts are clear. We pay real money. We take risk. Most of these students would have " +
                "dropped out. Now they publish, travel, send money home. \nYour mind jumps back to Elara’s " +
                "clenched fists under the acacia tree. How she was presented with survival dressed as opportunity. " +
                "How she was forced to remain silent and compliant.",
                "Continue", "Next", "mentor16", 0
                ),
            new CanonFork(
                "Professor Gale", "mentor16",
                "“First the money laundering. I thought that was all there is to it. I even trusted you. But this? " +
                "The food bank was sold as charity,” you said. “You screened for the most exploitable high " +
                "performers.” \n“The public does not fund labs at market cost,” he said. “You know the " +
                "budget sheets. Grants want impossible deliverables. Industry subsidizes the gap. In return, " +
                "they ask for IP certainty and confidentiality. That is the price of keeping lights on.”" +
                "\n“Built on the suffering of the students you predated on,” you say. " +
                "He replies, “Excellence without capital dies. We are the capital. We turn ideas into products. " +
                "\nHe continues, “You seek a clean world that does not exist. I manage trade-offs in this one.”",
                "“I- I- think you're right”", "mentor17a", 0, null,
                "“You're wrong!”", "mentor17b", 0, null
                ),
            new CanonPath(
                "Professor Gale", "mentor17a",
                "Words claw at your throat. Every sentence of his carried a brutal internal " +
                "logic. It is ugly, but airtight. You thought of Elara, bent over her notebook, her ideas " +
                "already absorbed into a system she could not exit. Exploited, yes. But also surviving, " +
                "clothed, housed, studying. Without the contract, would she still be crouched waiting in " +
                "another food line? \n“Maybe it’s predation,” you said quietly. “But it works.”" +
                "He gave a small nod. “That’s what I wanted you to see. Not morality. Mechanism. " +
                "You can fight it from the outside, or you can enter and tilt the levers.” " +
                "\n“Teach me how.” \nHe smiled. He slid a single page from his drawer. " +
                "“Memorandum of understanding,” he said. “Revised terms just for you.” \nYou signed." +
                "He smiles. “Now you’ll learn how the world actually runs.”",
                "Epilogue", "Epilogue", "mentorx1", 0
                ),
            new CanonEpilogue(
                "Ending #1: Welcome to the new world order", "mentorx1",
                "Weeks pass. Your days fill with papers, datasets, and closed-door meetings. Your stipend rises. " +
                "Your name begins appearing in acknowledgments. The system that once looked like a cage now " +
                "feels like a ladder. You climb, step by step, telling yourself you’ll tilt the levers when " +
                "you reach the top.\nElara crosses your path sometimes in the labs. She barely looks up, " +
                "focused on her benchwork. You don’t speak of that night under the acacia tree. You don’t " +
                "tell her you signed.\nAnd yet, in quiet moments, the thought returns: the food lines are " +
                "still out there. Someone else is sitting on a low wall, waiting for their turn. " +
                "Someone else will sign beside a dumpster."
                ),
            new CanonPath(
                "Professor Gale", "mentor17b",
                "His jaw tightened. “Naïve. You’ll learn the hard way. Systems do not fall because you disapprove " +
                "of them.”\n“Maybe not,” you said. “But they don’t last forever, either. Not when the " +
                "people you exploit start naming things for what they are.” You walked out without looking back.",
                "Epilogue", "Epilogue", "mentorx2", 0
                ),
            new CanonEpilogue(
                "Ending #2: Against the Machine", "mentorx2",
                "You begin meeting Elara more often. She shares what she can, careful to avoid breaching her NDA, " +
                "but together you sketch the outlines of the talent pipeline. Patterns of exploitation become stories, " +
                "stories become testimony. \nSoon you’re speaking at forums, writing under pseudonyms, " +
                "feeding leaks to sympathetic journalists. The university dismisses it as " +
                "“activist exaggeration,” but the seed is planted. More students whisper about the food bank, " +
                "about contracts signed beside dumpsters, about companies who rake in millions on silent labor. " +
                "\nGale continued as if nothing had happened. His papers still appeared in major journals, " +
                "his name still drew applause at conferences. If he thought of you at all, it was as a naïve " +
                "student burned out on idealism. But you knew better. " +
                "\nThe difference between you was not ignorance or naivety. It was empathy." +
                "\nThe world remains unchanged for now. But you no longer see it in black and white."
                )
        };
    }
}
// quotation marks:    “”
