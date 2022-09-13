using System.Collections.Generic;

namespace HogwartsHouses.Models
{
    [System.Serializable]
    public class Room
    {
        private static int _lastId = -1;
        public int Id { get; }
        public HashSet<Student> Residents { get; }
        public bool IsOccupied => Residents.Count == 2;


        public Room()
        {
            Id = _lastId++;
            _lastId++;
            Residents = new HashSet<Student>();
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
