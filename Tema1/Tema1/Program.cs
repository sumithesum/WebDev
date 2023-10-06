// See https://aka.ms/new-console-template for more information

using Tema1;


List<Student> Studenti = new List<Student>();
Student a = new Student("Alex","Sumi","083183921381" , "sumurduc2003@gmail.com");




Materie m1 = new Materie("2h", "Matematica", "1+1 = 2 (deoarece 2 este primu urmas al lui 1)");
Materie m2 = new Materie("1h", "Romana", "Cititm si inventam din dorinte");
Materie m3 = new Materie("1h", "English", "Learning english is the best (minciuni)");
Materie m4 = new Materie("2h", "Informatica", "x = x +1");

a.materii.Add(m1);
a.materii.Add(m2);
a.materii.Add(m3);

a.afisare();

List<Materie> lista = new List<Materie>() { m1, m2, m3, m4 };

Student b = new Student("Sumi", "Sumi", "083183921381", "sumurduc2003@gmail.com", lista);

b.afisare();

lista.Remove(m2);

b.afisare();

m1.setDurata("3h");

a.afisare();
b.afisare();


 Console.WriteLine( a.CautareMaterie(m3));

a.EliminareMaterie(m2);

a.afisare();
