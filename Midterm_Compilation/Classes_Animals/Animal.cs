using System.Text;
using Midterm_Compilation;

namespace Classes_Animals
{
    public enum DietType
    {
        Herbivore,
        Carnivore,
        Omnivore
    }
    internal class Animal
    {
        public string Name;
        public int Age;
        public int Happiness;
        public double Weight;
        public bool IsCarnivore;
        public string Habitat;
        public int AverageLifespan;
        public string ConservationStatus;
        public DietType Diet;
        public double MaxSpeed;
        public Animal(string name, int age, int happiness, double weight, bool isCarnivore, string habitat,
              int averageLifespan, string conservationStatus, DietType diet, double maxSpeed)
        {
            Name = name;
            Age = age;
            Happiness = happiness;
            Weight = weight;
            IsCarnivore = isCarnivore;
            Habitat = habitat;
            AverageLifespan = averageLifespan;
            ConservationStatus = conservationStatus;
            Diet = diet;
            MaxSpeed = maxSpeed;
        }
        public virtual string MakeSound()
        {
            return $"{Name} makes a generic animal sound.";
        }
        protected string PrintBaseAttributes()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Age: {Age} years old");
            sb.AppendLine($"Happiness: {Happiness}");
            sb.AppendLine($"Weight: {Weight} kg");
            sb.AppendLine($"Is Carnivore: {IsCarnivore}");
            sb.AppendLine($"Habitat: {Habitat}");
            sb.AppendLine($"Average Lifespan: {AverageLifespan}");
            sb.AppendLine($"Conservation Status: {ConservationStatus}");
            sb.AppendLine($"Diet: {Diet}");
            sb.AppendLine($"Max Speed: {MaxSpeed}");
            return sb.ToString();
        }
        protected static void DisplayInBox(StringBuilder content)
        {
            content.AppendLine("\n\n[<-] Previous  [->] Next  [ESC] Exit");
            PolishUI.DisplayInBox(content.ToString());
        }
    }
}
