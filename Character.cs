using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectUsabilityTest
{
    class Character
    {
        string name;
        public int hp;
        int maxHp, atk, def;

        public void attack (Character enemy)
        {
            int dmg = atk - enemy.def;
            if(dmg > 0)
                enemy.hp -= atk - enemy.def;
        }

        public void rest ()
        {
            hp = maxHp;
        }

        public string getName() { return name; }
        public int getDef() { return def; }
        public int getMaxHp() { return maxHp; }

        public Character(string named, int health, int power, int protect)
        {
            name = named;
            hp = health;
            maxHp = health;
            atk = power;
            def = protect;
        }

        public override string ToString()
        {
            return (name + " hp:" + hp + " atk:" + atk + " def:" + def);
        }
    }
}
