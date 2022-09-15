using System;
using System.Collections.Generic;
using System.Linq;
using HogwartsHouses.Models;

namespace HogwartsHouses.Data
{
    public class RoomInMemoryDb
    {
        public HashSet<Room> Rooms { get; private set; }

        public RoomInMemoryDb()
        {
            Initialize();
        }

        public void Initialize()
        {
            Rooms = new HashSet<Room>();

            for (int i = 0; i < 10; i++)
            {
                AddRoom(new Room());
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

        public void DeleteRoomById(int id)
        {
            Rooms.Remove(GetRoomById(id));
        }

        public void UpdateRoomById(int id, Room room)
        {
            DeleteRoomById(id);

            AddRoom(room);
        }
    }
}