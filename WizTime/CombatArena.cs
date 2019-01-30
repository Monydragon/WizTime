using System;
using System.Security.Cryptography;

namespace WizTime
{
    public class CombatArena
    {
        public void BattleArea(Fighter f1, Fighter f2)
        {
            Console.WriteLine($"{f1.Name} ENTERS THE AREA AGAINST {f2.Name}");
            Console.WriteLine("BOTH FIGHTERS ARE UNARMED CURRENTLY AND WILLING TO FIGHT!");
        }

        public void FindEquipment(Fighter f1)
        {
            Console.WriteLine($"FIGHTER: {f1.Name} is Scrounging for equipment!");

                var random = new Random();
                var RanVal = random.Next(1, 6);
                Console.WriteLine($"Random Number Chosen: {RanVal}");

                switch (RanVal)
                {
                    case 1:
                    {
                        Console.WriteLine($"{f1.Name} FINDS NOTHING!");
                    }
                        break;
                    case 2:
                    {
                        Console.WriteLine($"{f1.Name} FINDS A ROCK FOR A WEAPON NO SHIELD!");
                        f1.WeaponSlot = new Weapon("Rock", 3);
                    }
                        break;
                    case 3:
                    {
                        Console.WriteLine($"{f1.Name} FINDS A Wooden Sword and NO SHIELD!");
                        f1.WeaponSlot = new Weapon("Wooden Sword", 10);
                    }
                        break;
                    case 4:
                    {
                        Console.WriteLine($"{f1.Name} FINDS A Wooden Shield and A Rock Weapon!");
                        f1.WeaponSlot = new Weapon("Rock", 3);
                        f1.ShieldSlot = new Shield("Wooden Shield", 5);
                    }
                        break;
                    case 5:
                    {
                        Console.WriteLine($"{f1.Name} LUCKY! FINDS A Wooden Sword & Shield");

                        f1.WeaponSlot = new Weapon("Wooden Sword", 10); 
                        f1.ShieldSlot = new Shield("Wooden Shield", 5);  
                    }
                        break;
                }
                
        }
    }
}