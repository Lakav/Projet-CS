using System;
namespace Project_CS
{
    public class Ennemies : Entities
    {
        public void Ennemy()
        {
            Name = "Ennemy";
            Powerfull = 0;
            Dodge = 0;
            Health = 0;
            Nen = 0;
            Crit = 0;
        }
        
        public void EnnemyAttack(Ally ally)
        {
            Random dodge = new Random();
            int chanceD = dodge.Next(0, 100);
            
            if (chanceD <= Dodge)
            {
                Console.WriteLine($"{Name} have dodged");
                Console.ReadLine();
                Console.Clear();

            }
            else if (chanceD > Dodge)
            { 
                Random crit = new Random();
                int chance = crit.Next(0, 100);

                if (chance <= Crit)
                {
                    Console.WriteLine($"{Name} : THAT'S A CRIT!!!");
                    Powerfull *= 2;
                    int max = Powerfull + 4;
                    int min = Powerfull - 4;
                    Random hRange = new Random();
                    int HR = hRange.Next(min, max);
                    Console.WriteLine($"- {HR} HP!");
                    ally.Health -= HR;
                    Console.WriteLine($"{ally.Name} is {ally.Health} HP remaining");
                    if (ally.Health <= 0)
                    {
                
                        Console.WriteLine("You'r dead...");
                        Environment.Exit(0);
                    }
                    Powerfull /= 2;
                    Console.ReadLine();
                    Console.Clear();
                }   

                if (chance > Crit)
                { 
                    Console.WriteLine($"{Name} : just a hit");
                    int max = Powerfull + 4;
                    int min = Powerfull - 4;
                    Random hRange = new Random();
                    int HR = hRange.Next(min, max);
                    Console.WriteLine($"- {HR} HP!");
                    ally.Health -= HR;
                    Console.WriteLine($"{ally.Name} is {ally.Health} HP remaining");
                    if (ally.Health <= 0)
                    {
                
                        Console.WriteLine("You'r dead...");
                        Environment.Exit(0);
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}