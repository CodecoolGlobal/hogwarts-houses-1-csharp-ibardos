using System;
using System.Collections.Generic;
using System.Linq;
using HogwartsHouses.Models;
using HogwartsHouses.Models.Types;

namespace HogwartsHouses.Services
{
    public class RoomSampler
    {
        public HashSet<Room> Rooms { get; private set; }

        public RoomSampler()
        {
            Initialize();
        }

        public void Initialize()
        {
            Rooms = new HashSet<Room>();
            
            for (int i = 0; i < 10; i++)
            {
                Rooms.Add(new Room());
            }
        }

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }

        public Room GetRoomById(int id)
        {
            try
            {
                return Rooms.First(room => room.Id == id);
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }

        public int? DeleteRoomById(int id)
        {
            try
            {
                Rooms.Remove(GetRoomById(id));
            }
            catch (InvalidOperationException)
            {
                return null;
            }

            return id;
        }

        public void UpdateRoomById(int id, Room room)
        {
            DeleteRoomById(id);

            AddRoom(room);
        }
    }
}
