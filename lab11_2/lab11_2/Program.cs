using System;
using System.Collections.Generic;
using System.Text;

namespace lab11_2
{
    class Program
    {

        public static void ShowResult(List<Student> result)
        {
           foreach(Student student in result)
            {
                Console.WriteLine("First Name - {0}", student.FirstName);
                Console.WriteLine("Last Name - {0}", student.LastName);
                Console.WriteLine("Age - {0}", student.Age);
            }
        }

        static void Main(string[] args)
        {  
            List<Student> students = new List<Student>() {
                new Student() { Age = 18, FirstName = "Artem", LastName = "Matviichuk" },
                new Student() { Age = 19, FirstName = "Vitaliy", LastName = "Rudenko" },
                new Student() { Age = 20, FirstName = "Oleksiy", LastName = "Luppa" },
                new Student() { Age = 44, FirstName = "Ivan", LastName = "Sobko" },
                new Student() { Age = 17, FirstName = "Yaroslav", LastName = "Pozniak" },
                new Student() { Age = 16, FirstName = "Vadim", LastName = "Derkach" },
                new Student() { Age = 21, FirstName = "Oleksandr", LastName = "Savchuk" },
                new Student() { Age = 18, FirstName = "Artur", LastName = "Savchuk" },
                new Student() { Age = 19, FirstName = "Vladislav", LastName = "Dryga" },
                new Student() { Age = 13, FirstName = "Mykyta", LastName = "Nazarenko" }
            }; 
            StudentPredicateDelegate taskEight;

            taskEight = Student.CheckAge;
            taskEight += Student.CheckFirstName;
            taskEight += Student.CheckLastName;

            List<Student> resultEight = students.FindStudent(taskEight);
            ShowResult(resultEight);

            StudentPredicateDelegate taskNine;

            taskNine = (student) =>
            {
                return (student.Age >= 18) && (student.FirstName[0] == 'A') && (student.LastName.Length > 3);
            };

            
            List<Student> resultNine = students.FindStudent(taskNine);
            ShowResult(resultNine);


            StudentPredicateDelegate taskTen;

            taskTen = (student) =>
            {
                return(student.Age < 25 && student.Age > 20) ;
            };
            List<Student> resultTen = students.FindStudent(taskTen);
            ShowResult(resultTen);

            StudentPredicateDelegate taskEleven;

            taskEleven = (student) =>
            {
                return (student.FirstName == "Andrew");    
            };
            List<Student> resultEleven = students.FindStudent(taskEleven);
            ShowResult(resultEleven);

            StudentPredicateDelegate taskTwelve;
            taskTwelve = (student) =>
            {
                return(student.LastName == "Troelsen") ;
            };
            List<Student> resultTwelve = students.FindStudent(taskTwelve);
            ShowResult(resultTwelve);




        }
    }
}
