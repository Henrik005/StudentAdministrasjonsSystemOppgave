using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrasjonsSystemOppgave
{
    internal class Student
    {
        public string _name { get; private set; }
        public int _age { get; private set; }
        public string _studieProgram { get; private set; }
        public int _studentId { get; private set; }
        public List<Fag> _fag { get; private set; }
        public List<Karakter> _grade { get;  set; } = new List<Karakter>();


        public Student(string name, int age, string studieProgram, int studentId, List<Fag> fag)
        {
            _name = name;
            _age = age;
            _studieProgram = studieProgram;
            _studentId = studentId;
            _fag = fag;
            
        }
        public void PrintInfo()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("STUDENT:");
            Console.WriteLine($" Name: {_name}");
            Console.WriteLine($" Age: {_age}");
            Console.WriteLine($" Study Programme: {_studieProgram}");
            Console.WriteLine($" Student Id: {_studentId}");
            PrintStudentSubject();
            PrintGrades();
            Console.WriteLine($"");

        }
        private void PrintStudentSubject()
        {
            Console.WriteLine("STUDY SUBJECT:");
            foreach (Fag fag in _fag) { Console.WriteLine($"{fag.FagNavn}"); };
        }
        private void PrintGrades()
        {
            Console.WriteLine($"GRADES:");
            foreach (Karakter grade in _grade) { Console.WriteLine($"{grade.Grade}"); }

        }
        private void AverageGrades()
        {

        }
        private void TotalStudyPoints()
        {

        }

    }
}
