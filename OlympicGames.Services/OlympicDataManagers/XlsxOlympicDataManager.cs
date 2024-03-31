using OlympicGames.Core.Entities;
using OlympicGames.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Services.OlympicDataManagers
{
    public class XlsxOlympicDataManager : IOlympicDataManager
    {
        public bool IsChanged { get; set; } = false;

        public string Filter => throw new NotImplementedException();

        public void Add(Olympic entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Olympic entity)
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

        public void Update(Olympic oldEntity, Olympic newEntity)
        {
            throw new NotImplementedException();
        }

        public void Write(string path)
        {
            throw new NotImplementedException();
        }
    }
}
