using System.Text;

namespace Classes_Animals.SpecificAnimals
{
    internal class ClassHorse : Animal
    {
        public string Breed;
        public string ManeColor;
        public bool IsRaceHorse;
        public double Height;
        public bool IsDomesticated;

        public ClassHorse(string name, int age, int happiness, double weight, bool isCarnivore, string habitat,
            int averageLifespan, string conservationStatus, DietType diet, double maxSpeed,
            string breed, string maneColor, bool isRaceHorse, double height, bool isDomesticated)
            : base(name, age, happiness, weight, isCarnivore, habitat, averageLifespan, conservationStatus, diet, maxSpeed)
        {
            Breed = breed;
            ManeColor = maneColor;
            IsRaceHorse = isRaceHorse;
            Height = height;
            IsDomesticated = isDomesticated;
        }
        public string PrintAttributes()
        {
            StringBuilder sb = new();
            sb.AppendLine(PrintBaseAttributes());
            sb.AppendLine($"Breed: {Breed}");
            sb.AppendLine($"Mane Color: {ManeColor}");
            sb.AppendLine($"Is Racehorse: {IsRaceHorse}");
            sb.AppendLine($"Height: {Height}");
            sb.AppendLine($"Is Domesticated: {IsDomesticated}");
            sb.AppendLine();
            sb.AppendLine(MakeSound());

            return sb.ToString();
        }

        public override string MakeSound()
        {
            return $"{Name} neighs!";
        }
    }
}
