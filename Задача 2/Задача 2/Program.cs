using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    internal class Program
    {
        static void InsertionSort(List<Student> students)
        {
            for (int i = 1; i < students.Count; i++)
            {
                var key = students[i];
                int j = i - 1;

                while (j >= 0 && (students[j].Grade > key.Grade ||
                                  (students[j].Grade == key.Grade &&
                                   string.Compare(students[j].Name, key.Name) > 0)))
                {
                    students[j + 1] = students[j];
                    j--;
                }
                students[j + 1] = key;
            }
        }

        static void Main()
        {
            List<Student> students = new List<Student>
        {
            new Student("Максим", 5.32),
            new Student("Даниел", 5.86),
            new Student("Живко", 5.57),
            new Student("Кристиан", 5.65),
            new Student("Елена", 5.93)
        };

            InsertionSort(students);

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}