using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Core.Entities
{
    public class CountryParticipant
    {
        public string Title { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public List<Athlete> Athletes { get; set; } = new List<Athlete>();

        public override string ToString()
        {
            return $"{Title}, W/L: {Wins} - {Losses}";
        }
        public string AthletesToString()
        {
            return string.Join(";", Athletes.Select(a => $"{a.FullName}#{a.Age}#{a.IsMale}"));
        }
    }
}
