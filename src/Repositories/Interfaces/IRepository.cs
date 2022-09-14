using System.Collections.Generic;
using HogwartsHouses.Models;

namespace HogwartsHouses.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        HashSet<T> GetAll();
        void Add(Room room);
    }
}
