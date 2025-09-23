using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Task_Linq
{
    internal class Program
    {
        class subject
        {
            public int Code { get; set; }
            public string Name { get; set; }        }
        class Student
        {
            public int id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public subject[] subjects { get; set; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("===========(Q1)================");
            List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };
            Console.WriteLine("----------------query1---------------------");
            var Query1 = numbers.Distinct().OrderBy(n => n);
            foreach (var item in Query1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------query2-----------------------");


            var Query2 = Query1.Select(n => new { number = n, Square = n * n });
            foreach (var n in Query2)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\n===========(Q2)================\n");

            string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };
            Console.WriteLine("----------------query1---------------------");
            var q2_Query1 = names.Where(n => n.Length == 3).Select(n => n);
            foreach (var n in q2_Query1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("----------------query2---------------------");
            var q2_Query2 = names.Where(name => name.ToLower().Contains('a')).OrderBy(name => name.Length);
            foreach (var n in q2_Query2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("----------------query3---------------------");

            var q2_Query3 = names.Take(2);
            foreach (var n in q2_Query3)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\n===========(Q3)================\n");

            List<Student> students = new List<Student>()
            {
                new Student(){id=1,FirstName="Ali", LastName="Mohammed",
                subjects=new subject[]{ new subject() { Code = 22, Name = "EF" },new subject(){ Code = 33, Name = "UML" } } },

                new Student(){id=2, FirstName="Mona", LastName="Gala",
                subjects=new subject[]{new subject() { Code = 22, Name = "EF" },new subject(){ Code=34,Name="XML"},new subject (){ Code=25, Name="JS"}}},

                new Student(){ id=3, FirstName="Yara", LastName="Yousf",
                    subjects=new subject []{ new subject (){ Code=22,Name="EF"},
                    new subject (){Code=25,Name="JS"}}},

                new Student(){ id=1, FirstName="Ali", LastName="Ali",
                    subjects=new subject []{ new subject (){ Code=33,Name="UML"}}},
            };
            Console.WriteLine("----------------query1---------------------");


            var q3_Query1 = students.Select(n => new { Full_Name = n.FirstName + " " + n.LastName
                , NoOfSubjects = n.subjects.Count() });
            foreach (var n in q3_Query1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("----------------query2---------------------");

            var q3_Query2 = students.OrderByDescending(s => s.FirstName)
                .ThenBy(s=>s.LastName)
                .Select(s => s.FirstName + " " + s.LastName);
            foreach (var n in q3_Query2)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("----------------query3---------------------");

            var q3_Query3 = students.SelectMany(s =>s.subjects,(students,subject)
                => new {StudentName=students.FirstName+" "+students.LastName
                ,SubjectName=subject.Name});
            foreach (var n in q3_Query3)
            {
                Console.WriteLine(n);
            }

            //Bonus 
            Console.WriteLine("----------------query Bonus---------------------");

            var queryBonus = students.SelectMany(s => s.subjects, (students, subject)
                => new {
                    StudentName = students.FirstName + " " + students.LastName
                ,   SubjectName = subject.Name
                }).GroupBy(s=>s.StudentName);

            foreach (var group in queryBonus)
            {
                Console.WriteLine(group.Key);
                foreach(var n in group)
                {
                    Console.WriteLine("\t"+n.SubjectName);
                }
            }
        }
    }
}