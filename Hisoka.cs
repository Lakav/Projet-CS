using System;
namespace Project_CS
{
    public class Hisoka : Entities
    {
        public void hisoka()
        {
            this.Name = "hisoka";
            this.Powerfull = 15;
            this.Dodge = 35;
            this.Health = 200;
            this.Nen = 5;
        }
        public void printStatsHisoka()
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
            
            int max = Powerfull + 8;
            int min = Powerfull - 8;
            Random hRange = new Random();
            int HR = hRange.Next(min, max);
            Console.WriteLine($"- {HR}");
        }
    }
}