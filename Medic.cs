using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectUsabilityTest
{
    class Medic : Character
    {
        public Medic(string named, int health, int power, int protect): base(named, health, power, protect) { }

        public void mend(Character target)
        {
            target.hp += 30;
            if (target.hp > target.getMaxHp())
                target.hp = target.getMaxHp();
        }
    }
}
