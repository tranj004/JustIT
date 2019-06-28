using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventureGame
{
    class Weapons
    {
        public string Name { get; set; }
        public int Attack;
        public int Speed;

        public Weapons(string name)
        {
            Name = name;
            switch (Name)
            {
                case "dagger":
                    Attack = 3;
                    Speed = 5;
                    break;
                case "sword":
                    Attack = 4;
                    Speed = 4;
                    break;
                case "axe":
                    Attack = 13;
                    Speed = 3;
                    break;

            }
        }
    }
}
