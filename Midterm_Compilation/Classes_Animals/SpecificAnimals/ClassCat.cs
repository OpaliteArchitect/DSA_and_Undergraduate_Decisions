using System.Text;

namespace Classes_Animals.SpecificAnimals
{
    internal class ClassCat : Animal
    {
        public string Breed;
        public string FurPattern;
        public bool IsIndoor;
        public int LivesLeft;
        public bool LikesCatnip;

        public ClassCat(string name, int age, int happiness, double weight, bool isCarnivore, string habitat,
            int averageLifespan, string conservationStatus, DietType diet, double maxSpeed,
            string breed, string furPattern, bool isIndoor, int livesLeft, bool likesCatnip)
            : base(name, age, happiness, weight, isCarnivore, habitat, averageLifespan, conservationStatus, diet, maxSpeed)
        {
            Breed = breed;
            FurPattern = furPattern;
            IsIndoor = isIndoor;
            LivesLeft = livesLeft;
            LikesCatnip = likesCatnip;
        }
        public string PrintAttributes()
        {
            StringBuilder sb = new();
            sb.AppendLine(PrintBaseAttributes());
            sb.AppendLine($"Breed: {Breed}");
            sb.AppendLine($"Fur Pattern: {FurPattern}");
            sb.AppendLine($"Is Indoor: {IsIndoor}");
            sb.AppendLine($"Lives Left: {LivesLeft}");
            sb.AppendLine($"Likes Catnip: {LikesCatnip}");
            sb.AppendLine();
            sb.AppendLine(MakeSound());

            return sb.ToString();
        }

        public override string MakeSound()
        {
            return $"{Name} meows: Meow!";
        }
    }
}
