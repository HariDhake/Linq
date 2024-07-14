using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OrderingLinq
{
    public class Student
    {
        public int StudentID { get; set; }
        public String Name { get; set; }
        public int TotalMarks { get; set; }
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
        {
            new Student { StudentID = 1, Name = "Harish" ,TotalMarks=80},
            new Student { StudentID = 2, Name = "Adtiya" ,TotalMarks=120},
            new Student { StudentID = 3, Name = "Priyanka" ,TotalMarks=150},
            new Student { StudentID = 4, Name = "Manish" ,TotalMarks=200},
            new Student { StudentID = 5, Name = "Madhuri" ,TotalMarks=2500},
            new Student { StudentID = 6, Name = "Pravin" ,TotalMarks=500},
        };
            return students;
        }
    }
}
