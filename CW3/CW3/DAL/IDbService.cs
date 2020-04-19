using CW3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CW3.DAL
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents(string orderBy);

        public Student GetStudent(string indexNumber);

        public int CreateStudent(Student student);

        public int UpdateStudent(string indexNumber, Student student);

        public int DeleteStudent(string indexNumber);

        object GetStudentEnrollment(string indexNumber);
    }
}
