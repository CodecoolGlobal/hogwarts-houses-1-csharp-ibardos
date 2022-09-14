using System.Collections.Generic;
using HogwartsHouses.Models;

namespace HogwartsHouses.Services.Interfaces
{
    public interface IRoomService
    {
        HashSet<Room> GetAllRooms();
        void AddRoom(Room room);
        Room GetRoomById(int id);
        int? DeleteRoomById(int id);
    }
}
