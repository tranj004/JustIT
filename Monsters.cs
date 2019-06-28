using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventureGame
{
    class Monsters
    {
        public string Name { get; set; }
        public int HeathPoint;
        public int Attack;
        public int Defence;
        public int Speed;

        public Monsters(string name)
        {
            Name = name;
            switch (Name)
            {
                case "slime":
                    HeathPoint = 5;
                    Attack = 2;
                    Defence = 2;
                    Speed = 1;
                    break;
                case "goblin":
                    HeathPoint = 10;
                    Attack = 4;
                    Defence = 3;
                    Speed = 3;
                    break;
                case "wolf":
                    HeathPoint = 7;
                    Attack = 5;
                    Defence = 2;
                    Speed = 5;
                    break;
            }
        }
    }
}
