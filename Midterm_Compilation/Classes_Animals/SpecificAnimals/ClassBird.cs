using System.Text;
using static Midterm_Compilation.PolishUI;

namespace Classes_Animals.SpecificAnimals
{
    internal class ClassBird : Animal
    {
        public double WingSpan;
        public bool CanFly;
        public string FeatherColor;
        public string BeakType;
        public string MigrationPattern;

        public ClassBird(string name, int age, int happiness, double weight, bool isCarnivore, string habitat,
            int averageLifespan, string conservationStatus, DietType diet, double maxSpeed,
            double wingSpan, bool canFly, string featherColor, string beakType, string migrationPattern)
            : base(name, age, happiness, weight, isCarnivore, habitat, averageLifespan, conservationStatus, diet, maxSpeed)
        {
            WingSpan = wingSpan;
            CanFly = canFly;
            FeatherColor = featherColor;
            BeakType = beakType;
            MigrationPattern = migrationPattern;
        }

        public string PrintAttributes()
        {
            StringBuilder sb = new();
            sb.AppendLine(PrintBaseAttributes());
            sb.AppendLine($"Wing Span: {WingSpan}");
            sb.AppendLine($"Can Fly: {CanFly}");
            sb.AppendLine($"Feather Color: {FeatherColor}");
            sb.AppendLine($"Beak Type: {BeakType}");
            sb.AppendLine($"Migration Pattern: {MigrationPattern}");
            sb.AppendLine();
            sb.AppendLine(MakeSound());

            return sb.ToString();
        }

        public override string MakeSound()
        {
            return $"{Name} chirps or sings.";
        }
    }
}
