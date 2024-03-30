namespace OlympicGames.Entities
{
    public class Athlete
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public bool IsMale { get; set; }
        public string Nationality { get; set; }

        public override string ToString()
        {
            return $"{FullName},{Age} - {Nationality}, {Male()}";
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