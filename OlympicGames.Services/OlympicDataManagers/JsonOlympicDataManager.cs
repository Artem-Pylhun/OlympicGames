using OlympicGames.Core.Entities;
using OlympicGames.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Services.OlympicDataManagers
{
    public class JsonOlympicDataManager : IOlimpicDataManager
    {
        public bool IsChanged => throw new NotImplementedException();

        public string Filter => throw new NotImplementedException();

        public void Add(object entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(object entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Olympic> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Read(string path)
        {
            throw new NotImplementedException();
        }

        public void SetAll(IEnumerable<Olympic> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(object oldEntity, object newEntity)
        {
            throw new NotImplementedException();
        }

        public void Write(string path)
        {
            throw new NotImplementedException();
        }
    }
}
