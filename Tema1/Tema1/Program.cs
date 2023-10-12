
using Tema1;
Server a = new Server(0, "EUW", 500);
Server b = new Server(1, "EUNE", 300, 500);
Server c = new Server(2, "NA", 1000);
Server d = new Server(3, "Oceania", 200);

b.crestereMaxim(1000);
c.adaugarePlayer();
d.SchimbareRegiune("EUW");

List<Server> lista = new List<Server>() { a, b, c };


Joc e = new Joc("MineLife", "ROsti", "Rugaminte");
Joc f = new Joc("CS3", "VALVA", "SURSA_MONDIALA", lista);

e.AdaugareServer(a);
e.AdaugareServer(b);
e.AdaugareServer(c);
e.AdaugareServer(d);

