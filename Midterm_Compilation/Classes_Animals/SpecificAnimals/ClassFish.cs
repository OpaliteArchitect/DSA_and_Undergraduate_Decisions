using System.Text;

namespace Classes_Animals.SpecificAnimals
{
    internal class ClassFish : Animal
    {
        public string Species;
        public string WaterType; 
        public bool IsSchooling;
        public string ScalePattern;
        public double TankSizeNeeded;

        public ClassFish(string name, int age, int happiness, double weight, bool isCarnivore, string habitat,
            int averageLifespan, string conservationStatus, DietType diet, double maxSpeed,
            string species, string waterType, bool isSchooling, string scalePattern, double tankSizeNeeded)
            : base(name, age, happiness, weight, isCarnivore, habitat, averageLifespan, conservationStatus, diet, maxSpeed)
        {
            Species = species;
            WaterType = waterType;
            IsSchooling = isSchooling;
            ScalePattern = scalePattern;
            TankSizeNeeded = tankSizeNeeded;
        }
        public string PrintAttributes()
        {
            StringBuilder sb = new();
            sb.AppendLine(PrintBaseAttributes());
            sb.AppendLine($"Species: {Species}");
            sb.AppendLine($"WaterType: {WaterType}");
            sb.AppendLine($"IsSchooling: {IsSchooling}");
            sb.AppendLine($"Scale Pattern: {ScalePattern}");
            sb.AppendLine($"TankSizeNeeded: {TankSizeNeeded}");
            sb.AppendLine();
            sb.AppendLine(MakeSound());

            return sb.ToString();
        }

        public override string MakeSound()
        {
            return $"{Name} makes bubbling noises.";
        }
    }
}
