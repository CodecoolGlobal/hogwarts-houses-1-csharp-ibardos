using System.Collections.Generic;
using HogwartsHouses.Models;
using HogwartsHouses.Repositories.Interfaces;
using HogwartsHouses.Services;

namespace HogwartsHouses.Repositories
{
    public class RoomSampledRepository : IRepository<Room>
    {
        private RoomSampler _roomSampler { get; }

        public RoomSampledRepository()
        {
            _roomSampler = new RoomSampler();
        }

        public HashSet<Room> GetAll()
        {
            return _roomSampler.Rooms;
        }

        public void Add(Room room)
        {
            _roomSampler.AddRoom(room);
        }

        public Room Get(int id)
        {
            return _roomSampler.GetRoomById(id);
        }

        public void Delete(int id)
        {
            _roomSampler.DeleteRoomById(id);
        }

        public void Update(int id, Room room)
        {
            _roomSampler.UpdateRoomById(id, room);
        }
    }
}
