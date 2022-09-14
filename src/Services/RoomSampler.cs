using System;
using System.Collections.Generic;
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
    }
}
