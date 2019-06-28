using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventureGame
{
    class Battle
    {
        public static void battle(Player user, Monsters mon)
        {
            Console.WriteLine($"{mon} has apper");
            bool alive = true;
            bool run = false;
            bool defendingP = false;
            bool defendingM = false;
            do
            {
                Random ran = new Random();
                int sboost = ran.Next(1, 4);
                Console.WriteLine($"Your HP: {user.HeathPoint}");
                if (user.Speed + sboost > mon.Speed)
                {
                    defendingP = false;
                    Console.WriteLine($"{user} go first. Chose: A (Attack), D (Defence), R (Runaway)");
                    string input = Console.ReadLine().ToUpper();
                    bool mistype = false;
                    do
                    {
                        mistype = false;
                        switch (input)
                        {
                            case "A":
                                attackP(user, mon);
                                break;
                            case "D":
                                defendingP = defenceP(user);
                                break;
                            case "R":
                                run = runawayP(user, mon);
                                break;
                            default:
                                Console.WriteLine("Not an Options");
                                mistype = true;
                                break;
                        }
                    } while (mistype != false);
                }
                else
                {
                    defendingM = false;
                    int input = ran.Next(1, 11); ;
                    bool mistype = false;
                    do
                    {
                        mistype = false;
                        if (input >= 5)
                        {
                            attackM(user, mon);
                        }
                        else if (input >= 8)
                        {
                            defendingM = defenceM(mon);
                        }
                        else
                        {
                            run = runawayM(user, mon);
                        }
                    } while (mistype != false);
                }
                if (user.HeathPoint <= 0)
                {
                    Console.WriteLine("You have died");
                    alive = false;
                }
                else if(mon.HeathPoint <= 0)
                {
                    Console.WriteLine($"{mon.Name} has died");
                    alive = false;
                }
            } while (alive);

        }

        static void attackP(Player p1, Monsters m1)
        {
            Random ran = new Random();
            int boost = ran.Next(1, 5);
            int damage = (boost + p1.Attack) - m1.Defence;
            Console.WriteLine($"{p1.Name} attack dealing {damage}");
            m1.HeathPoint -= damage;
        }

        static void attackM(Player p1, Monsters m1)
        {
            Random ran = new Random();
            int boost = ran.Next(1, 5);
            int damage = (boost + m1.Attack) - p1.Defence;
            Console.WriteLine($"{m1.Name} attack dealing {damage}");
            p1.HeathPoint -= damage;
        }

        static bool defenceP(Player p1)
        {
            p1.Defence = p1.Defence * 2;
            Console.WriteLine($"{p1.Name} is defending");
            return true;
            
        }
        static bool defencePStop(Player p1)
        {
            p1.Defence = p1.Defence / 2;
            return false;
        }

        static bool defenceM(Monsters m1)
        {
            m1.Defence = m1.Defence * 2;
            Console.WriteLine($"{m1.Name} is defending");
            return true;

        }
        static bool defenceMStop(Monsters m1)
        {
            m1.Defence = m1.Defence / 2;
            return false;
        }

        static bool runawayP(Player p1, Monsters m1)
        {
            Random ran = new Random();
            int boost = ran.Next(1, 4);
            if((p1.Speed + boost) > m1.Speed)
            {
                Console.WriteLine($"{p1.Name} succeed runaway");
                return true;
            }
            else
            {
                Console.WriteLine($"{p1.Name} failed to runaway");
                return false;
            }
        }
        static bool runawayM(Player p1, Monsters m1)
        {
            Random ran = new Random();
            int boost = ran.Next(1, 4);
            if (p1.Speed < (m1.Speed + boost))
            {
                Console.WriteLine($"{m1.Name} succeed runaway");
                return true;
            }
            else
            {
                Console.WriteLine($"{m1.Name} failed to runaway");
                return false;
            }
        }
    }
}
