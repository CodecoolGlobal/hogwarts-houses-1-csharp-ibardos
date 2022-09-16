using HogwartsHouses.Models.Types;

namespace HogwartsHouses.Models
{
    [System.Serializable]
    public class Student
    {
        private static int _lastId;
        public int Id { get; set; }
        public string Name { get; }
        public PetType? Pet { get; set; }

        public Student(string name, PetType? pet)
        {
            Id = _lastId;
            _lastId++;
            Name = name;
            Pet = pet;
        }
    }
}