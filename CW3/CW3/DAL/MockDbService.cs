using CW3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CW3.DAL
{
    public class MockDbService
    {
        private static IEnumerable<Student> _students;

        static MockDbService()
        {
            _students = new List<Student>
            {
                new Student{IndexNumber="s17455", FirstName="Jan", LastName="Kowalski"},
                new Student{IndexNumber="s12131", FirstName="Jan", LastName="Kowalski"},
                new Student{IndexNumber="s1231", FirstName="Jan", LastName="Kowalski"}
            };
        }

        public IEnumerable<Student> GetStudents(string orderBy)
        {
            return _students;
        }
    }

}
