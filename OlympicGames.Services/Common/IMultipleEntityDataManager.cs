using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Services.Common
{
    public interface IMultipleEntityDataManager : IFilter
    {
        void SetAll<T>(IEnumerable<T> entities);
        void Read(string path);
        void Write(string path);
        IEnumerable<T> GetAll<T>();
        bool IsChanged { get; }
        void Add(object entity);

        void Delete(object entity);
        void Update(object oldEntity, object newEntity);
    }
}
