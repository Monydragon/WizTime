using System;
using System.Collections.Generic;

namespace WizTime
{
    public class Actor
    {
        public string Name;
        public int Health = 100;
        public int baseStrength = 1;
        public int baseDefense = 1;
        public int Gold = 0;
        public int Level = 1;
        public int Exp = 0;
        public bool isAlive = true;
        public List<Item> Inventory = new List<Item>();
            
        public EquipSlot headSlot = new EquipSlot(EquipmentSlots.Head);
        public EquipSlot bodySlot = new EquipSlot(EquipmentSlots.Torso);
        public EquipSlot lefthandSlot = new EquipSlot(EquipmentSlots.Left_Hand);
        public EquipSlot righthandSlot = new EquipSlot(EquipmentSlots.Right_Hand);
        public EquipSlot legsSlot = new EquipSlot(EquipmentSlots.Legs);
        public EquipSlot feetSlot = new EquipSlot(EquipmentSlots.Feet);
        
        public Weapon WeaponSlot = new Weapon("Hand", 0);
        public Shield ShieldSlot = new Shield("Hand", 0);
        
        public bool? engagedInBattle = null;
        public bool? isAttacking;
        public bool? isDefending;
        
        public Actor()
        {
            
        }
        
        public Actor(string name)
        {
            Name = name;
        }

        public Actor(string name, int health, int gold)
        {
            Name = name;
            Health = health;
            Gold = gold;
        }

        public string GetStatus()
        {
            string items = string.Empty;

            if (Inventory.Count > 0)
            {
                for (int i = 0; i < Inventory.Count; i++)
                {
                    items += $"{Inventory[i].Name} Cost: {Inventory[i].Value} Equipable: {Inventory[i].isEquipable}\n";
                }
            }
            else
            {
                items = "Empty Inventory";
            }
            
            return $"Name: {Name}\nHealth: {Health}\nGold: {Gold}\nInventory Items:\n{items}";
        }

        public void TakeDamage(int damage)
        {
            var rand = new Random();
            var randDef = rand.Next(baseDefense, baseDefense + ShieldSlot.Defense);

            damage =- randDef;

            if (damage <= 0)
            {
                Console.WriteLine("MISSED!");
            }
            else
            {
                Console.WriteLine($"{Name} takes {damage} damage!");
                Health -= damage;

            }
            
            if (Health <= 0)
            {
                isAlive = false;
            }
        }
        
        

    }
}