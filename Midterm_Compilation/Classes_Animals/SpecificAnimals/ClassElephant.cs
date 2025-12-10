using System.Text;

namespace Classes_Animals.SpecificAnimals
{
    internal class ClassElephant : Animal
    {
        public double TuskLength;
        public double TrunkLength;
        public string Species;
        public bool IsDomesticated;
        public int HerdSize;

        public ClassElephant(string name, int age, int happiness, double weight, bool isCarnivore, string habitat,
            int averageLifespan, string conservationStatus, DietType diet, double maxSpeed,
            double tuskLength, double trunkLength, string species, bool isDomesticated, int herdSize)
            : base(name, age, happiness, weight, isCarnivore, habitat, averageLifespan, conservationStatus, diet, maxSpeed)
        {
            TuskLength = tuskLength;
            TrunkLength = trunkLength;
            Species = species;
            IsDomesticated = isDomesticated;
            HerdSize = herdSize;
        }
        public string PrintAttributes()
        {
            StringBuilder sb = new();
            sb.AppendLine(PrintBaseAttributes());
            sb.AppendLine($"Tusk Length: {TuskLength}");
            sb.AppendLine($"Trunk Length: {TrunkLength}");
            sb.AppendLine($"Species: {Species}");
            sb.AppendLine($"Is Domesticated: {IsDomesticated}");
            sb.AppendLine($"Herd Size: {HerdSize}");
            sb.AppendLine();
            sb.AppendLine(MakeSound());

            return sb.ToString();
        }

        public override string MakeSound()
        {
            return $"{Name} trumpets loudly!";
        }
    }
}
