namespace Tema1
{

    public class Server
    {
        string regiune;
        int id, players;
        int MaxPlayers;
    

    public Server(int id, string regiune, int players, int MaxPlayers)
        {
            this.id = id;
            this.regiune = regiune;
            
            this.MaxPlayers = MaxPlayers;
            if (players > MaxPlayers)
                Console.WriteLine("Sunt prea mululti")
            else
                this.players = players;
        }
    public Server(int id, string regiune, int players)
        {
            this.MaxPlayers = 2000;
            this.id = id;
            this.regiune = regiune;
            if(players > MaxPlayers)
                Console.WriteLine("Sunt prea mululti")
            else
            this.players = players;
            

        }
    public void adaugarePlayer()
        {
            if (players < MaxPlayers)
                players++;
            else
                Console.WriteLine("Server full");
        }

    public void crestereMaxim(int i)
        {
            this.MaxPlayers += i;
        }

    public void SchimbareRegiune(string regiune)
        {
            this.regiune = regiune;
        }

    public void afisareServer()
        {
            Console.WriteLine("Serverul cu id-ul: " + this.id + " cu regiunea: " + this.regiune + " are " + this.players + " jucatori dintr-un maxim de " + this.MaxPlayers)
        }

    }

    public class Joc
    {
        string nume, creatori, engine;
        List<Server> servere = new List<Server>();
        public Joc(string numa, string creatori , string engine)
        {
            this.nume = numa;
            this.creatori = creatori;
            this.engine = engine;
            List<Server> servere = new List<Server>();
        }
        public Joc(string numa, string creatori, string engine, List<Server> servere)
        {
            this.nume = numa;
            this.creatori = creatori;
            this.engine = engine;
            foreach (Server i in servere)
                this.servere.Add(i);
        }
        public void AdaugareServer(Server i)
        {
            this.servere.Add(i);
        }
        public void afisareServere()
        {
            Console.WriteLine("Jocul : " + this.nume + " facut de : " + this.creatori + " cu engine-ul : "+ this.engine + " are serverele: ")
            foreach(Server i in this.servere)
                i.afisareServer()
        }



    }




}
