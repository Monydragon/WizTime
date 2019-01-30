using System;
using System.IO;
using Newtonsoft.Json;


namespace WizTime
{
    class Program
    {
        
        static void Main(string[] argsi)
        {
//            var characterMony = GeneratorFactory.GenerateActor("Mony");
//            File.WriteAllText(@"Saves/MonyNew.json", JsonConvert.SerializeObject(characterMony));

            
//            using (StreamWriter file = File.CreateText(@"mony.json"))
//            {
//                JsonSerializer serializer = new JsonSerializer();
//                serializer.Serialize(file, characterMony);
//            }
//            
//            
            Console.WriteLine($"Welcome to My Hero Arena\nYour Quest now begins here!\n");
            Console.WriteLine("Please say your name wanna be hero!");
            var heroname = Console.ReadLine();
            var myhero = new Fighter(heroname);
            Console.WriteLine($"{heroname} Has joined the frey among those who dare to battle in THE TACO DOME");
            Console.WriteLine("You are currently at a battle arena called THE TACO DOME. You have limited choices please choose wisely.");
            var arena = new CombatArena();
            
            CharacterActions(myhero);
      
            while (myhero.isAlive)
            {
                CHOICE:
                Console.WriteLine("Please choose what to do... 1: for start combat, 2: to look for equipment, 3: for run away");
                var choice = Console.ReadKey();
                
                Console.WriteLine("Choice is " + choice.Key.ToString());

                switch (choice.KeyChar.ToString())
                {
                    case "1":
                        Console.WriteLine("You choose to start combat");
                        var john = GeneratorFactory.GenerateFighter("John");                        
                        break;
                    case "2":
                        Console.WriteLine("You choose to look for equipment");
                        arena.FindEquipment(myhero);
                        break;
                    case "3":
                        Console.WriteLine("You choose to flee.");
                        break;
                    default:
                        Console.WriteLine("Invalid please try again");
                        goto CHOICE;
                        break;
                }

            }
            
            
            
            
            BattleArena:
            Console.WriteLine("ENTERED BATTLE ARENA MODE");
            
            
            //TODO:Add in loop content for gameplay based on zork styled gameplay, Directional or based around that kind of content.
            
            var mymonster = new Fighter("Usilva");
            Console.Read();
            arena.BattleArea(myhero,mymonster);
            arena.FindEquipment(myhero);
            arena.FindEquipment(mymonster);
            Console.Read();
            Console.WriteLine("BATTLE TIME!!!");
            
            
            while (myhero.isAlive && mymonster.isAlive)
            {
                myhero.Attack(mymonster);
                mymonster.Attack(myhero);
                if (mymonster.Health <= 0)
                {
                    Console.WriteLine("Hero Killed Monster!");
                    break;
                }
            }

            if (myhero.isAlive == false)
            {
                Console.WriteLine("HERO WAS SLAIN!");
            }

            Console.WriteLine(myhero.GetStatus());
            

            Console.Read();
        }

        public static void CharacterActions(Actor ac)
        {
            while (true)
            {
                Console.WriteLine("Type the following commands:\nFight\nSearch\nInv\nFlee\nStatus");
                var action = Console.ReadLine();
                switch (action.ToUpper())
                {
                    case "FIGHT":
                         Console.WriteLine("You Fight");
                        break; 
                    case "SEARCH":
                        Console.WriteLine("You Search for items");
                        ac.Inventory.Add(GeneratorFactory.LevelOneItems[2]);
                        break;
                    case "INV":
                        Console.WriteLine("You access your inventory");
                        break;
                    case "FLEE":
                        Console.WriteLine("You flee");
                        break;
                    case "STATUS":
                        Console.WriteLine("You Check your status");
                        Console.WriteLine(ac.GetStatus());
                        break;
                     default:
                         Console.WriteLine("Invalid command,");
                        break;
                }
            }
        }
    }
}
