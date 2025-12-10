using System.Text;

namespace Classes_Animals.SpecificAnimals
{
    internal class ClassPig : Animal
    {
        public string Breed;
        public string SkinColor;
        public bool IsFarmed;
        public bool LikesMud;
        public double SnoutLength;

        public ClassPig(string name, int age, int happiness, double weight, bool isCarnivore, string habitat,
            int averageLifespan, string conservationStatus, DietType diet, double maxSpeed,
            string breed, string skinColor, bool isFarmed, bool likesMud, double snoutLength)
            : base(name, age, happiness, weight, isCarnivore, habitat, averageLifespan, conservationStatus, diet, maxSpeed)
        {
            Breed = breed;
            SkinColor = skinColor;
            IsFarmed = isFarmed;
            LikesMud = likesMud;
            SnoutLength = snoutLength;
        }
        public string PrintAttributes()
        {
            StringBuilder sb = new();
            sb.AppendLine(PrintBaseAttributes());
            sb.AppendLine($"Breed: {Breed}");
            sb.AppendLine($"Skin Color: {SkinColor}");
            sb.AppendLine($"Is Farmed: {IsFarmed}");
            sb.AppendLine($"Likes Mud: {LikesMud}");
            sb.AppendLine($"Snout Length: {SnoutLength}");
            sb.AppendLine();
            sb.AppendLine(MakeSound());

            return sb.ToString();
        }

        public override string MakeSound()
        {
            return $"{Name} oinks!";
        }
    }
}
