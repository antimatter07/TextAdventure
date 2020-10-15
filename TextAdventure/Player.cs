using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Player
    {
        public string name;
        public int spheres=0;
        public int health=10;
        public int damage=1;
        public int armor=0;
        public int stormlight=5;
        
        public string GetName()
        {
            return name;
        }
        public void SetName(string newname)
        {
            name = newname;
        }
        public int GetSpheres()
        {
            return spheres;
        }
        public void SetSpheres(int newSpheres)
        {
            spheres = newSpheres;
        }
        public int GetHealth()
        {
            return health;
        }
        public void SetHealth(int newHealth)
        {
            health = newHealth;
        }
        
        public int GetDamage()
        {
            return damage;
        }
        public void SetDamage(int newDamage)
        {
            damage = newDamage;
        }
        public int GetArmor()
        {
            return armor;
        }
        public void SetArmor(int newArmor)
        {
            armor = newArmor;
        }
        public int GetStormlight()
        {
            return stormlight;
        }
        public void SetStormlight(int newStormlight)
        {
            stormlight = newStormlight;
        }
    }

    
}
