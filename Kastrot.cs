using System;
namespace Project_CS
{
    public class Kastrot : Ennemies
    {
        public void kastrot()
        {
            this.Name = "Kastrot";
            this.Powerfull = 11;
            this.Dodge = 15;
            this.Health = 110;
            this.Nen = 3;
        }
        public void printStatsKastrot()
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