using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string job;
            Console.WriteLine("Welcome to the Labyrinth Adventure Game");
            do
            {
                Console.WriteLine("Please enter your Name: ");
                name = Console.ReadLine();
            } while (name == "");
            do
            {
                Console.WriteLine("Please Chose a Job: (Warrior, Knight, Thief)");
                job = Console.ReadLine().ToLower();
                if(job == "warrior" || job == "knight" || job == "thief")
                {
                    break;
                }
            } while (true);
            Player p1 = new Player(name, job);
            Console.WriteLine($"Your names is {p1.Name} your job is {p1.Job} your stats are hp: {p1.HeathPoint} at: {p1.Attack} df: {p1.Defence} sp: {p1.Speed}");

            Console.ReadLine();
            //Console.WriteLine("You are an new adventure ");
        }

        
    }
}
