using StudentAdministrasjonsSystemOppgave;



var newStudent1 = new Student("Kronker", 18, "Naturfag", 222);
var newStudent2 = new Student("Eugene", 19, "Matematikk", 333);

var Naturfag = new Fag("NAT1002", "Naturfag", 25);
var Matematikk = new Fag("MAT1005", "Matematikk", 27);


var Karakter1 = new Karakter(Naturfag, newStudent1, 4.5);
var Karakter2 = new Karakter(Matematikk, newStudent2, 3.6);


newStudent1.PrintInfo();
newStudent2.PrintInfo();
Naturfag.PrintInfo();
Matematikk.PrintInfo();
Karakter1.PrintInfo();
Karakter2.PrintInfo();
//Karakter doesn't print the way i want it to, but! So far so good i think?
// -Shouldn't be TOO hard to figure that out