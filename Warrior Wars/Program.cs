using System;
using System.Threading;
using Warrior_Wars.Enum;

namespace Warrior_Wars
{
    class Program
    {
        static Random rand = new Random();
        public static Faction Fac { get; private set; }

        static void Main(string[] args)
        {
            Warrior goodguy = new Warrior("Mehemmed Babashov", Faction.GoodGuy);
            Warrior badguy = new Warrior("Janklot Vandam", Faction.BadGuy);
            
            while(goodguy.IsAlive && badguy.IsAlive)
            {
                if(rand.Next(0,10) < 5)
                {
                    goodguy.Attack(badguy);
                }
                else
                {
                    badguy.Attack(goodguy);
                }
                Thread.Sleep(200);
            }
        }
    }
}
