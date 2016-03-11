using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectUsabilityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Character joe = new Character("Joe", 10, 1, 1);
            Character angryJoe = new Character("AJoe", 10, 2, 0);

            angryJoe.attack(joe);

            Mage caster = new Mage("Mike", 25, 10, 10, 30);
            Medic healer = new Medic("Selina", 30, 5, 20);

            Console.Out.WriteLine(joe.ToString());
            Console.Out.WriteLine(angryJoe.ToString());
            Console.Out.WriteLine(caster.ToString());
            Console.Out.WriteLine(healer.ToString());
            Console.Out.WriteLine();

            caster.attack(angryJoe);
            caster.fireball(joe);
            caster.attack(healer);

            Console.Out.WriteLine(joe.ToString());
            Console.Out.WriteLine(angryJoe.ToString());
            Console.Out.WriteLine(caster.ToString());
            Console.Out.WriteLine(healer.ToString());
            Console.Out.WriteLine();

            healer.mend(joe);
            healer.mend(angryJoe);

            Console.Out.WriteLine(joe.ToString());
            Console.Out.WriteLine(angryJoe.ToString());
            Console.Out.WriteLine(caster.ToString());
            Console.Out.WriteLine(healer.ToString());
            Console.Out.WriteLine();

            joe.rest();
            angryJoe.rest();
            caster.rest();
            healer.rest();

            Console.Out.WriteLine(joe.ToString());
            Console.Out.WriteLine(angryJoe.ToString());
            Console.Out.WriteLine(caster.ToString());
            Console.Out.WriteLine(healer.ToString());
            Console.In.ReadLine();

        }
    }
}
