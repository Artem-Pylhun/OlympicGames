using OlympicGames.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Services.Common
{
    public interface IOlympicDataManager : IFilter
    {
        void SetAll(IEnumerable<Olympic> entities);
        void Read(string path);
        void Write(string path);
        IEnumerable<Olympic> GetAll();
        bool IsChanged { get; set; }
        void Add(Olympic entity);

        void Delete(Olympic entity);
        void Update(Olympic oldEntity, Olympic newEntity);
    }
}
