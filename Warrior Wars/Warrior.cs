using Warrior_Wars.Equipment;
using Warrior_Wars.Enum;
using System;

namespace Warrior_Wars
{
    class Warrior
    {
        private const int GOOD_GUY_STARTING_HEALTH = 20;
        private const int BAD_GUY_STARTING_HEALTH = 20;

        private readonly Faction FACTION;

        private int health;
        private string name;
        private bool isAlive;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        private Weapon weapon;
        private Armor armor;

        public Warrior(string name,Faction faction)
        {
            this.name = name;
            FACTION = faction;
            isAlive = true;
            switch (faction)
            {
                case Faction.GoodGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = GOOD_GUY_STARTING_HEALTH;
                    break;
                case Faction.BadGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = BAD_GUY_STARTING_HEALTH;
                    break;
                default:
                    break;
            }
        }

        public void Attack(Warrior enemy)
        {
            int damage = weapon.Damage / enemy.armor.ArmorPoints;
            enemy.health -= damage;
            if(enemy.health <= 0)
            {
                enemy.isAlive = false;
                Tools.colorfull($"{enemy.name} dimdik ayaqda oldu! Qelebe canavar {name} - a mexsusdur.",ConsoleColor.DarkBlue);
            }
            else
            {
                Tools.colorfull($"{name} {enemy.name} - a hucum edir. Hal-hazirda {enemy.name} -a vurulan zerbe {damage} qederdi.Qarsi terefin saglamligi ise {enemy.health} qederdi",ConsoleColor.DarkGray);
            }
        }

    }
}
