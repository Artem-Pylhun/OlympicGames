using OlympicGames.Core.Entities;
using OlympicGames.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Services.OlympicDataManagers
{
    public class TxtOlympicDataManager : IOlympicDataManager
    {
        private List<Olympic> olympics = new List<Olympic>();
        public bool IsChanged { get; set; } = false;

        public string Filter => "TXT files (*.txt)|*.txt";

        public void Add(Olympic entity)
        {
            olympics.Add(entity);
        }

        public void Delete(Olympic entity)
        {
            olympics.Remove(entity);
        }
        public void Update(Olympic oldEntity, Olympic newEntity)
        {
            int index = olympics.IndexOf(oldEntity);
            olympics[index] = newEntity;
        }

        public IEnumerable<Olympic> GetAll()
        {
            return olympics;
        }
        public void SetAll(IEnumerable<Olympic> entities)
        {
            olympics = entities.ToList();
        }

        public void Read(string path)
        {
            List<Olympic> olympics = new List<Olympic>();

            using (var reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    if (parts.Length >= 4)
                    {
                        var olympic = new Olympic
                        {
                            Year = int.Parse(parts[0]),
                            HostCity = ParseCity(parts[1]),
                            EventType = new EventType { Title = parts[2] },
                            participants = ParseParticipants(parts[3])
                        };
                        olympics.Add(olympic);
                    }
                }
            }

            this.olympics = olympics;
        }

        public static City ParseCity(string cityString)
        {
            var parts = cityString.Split('-');
            if (parts.Length >= 3)
            {
                return new City
                {
                    Title = parts[0],
                    Location = parts[1],
                    Population = int.Parse(parts[2])
                };
            }
            return null;
        }

        public static List<CountryParticipant> ParseParticipants(string participantsString)
        {
            var participantStrings = participantsString.Split('-');
            var participants = new List<CountryParticipant>();

            foreach (var participantString in participantStrings)
            {
                var participantParts = participantString.Split(',');
                if (participantParts.Length >= 4)
                {
                    var participant = new CountryParticipant
                    {
                        Title = participantParts[0],
                        Wins = int.Parse(participantParts[1]),
                        Losses = int.Parse(participantParts[2]),
                        Athletes = ParseAthletes(participantParts[3])
                    };
                    participants.Add(participant);
                }
            }

            return participants;
        }

        public static List<Athlete> ParseAthletes(string athletesString)
        {
            var athleteStrings = athletesString.Split(';');
            var athletes = new List<Athlete>();

            foreach (var athleteString in athleteStrings)
            {
                var athleteParts = athleteString.Split('#');
                if (athleteParts.Length >= 3)
                {
                    var athlete = new Athlete
                    {
                        FullName = athleteParts[0],
                        Age = int.Parse(athleteParts[1]),
                        IsMale = bool.Parse(athleteParts[2])
                    };
                    athletes.Add(athlete);
                }
            }

            return athletes;
        }

        public void Write(string path)
        {
            using (var writer = new StreamWriter(path))
            {
                writer.WriteLine(string.Join("\r\n", olympics.Select(o => o.ToWriteString())));
            }
        }
    }
}
