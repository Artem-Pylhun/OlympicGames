using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Entities
{
    public class CountryParticipant
    {
        public string Title { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public List<Athlete> Athletes { get; set; } = new List<Athlete>();
    }
}
