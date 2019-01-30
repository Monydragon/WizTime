using System;
using System.Security.Cryptography;

namespace WizTime
{
    public class Fighter : Actor
    {
        public Fighter()
        {
            
        }

        public Fighter(string name)
        {
            Name = name;
        }

        public void Attack(Fighter act)
        {
            isAttacking = true;
            engagedInBattle = true;
            

            if (act.engagedInBattle == false)
            {
                act.engagedInBattle = true;
            }

            Hit(act);
            
        }

        public void Defend(Fighter act)
        {
            isDefending = true;
            act.isDefending = true;
            Block(act);
            
        }

        public int Hit(Fighter act)
        {
            var rand = new Random();
            var randval = rand.Next(baseStrength, baseStrength + WeaponSlot.Strength);
            Console.WriteLine($"{Name} Hits {act.Name} for {randval} Damage!");
            act.TakeDamage(randval);
            return randval;
        }

        public int Block(Fighter act)
        {
            var rand = new Random();
            var randval = rand.Next(baseDefense, baseDefense + ShieldSlot.Defense);
            Console.WriteLine($"{Name} Gets blocked and managed to only damage {act.Name} for {randval} damage.");
            act.TakeDamage(randval);
            return randval;
        }

        public void Miss(Fighter act)
        {
            Console.WriteLine($"{Name} MISSED! while trying to attack {act.Name}");
        }
        
    }
}