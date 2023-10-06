using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program
{

    
    internal class Program
    {
        enum PlayerState
        {
            Idle,
            Attacking
        }
        static void Main(string[] args){

            Console.WriteLine("Hello World!");

            int i = 56;

            Console.WriteLine("Hello World!" + i);


            int[] intarray = new int[5]; // fixesd size

            List<int> intlist = new List<int>() { 1, 2, 3, 4 };
            
            foreach(int j in intlist)
            {
                Console.WriteLine(j);
            }
            for(int z = 0; i < intlist.Count; i++)
            {
                ;    
            }
              



            Console.ReadKey();
        }
        static string Functie()
        {
            return "salut";
        }
        static void Functie2()
        {

        }
    }
}
