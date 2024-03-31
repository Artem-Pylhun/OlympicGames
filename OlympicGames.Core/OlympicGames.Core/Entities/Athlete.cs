namespace OlympicGames.Core.Entities
{
    public class Athlete
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public bool IsMale { get; set; }

        public override string ToString()
        {
            return $"{FullName},{Age}, {Male()}";
        }
        public string Male()
        {
            if (IsMale)
            {
                return "Male";
            }
            return "Female";
        }
    }
}