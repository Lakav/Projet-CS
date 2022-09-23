using System;

namespace Project_CS
{
    public class Ally : Entities
    {
        public void AllyCharacter()
        {
            Name = "Ally";
            Powerfull = 0;
            Dodge = 0;
            Health = 0;
            Nen = 0;
            Crit = 0;
        }
        
        public void AllyAttack(Ennemies ennemy)
        {
            Random dodge = new Random();
            int chanceD = dodge.Next(0, 100);
            
            if (chanceD <= Dodge)
            {
                Console.WriteLine($"{Name} have dodged");
                

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
                    Console.WriteLine($"- {HR}");
                    ennemy.Health -= HR;
                    if (ennemy.Health <= 0)
                    {
                
                        Console.WriteLine("He's dead...");
                        Environment.Exit(0);
                    }
                    Powerfull /= 2;
                }   

                if (chance > Crit)
                { 
                    Console.WriteLine($"{Name} : just a hit");
                    int max = Powerfull + 4;
                    int min = Powerfull - 4;
                    Random hRange = new Random();
                    int HR = hRange.Next(min, max);
                    Console.WriteLine($"- {HR}");
                    ennemy.Health -= HR;
                    if (ennemy.Health <= 0)
                    {
                
                        Console.WriteLine("He's dead...");
                        Environment.Exit(0);
                    }
                
                }

            }
            
            
            

      
        }
    }
}
