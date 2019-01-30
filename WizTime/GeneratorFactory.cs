using System;
using System.Collections.Generic;

namespace WizTime
{
    public static class GeneratorFactory
    {
        public static List<Item> LevelOneItems = new List<Item>()
        {
            new Item("Potion", 10, false),
            new Item("Rock", 2, true),
            new Item("Wooden Sword", 20, true),
            new Item("Wooden Shield", 20, true),
            new Item("Gemstone", 100, false),
            new Item("Slime Eye", 150, false)
        };

        public static Fighter GenerateFighter(string name, int level = 1, int rarity = 1)
        {
            Fighter gen = new Fighter(name);
            gen.Level = level;
            gen.Gold = GenerateGold(level, rarity);
            gen.Inventory = GenerateInventory(level, rarity);
            return gen;
        }
        
        public static Actor GenerateActor(string name, int level = 1, int rarity = 1)
        {
            Actor gen = new Actor(name);
            gen.Level = level;
            gen.Gold = GenerateGold(level, rarity);
            gen.Inventory = GenerateInventory(level, rarity);
            return gen;
        }

        public static int GenerateLootLevel(int level, int rarity)
        {
            var rand = new Random();
            var rarityLevel = rand.Next(level, rarity * 10);
            return rarityLevel;
        }

        public static int GenerateGold(int level, int rarity)
        {
            var rand = new Random();
            var goldGen = rand.Next(0, level * rarity + 10);
            return goldGen;
        }

        public static List<Item> GenerateInventory(int level, int rarity)
        {
            var items = new List<Item>();
            var rand = new Random();
            var ItemGenAmount = rand.Next(0, level * rarity + 5);
            //TODO: Load in items from a JSON file for now use static items from list

            for (int i = 0; i < ItemGenAmount; i++)
            {
                var rand2 = new Random();
                var randItem = rand2.Next(LevelOneItems.Count);
                items.Add(LevelOneItems[randItem]);
            }

            return items;
        }

    }
}