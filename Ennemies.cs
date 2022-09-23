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
            Cc();
            ChDodge();
            
            int max = Powerfull + 4;
            int min = Powerfull - 4;
            Random hRange = new Random();
            int HR = hRange.Next(min, max);
            Console.WriteLine($"- {HR}");
            ally.Health -= HR;
            if (ally.Health <= 0)
            {
                
                Console.WriteLine("You'r dead!");
                Environment.Exit(0);
            }
      
        }
    }
}