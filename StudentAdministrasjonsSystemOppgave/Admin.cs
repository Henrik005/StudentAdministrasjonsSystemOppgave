using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            karakters = new List <Karakter> {
             new Karakter(fag[0], students[0], 4.5),
             new Karakter(fag[2], students[0], 5.3),
             new Karakter(fag[1], students[1], 3.6),
             new Karakter(fag[2], students[1], 5.5),

           };

        }
        public void PrintAll()
        {
            foreach (Student student in students) { student.PrintInfo(); };
            foreach (Fag fag in fag) { fag.PrintInfo(); };
            foreach (Karakter karakter in karakters) { karakter.PrintInfo(); };
        }

        public void AddGrade()
        {
            {   //Got some help from the team after stumbling around trying to do something akin to this but in the completely wrong way-
                //But i am still trying to fully understand how i wanna use this as i find myself getting a little bit confused by everything now-
                //But! It's a nice push in the right direction.
                foreach (Karakter grade in karakters)
                {
                    if (grade.Student == students[0])
                    {
                        students[0]._grade.Add(grade);
                    }
                    else if (grade.Student == students[1])
                    {
                        students[1]._grade.Add(grade);
                    }
                }

            }
        }
    }
}
