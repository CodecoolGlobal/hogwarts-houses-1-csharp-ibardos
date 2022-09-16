using System.Collections.Generic;

namespace HogwartsHouses.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        HashSet<T> GetAll();
        void Add(T item);
        T Get(int id);
        void Delete(int id);
        void Update(int id, T item);
    }
}