using System.Collections.Generic;
using HogwartsHouses.Models;
using HogwartsHouses.Repositories;
using HogwartsHouses.Repositories.Interfaces;
using HogwartsHouses.Services.Interfaces;

namespace HogwartsHouses.Services
{
    public class RoomService : IRoomService
    {
        private IRepository<Room> _repository { get; }

        public RoomService(IRepository<Room> repository)
        {
            _repository = repository;
        }

        public HashSet<Room> GetAllRooms()
        {
            return _repository.GetAll();
        }

        public void AddRoom(Room room)
        {
            _repository.Add(room);
        }

        public Room GetRoomById(int id)
        {
            return _repository.Get(id);
        }
    }
}
