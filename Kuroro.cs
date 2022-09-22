using System;
namespace Project_CS
{
    public class Kuroro : Entities
    {
        public void kuroro()
        {
            this.Name = "Kuroro";
            this.Powerfull = 11;
            this.Dodge = 20;
            this.Health = 160;
            this.Nen = 2;
        }
        public void printStatsKuroro()
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