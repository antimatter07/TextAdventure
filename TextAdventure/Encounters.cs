using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Encounters
    {
        static Random rand = new Random();
        //ENCOUNTERS
        public static void FirstEncounter()
        {
            Console.WriteLine("You rush past to grab an old spear that was against the wall.");
            Console.WriteLine("He turns to attack!");
            Console.ReadKey();
            Combat(false, "Cremling", 1, 4);
        }
        //tools
        public static void Combat(bool random,string name, int power, int health)//stats of the enemy
        {
            string n = "";
            int p = 0;
            int h = 0;
            if (random)
            {

            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            while (h > 0)
            {
                Console.Clear();
                Console.WriteLine(n);
                Console.WriteLine(p + "/" + h);
                Console.WriteLine("===================");
                Console.WriteLine("><><><><><><><><><>");
                Console.WriteLine("|(A)ttack (D)efend|");
                Console.WriteLine("|(F)lee    (H)eal |");
                Console.WriteLine("><><><><><><><><><>");
                Console.WriteLine("===================");
                Console.WriteLine("Stormlight:  "+Program.p1.GetStormlight()+ "Health: "+Program.p1.GetHealth());
                string input = Console.ReadLine();

                    if (input.ToLower() == "a" || input.ToLower() == "attack")
                    {
                        Console.WriteLine("You feel natural with a spear in your hands, and charge to attack the {0}!",n);
                        int damage = p - Program.p1.GetArmor();
                    if (damage < 0)
                    {
                        damage = 0;
                    }
                        int attack = rand.Next(0, Program.p1.GetDamage() + rand.Next(1, 4));//rand.Next returns a value between 1 and 4, the min and max values
                        Console.WriteLine("You get hit and lose {0} HP and deal {1} damage!", damage, attack);
                        Program.p1.SetHealth(Program.p1.health -= damage);//updates health value of player
                        h -= attack;//updates health value of enemy
                    }
                    else if (input.ToLower() == "d" || input.ToLower() == "defend")
                    {
                    //DEFEND
                        Console.WriteLine("As the {0} approaches, you go into a defensive stance and attempt to block the attack!",n);
                        int damage = (p/4) - Program.p1.GetArmor();
                    if (damage < 0)
                    {
                        damage = 0;
                    }
                        int attack = rand.Next(0, Program.p1.GetDamage())/2;//rand.Next returns a value between 1 and 4, the min and max values
                        Console.WriteLine("You get hit and lose {0} damage and deal {1} damage!", damage, attack);
                        Program.p1.SetHealth(Program.p1.health-=damage);//updates health value of player
                        h -= attack;//updates health value of enemy

                     }
                    else if (input.ToLower() == "f"||input.ToLower() == "flee")
                    {
                    //flee
                    int flee = rand.Next(0, 2);
                    if (flee ==0)
                    {
                        Console.WriteLine("You attempt to run away from the {0}, it catches up to you and you fall to the ground.",n);
                        int damage = p - Program.p1.GetArmor();
                        if (damage < 0)
                        {
                            damage = 0;
                        }
                        Console.WriteLine("It attacks you and deals {0}, and your attempt to flee failed!", damage);
                        Program.p1.SetHealth(Program.p1.health -= damage);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You gain a burst of speed from sucking in stormlight to escape from the {0}",n);
                        Console.ReadKey();//go to the market
                    }

                    }
                    else if (input.ToLower() == "h" || input.ToLower() == "heal")
                    {
                        if (Program.p1.stormlight == 0)
                        {
                             Console.WriteLine("You attempt to draw in Stormlight to heal, but alas, your spheres are all dun!");
                             int damage = p - Program.p1.GetArmor();
                             if (damage < 0)
                             {
                            damage = 0;
                             }
                             Console.WriteLine("The {0} seizes the opportunity and attacks you, and you take {0} damage.", damage);
                             Program.p1.SetHealth(Program.p1.health -= damage);
                             Console.ReadKey();
                        }
                        else
                        {

                            Console.WriteLine("You inhale stormlight from your spheres to heal yourself!");
                            Program.p1.SetHealth(Program.p1.stormlight + Program.p1.health);
                            Console.WriteLine("You gain {0}HP",Program.p1.stormlight);
                             int damage = p - Program.p1.GetArmor();
                             Console.WriteLine("While you were healing, the enemy seized the opportunity to attack and dealt {0} damage!",damage);
                            Program.p1.SetHealth(Program.p1.health -= damage);
                            Console.ReadKey();

                        }

                    }

                Console.ReadKey();
                         
            }
            
            }
        }
    }

