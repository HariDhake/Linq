using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List of Students before Sorting");
            /*List<Student> students = Student.GetStudents();
            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);
                Console.WriteLine(student.StudentID);
                Console.WriteLine(student.TotalMarks);
            }*/
            IOrderedEnumerable<Student> inum=  Student.GetStudents().OrderBy(x => x.TotalMarks);
            foreach (Student student in inum)
            {
                Console.WriteLine(student.Name);
                Console.WriteLine(student.StudentID);
                Console.WriteLine(student.TotalMarks);

            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
