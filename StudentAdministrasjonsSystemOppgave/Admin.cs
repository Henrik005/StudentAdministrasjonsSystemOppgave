using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrasjonsSystemOppgave
{
    internal class Admin
    {
        private List<Student> students;
        private List<Fag> fag;
        private List<Karakter> karakters;
        public Admin()
        {
            fag = new List<Fag> {
             new Fag("NAT1002", "Naturfag", 25),
             new Fag("MAT1005", "Matematikk", 27),
             new Fag("HIS1007", "Historie", 28),
            };

            students = new List<Student> {
             new Student("Kronker", 18, "Allmenkunskap", 222, new List<Fag>{fag[0],fag[2]}),
             new Student("Eugene", 19, "Statsvitenskap", 333, new List<Fag>{fag[1],fag[2]}),
            };
            
            karakters = new List<Karakter> {
             new Karakter(fag[0], students[0], 4.5),
             new Karakter(fag[1], students[1], 3.6),
            };

        }
        public void PrintAll()
        {
            foreach (Student student in students) { student.PrintInfo(); };
            foreach (Fag fag in fag) { fag.PrintInfo(); };
            foreach (Karakter karakter in karakters) { karakter.PrintInfo(); };
        }
    }
}
