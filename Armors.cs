using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventureGame
{
    class Armors
    {
        public string Name { get; set; }
        public int Defence;
        public int Speed;

        public Armors(string name)
        {
            Name = name;
            switch (Name)
            {
                case "shield":
                    Defence = 5;
                    Speed = -1;
                    break;
                case "leather":
                    Defence = 6;
                    Speed = 2;
                    break;
                case "cloth":
                    Defence = 3;
                    Speed = 5;
                    break;
                case "metal":
                    Defence = 9;
                    Speed = -1;
                    break;
            }
        }
    }
}
