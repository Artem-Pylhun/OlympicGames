using OlympicGames.Core.Entities;
using OlympicGames.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OlympicGames.Services.OlympicDataManagers
{
    public class JsonOlympicDataManager : IOlympicDataManager
    {
        private List<Olympic> olympics = new List<Olympic>();
        public bool IsChanged { get; set; } = false;

        public string Filter => "JSON files (*.json)|*.json";

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
            string json = File.ReadAllText(path);
            List<Olympic> olympics = JsonSerializer.Deserialize<List<Olympic>>(json);
            this.olympics = olympics;
        }

        public void Write(string path)
        {
            string json = JsonSerializer.Serialize(olympics, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }
    }
}
