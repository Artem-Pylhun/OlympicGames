using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Core.Entities
{
    public class Olympic
    {
        public int Year { get; set; }
        public City HostCity {get; set;}
        public EventType EventType { get; set; }
        public List<CountryParticipant> participants { get; set; } = new List<CountryParticipant>();
        public override string ToString()
        {
            return $"Year: {Year}, Host: {HostCity}, Type: {EventType.Title}";
        }
        public string ToWriteString()
        {
            string result = "";
            result += $"{Year}|{HostCity.Title}-{HostCity.Location}-{HostCity.Population}|{EventType.Title}|";

            result += string.Join('-', participants
                .Select(p => $"{p.Title},{p.Wins},{p.Losses},{string.Join(';', p.Athletes
                .Select(a => $"{a.FullName}#{a.Age}#{a.IsMale}"))}"));

            return result ;
        }
        public string ToCsvString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Year},{HostCity.Title},{HostCity.Location},{HostCity.Population},{EventType.Title}");

            foreach (var participant in participants)
            {
                sb.Append($",{participant.Title},{participant.Wins},{participant.Losses}");
                sb.Append($",{participant.AthletesToString()}");
            }

            return sb.ToString();
        }
    }
}
