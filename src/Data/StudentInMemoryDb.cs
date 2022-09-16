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
            AddStudent(new Student("Dr. Stephen Strange", PetType.Owl));
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public Student GetStudentById(int id)
        {
            return Students.First(student => student.Id == id);
        }

        public void DeleteStudentById(int id)
        {
            Students.Remove(GetStudentById(id));
        }

        public void UpdateStudentById(int id, Student student)
        {
            DeleteStudentById(id);
            
            AddStudent(student);
        }
    }
}