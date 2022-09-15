using System;
using System.Collections.Generic;
using System.Linq;
using HogwartsHouses.Models;
using HogwartsHouses.Models.Types;

namespace HogwartsHouses.Data
{
    public class StudentInMemoryDb
    {
        public HashSet<Student> Students { get; private set; }

        public StudentInMemoryDb()
        {
            Initialize();
        }

        public void Initialize()
        {
            Students = new HashSet<Student>();

            AddStudent(new Student("Hermione Granger", PetType.Cat));
            AddStudent(new Student("Draco Malfoy", PetType.None));
        }
    }
}