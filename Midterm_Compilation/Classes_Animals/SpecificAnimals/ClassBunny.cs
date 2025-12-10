using System.Text;

namespace Classes_Animals.SpecificAnimals
{
    internal class ClassBunny : Animal
    {
        public string FurColor;
        public double EarLength;
        public bool IsDomestic;
        public bool LikesCarrots;
        public string Breed;

        public ClassBunny(string name, int age, int happiness, double weight, bool isCarnivore, string habitat,
            int averageLifespan, string conservationStatus, DietType diet, double maxSpeed,
            string furColor, double earLength, bool isDomestic, bool likesCarrots, string breed)
            : base(name, age, happiness, weight, isCarnivore, habitat, averageLifespan, conservationStatus, diet, maxSpeed)
        {
            FurColor = furColor;
            EarLength = earLength;
            IsDomestic = isDomestic;
            LikesCarrots = likesCarrots;
            Breed = breed;
        }

        public string PrintAttributes()
        {
            StringBuilder sb = new();
            sb.AppendLine(PrintBaseAttributes());
            sb.AppendLine($"Fur Color: {FurColor}");
            sb.AppendLine($"Ear Length: {EarLength}");
            sb.AppendLine($"Is Domestic: {IsDomestic}");
            sb.AppendLine($"Likes Carrots: {LikesCarrots}");
            sb.AppendLine($"Breed: {Breed}");
            sb.AppendLine();
            sb.AppendLine(MakeSound());

            return sb.ToString();
        }

        public override string MakeSound()
        {
            return $"{Name} thumps softly.";
        }
    }
}
