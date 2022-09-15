using System.Collections.Generic;
using HogwartsHouses.Models;

namespace HogwartsHouses.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        HashSet<T> GetAll();
        void Add(Room room);
        Room Get(int id);
        void Delete(int id);
        void Update(int id, Room room);
    }
}
