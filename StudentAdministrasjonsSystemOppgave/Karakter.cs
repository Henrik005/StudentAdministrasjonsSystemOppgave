using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentAdministrasjonsSystemOppgave
{
    internal class Karakter
    {
        public Fag Subject { get; private set; }
        public Student Student { get; private set; }
        public double Grade { get; private set; }

        public Karakter(Fag subject, Student student, double grade)
        {
            Subject = subject;
            Student = student;
            Grade = grade;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{Subject}");
            Console.WriteLine($"{Student}");
            Console.WriteLine($"{Grade}");
        }
    }
}
