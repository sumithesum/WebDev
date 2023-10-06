using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1
{
    internal class Materie
    {
        string durata;
        string Nume, Descriere;
        public Materie(string durata, string nume, string descriere)
        {
            this.Descriere = descriere;
            this.durata = durata;
            this.Nume = nume;

        }
        public Materie(Materie  a ) 
        {
            this.Nume = a.getNume();
            this.durata = a.getDurata();
            this.Descriere = a.getDescrire();

        }
        public string getDurata()
        {
            return this.durata;
        }
        public string getNume() {
            return this.Nume;
        }
        public string getDescrire()
        {
            return this.Descriere;
        }
        public void setNume(string nume)
        {
            this.Nume = nume;
        }
        public void setDurata(string durata)
        {
            this.durata = durata;
        }
        public void setDescriere(string descriere)
        {
            this.Descriere = descriere;
        }

    }

    internal class Student
    {
        public string Nume, Prenume, telefon, email;
        public List<Materie> materii = new List<Materie>();
        public Student(string nume, string prenume, string telefon, string email)
        {
            this.Nume = nume;
            this.Prenume = prenume;
            this.telefon = telefon;
            this.email = email;



        }
        public Student(string nume, string prenume, string telefon, string email, List<Materie> lista)
        {
            this.Nume = nume;
            this.Prenume = prenume;
            this.telefon = telefon;
            this.email = email;
            foreach (Materie i in lista)
            {
                Materie j = new Materie(i);
                this.materii.Add(j);
                
            }
        }
        public void afisare()
        {
            Console.WriteLine("Studentul cu numele :" + this.Nume + " si prenumele : " + this.Prenume + " telefonul : " + this.telefon + " emeilul: "+this.email);
            Console.WriteLine();
            if (this.materii.Count == 0)
                Console.WriteLine("Elevul nu are materii la care participa");
            else foreach (Materie i in this.materii)
                    Console.WriteLine("Materia : " + i.getNume() + " cu durata :" + i.getDurata() + " cu descrierea: " + i.getDescrire());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        public void adaugaListaMaterii(List<Materie> l)
        {
            foreach (Materie i in l)
            {
                Materie j = new Materie(i);
                this.materii.Add(j);

            }
        }
        public void adaugaListaMateriiSchimbatoare(List<Materie> l)
        {
            foreach (Materie i in l)            
                this.materii.Add(i);

        }
        public void EliminareMaterie(Materie m)
        {
            this.materii.Remove(m);
        }
        public bool CautareMaterie(Materie m)
        {
            return   this.materii.Contains(m);
        }


    }



}
