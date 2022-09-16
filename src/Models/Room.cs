using System.Collections.Generic;
using HogwartsHouses.Models.Types;

namespace HogwartsHouses.Models
{
    [System.Serializable]
    public class Room
    {
        private static int _lastId = 1;
        public int Id { get; set; }
        public HashSet<Student> Residents { get; }
        public bool IsOccupied => Residents.Count == 2;
        public int NumberOfBeds { get; set; }
        public HashSet<PetType> PetsInRoom { get; set; }


        public Room()
        {
            Id = _lastId;
            _lastId++;
            Residents = new HashSet<Student>();
            NumberOfBeds = 2;
            PetsInRoom = new HashSet<PetType>();
        }

        public Room(int id, HashSet<Student> residents, int numberOfBeds)
        {
            NumberOfBeds = numberOfBeds;
            Id = id;
            Residents = residents;
        }

        public void AddResident(Student student)
        {
            if (!IsOccupied)
            {
                Residents.Add(student);
            }
        }
    }
}