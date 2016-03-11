using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectUsabilityTest
{
    class Mage : Character
    {
        int mana;
        int maxMana;

        public Mage(string named, int health, int power, int protect, int magic) : base(named, health, power, protect)
        {
            mana = magic;
            maxMana = magic;
        }

        public new void rest()
        {
            base.rest();
            mana = maxMana;
        }

        public void fireball (Character target)
        {
            if(mana >= 10)
            {
                mana -= 10;
                int dmg = 50 - target.getDef();
                if(dmg > 0)
                    target.hp -= 50 - target.getDef();
            }
        }

        public override string ToString()
        {
            return base.ToString() + " mp:" + mana;
        }
    }
}
