using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Entities
{
    public class Olympic
    {
        public int Year { get; set; }
        public City HostCity {get; set;}
        public EventType EventType { get; set; }
        public List<CountryParticipant> participants = new List<CountryParticipant>();
    }
}
