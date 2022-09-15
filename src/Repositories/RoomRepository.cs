using System.Collections.Generic;
using HogwartsHouses.Models;
using HogwartsHouses.Repositories.Interfaces;
using HogwartsHouses.Services;

namespace HogwartsHouses.Repositories
{
    public class RoomRepository : IRepository<Room>
    {
        private RoomInMemoryDb RoomInMemoryDb { get; }

        public RoomRepository()
        {
            RoomInMemoryDb = new RoomInMemoryDb();
        }

        public HashSet<Room> GetAll()
        {
            return RoomInMemoryDb.Rooms;
        }

        public void Add(Room room)
        {
            RoomInMemoryDb.AddRoom(room);
        }

        public Room Get(int id)
        {
            return RoomInMemoryDb.GetRoomById(id);
        }

        public void Delete(int id)
        {
            RoomInMemoryDb.DeleteRoomById(id);
        }

        public void Update(int id, Room room)
        {
            RoomInMemoryDb.UpdateRoomById(id, room);
        }
    }
}
