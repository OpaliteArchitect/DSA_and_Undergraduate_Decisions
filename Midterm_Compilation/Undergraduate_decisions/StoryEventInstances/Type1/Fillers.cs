using Undergraduate_decisions.Classes;

namespace Undergraduate_decisions.StoryEventInstances.Type1
{
    internal static class Fillers
    {
        public static OneTime
            procrastination = new(
                "Procrastination",
                "A professor announced a long assignment that requires time to finish. It’s not " +
                "due for a few days. At the same time, your favorite video game released a major update.",
                "Play the game and do homework later",
                "Do your homework immediately and pass up on playing for now",
                new sbyte[] { -4, 3, 0, 0 },
                new sbyte[] { 4, -3, 0, 0 }
                );

        public static OneTime
            hang_out = new(
                "Hanging out with friends",
                "Somebody sent a new message in your friends' group chat. They’re heading to the usual spot " +
                "downtown tonight and are asking if you’re coming. ",
                "\"Sure, I'll come\"",
                "\"Sorry, I'm busy\"",
                new sbyte[] { 0, 2, -3, 2  },
                new sbyte[] { 0, 0, 0, -2 }
                );

        public static OneTime
            get_tutored = new(
                "Get tutored",
                "You can book a session with a tutor. Doing so will give you a deeper understanding of lessons.",
                "Book a session",
                "Pass",
                new sbyte[] { 4, 0, -3, 0 },
                new sbyte[] { -3, 0, 2, 0 }
                );
        public static OneTime
            advanced_reading = new(
                "Advanced reading",
                "You come across a set of advanced reading materials. They can increase your subject profiency " +
                "at the cost of time not spent on replying to messages.",
                "Solve them anyway",
                "Ignore them",
                new sbyte[] { 3, 0, 0, -3 },
                new sbyte[] { -2, 0, 0, 3 }
                );
        public static OneTime
            bullied_classmate = new(
                "A bullied classmate",
                "You witness a group of students harassing a quiet classmate in the hallway. " +
                "No teachers are nearby.",
                "Step in and confront the bullies",
                "Pretend to haven't seen anything",
                new sbyte[] { 0, 5, 0, -3 },
                new sbyte[] { 0, -5, 0, 2 }
                );
        public static OneTime
            birthday_party = new(
                "Birthday Party",
                "You are invited to a classmate's birthday party. " +
                "Attending means enjoying some downtime, but you'll lose a full night of study.",
                "Studies come first",
                "Why not? Let's go!",
                new sbyte[] { 2, 0, 0, -4 },
                new sbyte[] { -3, 1, 0, 3 }
                );
        public static OneTime
            review_lessons = new(
                "Review lessons",
                "A major exam is coming in two days. The coverage is broad and you have barely started " +
                "skimming the material.",
                "I'm a responsible student; I'm reviewing",
                "I'd rather do something fun",
                new sbyte[] { 6, -5, 0, 0 },
                new sbyte[] { -6, 4, 0, 0 }
                );
        public static OneTime
            allowance_for_chores = new(
                "Do chores for allowance",
                "Your parents offer you a chance to earn extra allowance by helping with household chores " +
                "over the weekend." ,
                "I need the money",
                "Boooooring! No, thanks",
                new sbyte[] { 0, -4, 3, 0 },
                new sbyte[] { 0, 1, 0, 0 }
                );
        public static OneTime
            beggar = new(
                "Beggar",
                "Your friend is treating others to snacks. " +
                "Lately, you’ve been short on cash for lunch.",
                "Keep your financial problem to yourself",
                "No shame, no gain, amirite?",
                new sbyte[] { 0, 0, -4, 2 },
                new sbyte[] { 0, 0, 3, -2 }
                );
        public static OneTime
            boba_tea = new(
                "Boba tea",
                "This week has been stressful. You're craving your favorite food, that boba tea from that " +
                "shop near campus.",
                "Boba tea is love, boba tea is life",
                "I really can't afford it right now",
                new sbyte[] { 0, 3, -2, 0 },
                new sbyte[] { 0, -2, 0, 0 }
                );
        public static OneTime
            dating1 = new(
                "Fine-dining restaurant",
                "Finally, you’ve been asked out on a date by someone you’ve liked for weeks. " +
                "But it's set in an expensive restaurant.",
                "Get me a formal attire",
                "I would love to, but I need to study...",
                new sbyte[] { 0, 0, -3, 4 },
                new sbyte[] { 2, 0, 0, -1 }
                );
        public static OneTime
            dating2 = new(
                "Simple date",
                "You've been talking with someone for weeks now. You could ask them for a casual " +
                "hangout, but you're behind on assignments.",
                "\"Wanna hang out sometime?\"",
                "Focus on your assignments",
                new sbyte[] { -2, 0, 0, 3 },
                new sbyte[] { 2, 0, 0, -2 }
                );
        public static OneTime
            help_prof = new(
                "Professor asks for help",
                "A professor approaches you after class. They need help organizing data for their ongoing " +
                "research project. ",
                "\"Sure, professor.\"",
                "\"Sorry, I'll be busy.\"",
                new sbyte[] { 4, -3, 0, 0 },
                new sbyte[] { -2, 2, 0, 0 }
                );
        public static OneTime
            school_materials = new(
                "School materials required",
                "Your team wants to purchase high-quality materials for a project to get good grades." +
                "If you don't contribute, your grade from peer evaluation will suffer.",
                "Pay it",
                "Say you can't afford it",
                new sbyte[] { 2, 0, -2, 0 },
                new sbyte[] { -1, 0, 0, 0 }
                );
        public static OneTime
            all_nighter = new OneTime(
                "All-Nighter",
                "Your group procrastinated and now the project is due tomorrow. You can pull an all-nighter to " +
                "finish it or suffer with a low grade.",
                "Stay up and finish",
                "Get sleep, take the penalty",
                new sbyte[] { 2, -5, 0, 0 },
                new sbyte[] { -3, 2, 0, 0 } 
                );
        public static OneTime
            plagiarism_request = new OneTime(
                "Plagiarism Request",
                "A friend asks to copy your essay for a difficult class.",
                "Let them",
                "Refuse",
                new sbyte[] { -5, 0, 0, 3 }, 
                new sbyte[] { 0, 3, 0, -2 }
                );
        public static OneTime
            textbook_crisis = new OneTime(
                "Textbook Crisis",
                "Your required textbook costs P3,500. You can either buy it or share with a classmate.",
                "Buy it",
                "Share with a classmate",
                new sbyte[] { 4, 0, -2, 0 }, 
                new sbyte[] { 2, 0, 0, -2 }
            );
        public static OneTime
            freelance_offer = new OneTime(
                "Freelance Offer",
                "You're offered a freelance gig that pays well but would require skipping classes for a week.",
                "Take the job",
                "Focus on school",
                new sbyte[] { -5, 0, 6, 0 },
                new sbyte[] { 2, 0, 0, 0 }
                );
        public static OneTime
            broken_phone = new OneTime(
                "Broken phone",
                "You dropped your phone into water and now it won't open. Even repair shops can't fix it.",
                "Buy a new one immediately",
                "Save up over time",
                new sbyte[] { 0, 0, -4, 0 },
                new sbyte[] { 0, -2, -2, -2 }
                );
        public static OneTime
            unpaid_internship = new OneTime(
                "Unpaid Internship Offer",
                "A prestigious company offers an unpaid internship. It would look great on your resume " +
                "but cost you time and money.",
                "Accept the internship",
                "Reject",
                new sbyte[] { 6, -3, -2, 3 },
                new sbyte[] { 0, -2, 0, 0 }
                );
        public static OneTime
            diet_choice = new OneTime(
                "Ramen or Rice?",
                "Your food budget is running low. You can either eat ramen fpr a week or endure with " +
                "just plain rice to save more.",
                "Eat ramen",
                "Eat plain rice",
                new sbyte[] { 0, -2, 0, 0 },
                new sbyte[] { 0, -4, 2, 0 }
                );
        public static OneTime
            online_surveys = new OneTime(
                "Paid Online Surveys",
                "A site pays small amounts for completing surveys. It’s boring but easy money between classes.",
                "Grind surveys",
                "Not worth time",
                new sbyte[] { 0, -2, 3, 0 },  
                new sbyte[] { 0, 2, 0, 0 }    
                );
        public static OneTime
            resell_flip = new OneTime(
                "Resell Opportunity",
                "You find a vintage gaming console at a thrift store for cheap. You know you could " +
                "flip it online for profit.",
                "Leave it",
                "Buy and resell",
                new sbyte[] { 0, 0, 0, 0 },
                new sbyte[] { 0, 0, 2, 0 }
                );
        public static OneTime
            course_drop = new OneTime(
                "Course Drop",
                "Your project partner dropped the course without notice. You must now complete a 2-person project " +
                "alone in 3 days.",
                "Beg for an extension",
                "Do it all yourself",
                new sbyte[] { -2, -2, 0, 0 },
                new sbyte[] { 2, -4, 0, 0 }
                );
        public static OneTime
            academic_probation = new OneTime(
                "Academic Probation Warning",
                "Your grade in a subject dipped below passing. You must meet with an advisor and " +
                "improve next term or face suspension.",
                "Hire a tutor",
                "Self-study intensely",
                new sbyte[] { 2, -2, -4, 0 },
                new sbyte[] { -2, -3, 0, 0 }
                );
        public static OneTime
            project_deadline = new OneTime(
                "Project Deadline Crisis",
                "Your advisor moved the deadline of a project up by two weeks. You must sacrifice sleep and " +
                "social time to finish on time.",
                "Health is wealth",
                "Pull all-nighters",
                new sbyte[] { -4, 2, 0, 0 },
                new sbyte[] { 3, -5, 0, -2 }
                );
        public static OneTime
            burnout = new OneTime(
                "Academic Burnout",
                "You’ve been studying for weeks without a break. Your focus is fading, and motivation is gone.",
                "Push through the fatigue",
                "Take a mental health day",
                new sbyte[] { 2, -4, 0, 0 },
                new sbyte[] { -2, 3, 0, 0 }
                );
        public static OneTime
            procrastination_guilt = new OneTime(
                "Procrastination Guilt",
                "You wasted the day scrolling and now feel guilty. The work is still there, looming.",
                "Work late to catch up",
                "Accept it and try again tomorrow",
                new sbyte[] { 2, -3, 0, 0 }, 
                new sbyte[] { -2, 2, 0, 0 }
                );
        public static OneTime
            friend_forgot_plans = new OneTime(
                "Friend Forgot Your Plans",
                "Your friend completely forgot you were supposed to meet. They don’t even text an apology.",
                "Confront them",
                "Let it go",
                new sbyte[] { 0, 3, 0, -3 }, 
                new sbyte[] { 0, -3, 0, 2 }
                );
        public static OneTime
            group_chat_left_out = new OneTime(
                "Left Out of Group Chat",
                "You notice your friends made plans in a chat you’re not included in. They post pictures without you.",
                "Ask to be included next time",
                "Ignore it and act fine",
                new sbyte[] { 0, -2, 0, -2 },  
                new sbyte[] { 0, -3, 0, 0 }
                );
        public static OneTime
            gossip = new OneTime(
                "Gossip",
                "You overhear classmates spreading an exaggerated story about you. It’s starting to affect your " +
                "reputation.",
                "Confront the gossip directly",
                "Let it die down naturally",
                [0, 2, 0, -3], 
                [0, -2, 0, -2]
                );
        public static OneTime
            oracle = new(
                "Oracle",
                "You are strolling outside the campus one day when you spot an antique shop you have never " +
                "seen before. You enter, intrigued. As you walk between the shelves, you can't help but " +
                "feel a sense of deja vu. One item in particular pulls your attention. You stop walking, " +
                "drawn to the allure of it. You feel as if you're staring into the void. Not just " +
                "darkness, but nothingness itself. You reach out to touch it, but the man who owns the " +
                "shop stops you.",
                "“I'll buy it”",
                "Leave",
                [-10, -10, -15, -10],
                [0, 0, 0, 0]
                );
    }
}
