using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = GetStudents();
            PrintStudent(students);

          

        }

        private static void PrintStudent(List<Student> students)
        {
            foreach (Student stud in students.Where(x => x.AverageGrade >= 5.00).OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade))
            {
                Console.WriteLine($"{stud.Name} -> {stud.AverageGrade:F2}");
            }

        }

        public static List<Student> GetStudents()
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();


            for (int i = 0; i < n; i++)
            {
                Student stud = new Student();

                List<string> input = Console.ReadLine().Split(' ').ToList();

                stud.Name = input[0];
                input.RemoveAt(0);
                stud.Grades = input.Select(double.Parse).ToList();

                students.Add(stud); 

            }
            return students;

        }

    }
}
