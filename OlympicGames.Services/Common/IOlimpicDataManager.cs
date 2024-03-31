using OlympicGames.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Services.Common
{
    public interface IOlimpicDataManager : IFilter
    {
        void SetAll(IEnumerable<Olympic> entities);
        void Read(string path);
        void Write(string path);
        IEnumerable<Olympic> GetAll();
        bool IsChanged { get; }
        void Add(object entity);

        void Delete(object entity);
        void Update(object oldEntity, object newEntity);
    }
}
