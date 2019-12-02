using System;
using System.Collections.Generic;
using System.Text;

namespace lab11_2
{
    public delegate bool StudentPredicateDelegate(Student student);
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public static bool CheckAge(Student student)
        {
            if (student.Age >= 18)
                return true;
            else
                return false;
        }


        public static bool CheckFirstName(Student student)
        {
            if (student.FirstName[0] == 'A')
                return true;
            else
                return false;
        }

        public static bool CheckLastName(Student student)
        {
            if (student.LastName.Length > 3)
                return true;
            else
                return false;
        }
    }
}
