using System;
using System.Collections.Generic;
using System.Text;

namespace lab11_2
{
    static class Extension
    {
        public static List<Student> FindStudent(this List<Student> list, StudentPredicateDelegate studentPredicateDelegate)
        {
            List<Student> Result = new List<Student>();
            foreach(Student student in list)
            {
                if (studentPredicateDelegate.Invoke(student))
                {
                    Result.Add(student);
                }
            }
            return Result;
        }   
    }
}
