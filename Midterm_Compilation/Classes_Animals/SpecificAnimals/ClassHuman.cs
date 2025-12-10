using System.Text;

namespace Classes_Animals.SpecificAnimals
{
    internal class ClassHuman : Animal
    {
        public string Nationality;
        public string Occupation;
        public string EyeColor;
        public string HairColor;
        public string Language;

        public ClassHuman(string name, int age, int happiness, double weight, bool isCarnivore, string habitat,
            int averageLifespan, string conservationStatus, DietType diet, double maxSpeed,
            string nationality, string occupation, string eyeColor, string hairColor, string language)
            : base(name, age, happiness, weight, isCarnivore, habitat, averageLifespan, conservationStatus, diet, maxSpeed)
        {
            Nationality = nationality;
            Occupation = occupation;
            EyeColor = eyeColor;
            HairColor = hairColor;
            Language = language;
        }
        public string PrintAttributes()
        {
            StringBuilder sb = new();
            sb.AppendLine(PrintBaseAttributes());
            sb.AppendLine($"Nationality: {Nationality}");
            sb.AppendLine($"Occupation: {Occupation}");
            sb.AppendLine($"Eye Color: {EyeColor}");
            sb.AppendLine($"Hair Color: {HairColor}");
            sb.AppendLine($"Language: {Language}");
            sb.AppendLine();
            sb.AppendLine(MakeSound());

            return sb.ToString();
        }

        public override string MakeSound()
        {
            return $"{Name} speaks a word.";
        }
    }
}
