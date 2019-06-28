using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventureGame
{
    class Player
    {
        public string Name { get; set; }
        public string Job { get; set; }
        public int HeathPoint;
        public int Attack;
        public int Defence;
        public int Speed;

        public Player(string name, string job)
        {
            Name = name;
            Job = job;
            switch (Job)
            {
                case "warrior":
                    HeathPoint = 15;
                    Attack = 10;
                    Defence = 10;
                    Speed = 5;
                    Weapons Weapon1 = new Weapons("axe");
                    Attack += Weapon1.Attack;
                    Speed += Weapon1.Speed;
                    Armors Armor = new Armors("leather");
                    Defence += Armor.Defence;
                    Speed += Armor.Speed;
                    break;
                case "knight":
                    HeathPoint = 20;
                    Attack = 5;
                    Defence = 10;
                    Speed = 5;
                    Weapon1 = new Weapons("sword");
                    Attack += Weapon1.Attack;
                    Speed += Weapon1.Speed;
                    Armor = new Armors("metal");
                    Defence += Armor.Defence;
                    Speed += Armor.Speed;
                    Armors Armor2 = new Armors("shield");
                    Defence += Armor.Defence;
                    Speed += Armor.Speed;
                    break;
                case "thief":
                    HeathPoint = 10;
                    Attack = 10;
                    Defence = 5;
                    Speed = 15;
                    Weapon1 = new Weapons("dagger");
                    Attack += Weapon1.Attack;
                    Speed += Weapon1.Speed;
                    Weapons Weapon2 = new Weapons("dagger");
                    Attack += Weapon1.Attack;
                    Speed += Weapon1.Speed;
                    Armor = new Armors("cloth");
                    Defence += Armor.Defence;
                    Speed += Armor.Speed;
                    break;
            }
        }
        
    }
}
