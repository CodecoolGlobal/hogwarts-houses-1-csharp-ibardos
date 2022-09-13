using HogwartsHouses.Models.Types;

namespace HogwartsHouses.Models
{
    [System.Serializable]
    public class Student
    {
        public string Name { get; }
        public PetType? Pet { get; set; }

        public Student(string name, PetType? pet)
        {
            Name = name;
            Pet = pet;
        }
    }
}
