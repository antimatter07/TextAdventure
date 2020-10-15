using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Program
    {
         
        public static Player p1= new Player();
        static void Main(string[] args)
        {
            StartGame();
            Encounters.FirstEncounter();
        }
        static void StartGame()
        {
            Console.WriteLine("Storm Quest!");
            do
            {
                Console.WriteLine("Please enter your name: ");
                p1.SetName(Console.ReadLine());

            } while (p1.GetName() == ""||p1.GetName()==" ");
            Console.Clear();
            Console.WriteLine("Goodluck with your quest, Radiant {0}! Journey before destination.", p1.GetName());
            Console.ReadKey();
            Console.WriteLine("\n");

            Console.WriteLine("You are awake in a cold, dark room. Your mind is empty, and you feel a bit lightheaded.");
            Console.WriteLine("You don't remember much except for the fact that your name is {0}.",p1.GetName());
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You try to feel your way around the small enclosure and eventually find a door handle.");
            Console.WriteLine("You twist it and open the door to be greeted with someone there!");
            Console.ReadKey();
            Console.Clear();
           
            

            

        }
    }
}
