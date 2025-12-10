using Classes_Animals.SpecificAnimals;
using static Midterm_Compilation.PolishUI;

namespace Classes_Animals
{
    public static class Classes_Animals
    {
        public static void Run()
        {
            List<object> animals = new List<object>
            {  new ClassBird("Polly", 2, 80, 0.9, false, "Tropical", 15, "Least Concern",
                DietType.Omnivore, 12.5, 0.25, true, "Green", "Curved", "Seasonal"),
                new ClassBunny("Thumper", 1, 90, 1.8, false, "Meadow", 9, "Least Concern",
                DietType.Herbivore, 6.0, "White", 0.12, true, true, "Holland Lop"),
                new ClassCat("Mittens", 3, 85, 4.0, true, "House", 15, "Domesticated",
                DietType.Carnivore, 30.0, "Siamese", "Striped", true, 9, true),
                new ClassDog("Buddy", 4, 95, 20.0, true, "House", 13, "Domesticated",
                DietType.Omnivore, 40.0, "Golden Retriever", "Golden", true, "Ball", false),
                new ClassDragon("Smaug", 300, 70, 5000, true, "Mountain", 1000, "Mythical",
                DietType.Carnivore, 80.0, "Red", true, true, 30.0, 1000),
                new ClassElephant("Dumbo", 25, 80, 5400, false, "Savannah", 70, "Vulnerable",
                DietType.Herbivore, 25.0, 1.5, 2.0, "African", false, 12),
                new ClassFish("Nemo", 1, 70, 0.2, false, "Coral Reef", 5, "Not Endangered",
                DietType.Omnivore, 5.0, "Clownfish", "Saltwater", true, "Striped", 60.0),
                new ClassHorse("Spirit", 5, 85, 450, false, "Grassland", 30, "Domesticated",
                DietType.Herbivore, 88.0, "Arabian", "Black", true, 1.6, true),
                new ClassHuman("Alice", 21, 75, 55, false, "City", 80, "Least Concern",
                DietType.Omnivore, 37.0, "Filipino", "Student", "Brown", "Black", "English"),
                new ClassPig("Porky", 2, 80, 150, false, "Farm", 15, "Domesticated",
                DietType.Omnivore, 10.0, "Yorkshire", "Pink", true, true, 0.3)
            };

            int currentIndex = 0;
            ConsoleKey key;

            do
            {
                Console.Clear();

                // Display current animal
                string navigation = "[<-] Previous  [->] Next  [ESC] Exit";
                dynamic currentAnimal = animals[currentIndex];
                string content = currentAnimal.PrintAttributes();

                string[] lines = content.Split('\n');
                int longestLineLength = 0;
                foreach (string line in lines)
                {
                    if (line.Length > longestLineLength)
                    {
                        longestLineLength = line.Length;
                    }
                }
                if (navigation.Length > longestLineLength) longestLineLength = navigation.Length;

                const int horizontalPadding = 4;
                const int verticalPadding = 2;
                int menuWidth = longestLineLength + horizontalPadding;
                int menuHeight = lines.Length + verticalPadding + 1;
                int leftPadding = (windowsWidth - menuWidth) / 2;
                int topPadding = (windowsHeight - menuHeight) / 2;

                DrawBox(leftPadding, topPadding, menuWidth, menuHeight, ConsoleColor.DarkGray, 2, menuHeight - 3);

                for (int i = 0; i < lines.Length; i++)
                {
                    SafeSetCursorPosition(leftPadding + horizontalPadding / 2, topPadding + 1 + i);
                    Console.Write(lines[i]);
                }

                SafeSetCursorPosition(leftPadding + horizontalPadding / 2, topPadding + 1 + lines.Length);
                Console.Write(navigation);

                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.RightArrow && currentIndex < animals.Count - 1)
                    currentIndex++;
                else if (key == ConsoleKey.LeftArrow && currentIndex > 0)
                    currentIndex--;

            } while (key != ConsoleKey.Escape);
        }
    }

}
