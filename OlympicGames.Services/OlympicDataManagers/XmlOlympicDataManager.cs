using OlympicGames.Core.Entities;
using OlympicGames.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OlympicGames.Services.OlympicDataManagers
{
    public class XmlOlympicDataManager : IOlympicDataManager
    {
        private List<Olympic> olympics = new List<Olympic>();
        public bool IsChanged { get; set; } = false;

        public string Filter => "XML files (*.xml)|*.xml";

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

            XDocument xdoc = XDocument.Load(path);
            foreach (var olympicElement in xdoc.Root.Elements("olympic"))
            {
                Olympic olympic = new Olympic
                {
                    Year = int.Parse(olympicElement.Element("Year").Value),
                    HostCity = new City
                    {
                        Title = olympicElement.Element("HostCity").Element("Title").Value,
                        Location = olympicElement.Element("HostCity").Element("Location").Value,
                        Population = int.Parse(olympicElement.Element("HostCity").Element("Population").Value)
                    },
                    EventType = new EventType { Title = olympicElement.Element("EventType").Value },
                    participants = new List<CountryParticipant>()
                };

                foreach (var participantElement in olympicElement.Element("Participants").Elements("Participant"))
                {
                    CountryParticipant participant = new CountryParticipant
                    {
                        Title = participantElement.Element("Title").Value,
                        Wins = int.Parse(participantElement.Element("Wins").Value),
                        Losses = int.Parse(participantElement.Element("Losses").Value),
                        Athletes = new List<Athlete>()
                    };

                    foreach (var athleteElement in participantElement.Element("Athletes").Elements("Athlete"))
                    {
                        Athlete athlete = new Athlete
                        {
                            FullName = athleteElement.Element("FullName").Value,
                            Age = int.Parse(athleteElement.Element("Age").Value),
                            IsMale = bool.Parse(athleteElement.Element("IsMale").Value)
                        };
                        participant.Athletes.Add(athlete);
                    }
                    olympic.participants.Add(participant);
                }

                olympics.Add(olympic);
            }

            this.olympics = olympics;
        }

        public void Write(string path)
        {
            XDocument xdoc = new XDocument(
            new XDeclaration("1.0", "utf-8", "yes"),
            new XElement("olympics")
        );

            foreach (var olympic in olympics)
            {
                XElement olympicElement = new XElement("olympic",
                    new XElement("Year", olympic.Year),
                    new XElement("HostCity",
                        new XElement("Title", olympic.HostCity.Title),
                        new XElement("Location", olympic.HostCity.Location),
                        new XElement("Population", olympic.HostCity.Population)
                    ),
                    new XElement("EventType", olympic.EventType.Title)
                );

                XElement participantsElement = new XElement("Participants");
                foreach (var participant in olympic.participants)
                {
                    XElement participantElement = new XElement("Participant",
                        new XElement("Title", participant.Title),
                        new XElement("Wins", participant.Wins),
                        new XElement("Losses", participant.Losses)
                    );

                    XElement athletesElement = new XElement("Athletes");
                    foreach (var athlete in participant.Athletes)
                    {
                        XElement athleteElement = new XElement("Athlete",
                            new XElement("FullName", athlete.FullName),
                            new XElement("Age", athlete.Age),
                            new XElement("IsMale", athlete.IsMale)
                        );
                        athletesElement.Add(athleteElement);
                    }
                    participantElement.Add(athletesElement);
                    participantsElement.Add(participantElement);
                }
                olympicElement.Add(participantsElement);
                xdoc.Root.Add(olympicElement);
            }

            xdoc.Save(path);
        }
    }
}
