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
        public string StudieProgram { get; private set; }
        public int StudentId { get; private set; }
        public List<Fag> Fag { get; private set; }


        public Student(string name, int age, string studieProgram, int studentId, List<Fag> fag)
        {
            Name = name;
            Age = age;
            StudieProgram = studieProgram;
            StudentId = studentId;
            Fag = fag;
        }
        public void PrintInfo()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("STUDENT:");
            Console.WriteLine($" Name: {Name}");
            Console.WriteLine($" Age: {Age}");
            Console.WriteLine($" Study Programme: {StudieProgram}");
            Console.WriteLine($" Student Id: {StudentId}");
            PrintStudentSubject();
            Console.WriteLine($"");

        }
        private void PrintStudentSubject()
        {
            Console.WriteLine("STUDY SUBJECT:");
            foreach(Fag fag in Fag) { Console.WriteLine($"{fag.FagNavn}"); };
        }
    }
}
