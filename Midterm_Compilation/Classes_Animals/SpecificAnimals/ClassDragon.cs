using System.Text;

namespace Classes_Animals.SpecificAnimals
{
    internal class ClassDragon : Animal
    {
        public string ScaleColor;
        public bool CanFly;
        public bool BreathesFire;
        public double WingSpan;
        public int HoardSize;

        public ClassDragon(string name, int age, int happiness, double weight, bool isCarnivore, string habitat,
            int averageLifespan, string conservationStatus, DietType diet, double maxSpeed,
            string scaleColor, bool canFly, bool breathesFire, double wingSpan, int hoardSize)
            : base(name, age, happiness, weight, isCarnivore, habitat, averageLifespan, conservationStatus, diet, maxSpeed)
        {
            ScaleColor = scaleColor;
            CanFly = canFly;
            BreathesFire = breathesFire;
            WingSpan = wingSpan;
            HoardSize = hoardSize;
        }
        public string PrintAttributes()
        {
            StringBuilder sb = new();
            sb.AppendLine(PrintBaseAttributes());
            sb.AppendLine($"ScaleColor: {ScaleColor}");
            sb.AppendLine($"Can Fly: {CanFly}");
            sb.AppendLine($"Breathes Fire: {BreathesFire}");
            sb.AppendLine($"Wing Span: {WingSpan}");
            sb.AppendLine($"Horde Size: {HoardSize}");
            sb.AppendLine();
            sb.AppendLine(MakeSound());

            return sb.ToString();
        }

        public override string MakeSound()
        {
            return $"{Name} roars mightily!";
        }
    }
}
