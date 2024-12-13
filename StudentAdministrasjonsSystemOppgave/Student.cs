using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrasjonsSystemOppgave
{
    internal class Student
    {
       public string Name { get; private set; }
        public int Age { get; private set; }
        public string Subject { get; private set; }
        public int StudentId { get; private set; }

        public Student(string name, int age, string subject, int studentId)
        {
            Name = name;
            Age = age;
            Subject = subject;
            StudentId = studentId;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"{Age}");
            Console.WriteLine($"{Subject}");
            Console.WriteLine($"{StudentId}");
        }

    }
}
