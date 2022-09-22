using System;
namespace Project_CS
{
    public class Riehvelt : Entities
    {

        public void riehvelt()
        {
            this.Name = "Riehvelt";
            this.Powerfull = 5;
            this.Dodge = 10;
            this.Health = 85;
            this.Nen = 2;
        }
        public void printStatsRiehvelt()
        {
            Console.WriteLine($"{Name} a une puissance de {Powerfull}, une esquive de {Dodge}, {Health} poits de vie et" +
                              $" un Nen a {Nen}");
        }
        
        public void ChDodge()
        {
            Console.WriteLine(Name);
            Random dodge = new Random();
            int chance = dodge.Next(0, 100);
            
            if (chance <= Dodge)
            {
                Console.WriteLine("You have dodged");
            }
            else if (chance > Dodge)
            {
                Console.WriteLine("You haven't dodged");
            }
        }
        public void HitRange()
        {
            
            int max = Powerfull + 4;
            int min = Powerfull - 4;
            Random hRange = new Random();
            int HR = hRange.Next(min, max);
            Console.WriteLine($"- {HR}");
        }
    }
}