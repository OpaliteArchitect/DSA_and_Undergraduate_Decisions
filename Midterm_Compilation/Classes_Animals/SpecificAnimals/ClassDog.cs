using System.Text;

namespace Classes_Animals.SpecificAnimals
{
    internal class ClassDog : Animal
    {
        public string Breed;
        public string FurColor;
        public bool IsTrained;
        public string FavoriteToy;
        public bool IsServiceDog;

        public ClassDog(string name, int age, int happiness, double weight, bool isCarnivore, string habitat,
            int averageLifespan, string conservationStatus, DietType diet, double maxSpeed,
            string breed, string furColor, bool isTrained, string favoriteToy, bool isServiceDog)
            : base(name, age, happiness, weight, isCarnivore, habitat, averageLifespan, conservationStatus, diet, maxSpeed)
        {
            Breed = breed;
            FurColor = furColor;
            IsTrained = isTrained;
            FavoriteToy = favoriteToy;
            IsServiceDog = isServiceDog;
        }

        public string PrintAttributes()
        {
            StringBuilder sb = new();
            sb.AppendLine(PrintBaseAttributes());
            sb.AppendLine($"Breed: {Breed}");
            sb.AppendLine($"Fur Color: {FurColor}");
            sb.AppendLine($"Is Trained: {IsTrained}");
            sb.AppendLine($"Favorite Toy: {FavoriteToy}");
            sb.AppendLine($"Is Service Dog: {IsServiceDog}");
            sb.AppendLine();
            sb.AppendLine(MakeSound());

            return sb.ToString();
        }

        public override string MakeSound()
        {
            return $"{Name} barks: Woof!";
        }
    }
}
