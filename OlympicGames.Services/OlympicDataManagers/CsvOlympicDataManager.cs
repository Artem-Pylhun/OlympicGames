using OlympicGames.Core.Entities;
using OlympicGames.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Services.OlympicDataManagers
{
    public class CsvOlympicDataManager : IOlympicDataManager
    {
        private List<Olympic> olympics = new List<Olympic>();
        public bool IsChanged { get; set; } = false;

        public string Filter => "CSV files (*.csv)|*.csv";

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
                    var parts = line.Split(',');
                    if (parts.Length >= 5)
                    {
                        var olympic = new Olympic
                        {
                            Year = int.Parse(parts[0]),
                            HostCity = new City
                            {
                                Title = parts[1],
                                Location = parts[2],
                                Population = int.Parse(parts[3])
                            },
                            EventType = new EventType { Title = parts[4] },
                            participants = ParseParticipants(parts.Skip(5).ToArray())
                        };
                        olympics.Add(olympic);
                    }
                }
            }

            this.olympics = olympics;
        }
        public static List<CountryParticipant> ParseParticipants(string[] participantParts)
        {
            List<CountryParticipant> participants = new List<CountryParticipant>();

            for (int i = 0; i < participantParts.Length; i += 4)
            {
                if (i + 3 <= participantParts.Length)
                {
                    var participant = new CountryParticipant
                    {
                        Title = participantParts[i],
                        Wins = int.Parse(participantParts[i + 1]),
                        Losses = int.Parse(participantParts[i + 2]),
                        Athletes = ParseAthletes(participantParts[i + 3])
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
                foreach (var olympic in olympics)
                {
                    writer.WriteLine(olympic.ToCsvString());
                }
            }
        }
    }
}
