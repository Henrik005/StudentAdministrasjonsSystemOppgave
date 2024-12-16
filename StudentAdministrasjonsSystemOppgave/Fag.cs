using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrasjonsSystemOppgave
{
    internal class Fag
    {
        public string FagKode {get; private set; }
        public string FagNavn { get; private set; }
        public int StudiePoeng { get; private set; }
        public Fag (string fagKode, string fagNavn, int studiePoeng)
        {
            FagKode = fagKode;
            FagNavn = fagNavn;
            StudiePoeng = studiePoeng;
        }
        public void PrintInfo()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("FAG:");
            Console.WriteLine($"Subject Code: {FagKode}");
            Console.WriteLine($"Subject Name: {FagNavn}");
            Console.WriteLine($"Study Points: {StudiePoeng}");

        }
    }
}
