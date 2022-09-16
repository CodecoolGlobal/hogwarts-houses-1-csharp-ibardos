using System;
using System.Collections.Generic;
using System.Linq;
using HogwartsHouses.Models;
using HogwartsHouses.Models.Types;

namespace HogwartsHouses.Data
{
    public class RoomInMemoryDb
    {
        public HashSet<Room> Rooms { get; private set; }
        private StudentInMemoryDb _studentInMemoryDb;

        public RoomInMemoryDb()
        {
            _studentInMemoryDb = new();
            Initialize();
            
            AddResident(0, _studentInMemoryDb.GetStudentById(0));
            AddResident(1, _studentInMemoryDb.GetStudentById(1));
            AddResident(1, _studentInMemoryDb.GetStudentById(2));
        }

        public void Initialize()
        {
            Rooms = new HashSet<Room>();

            for (int i = 0; i < 10; i++)
            {
                AddRoom(new Room());
            }
        }

        private void AddResident(int roomId, Student student)
        {
            Room roomToAdd = GetRoomById(roomId);

            if (roomToAdd.IsOccupied is false)
            {
                roomToAdd.Residents.Add(student);
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