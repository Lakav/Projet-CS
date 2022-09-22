using System;

namespace Project_CS
{
    public class Gon : Entities
    {
        public void gon()
        {
            this.Name = "Gon";
            this.Powerfull = 12;
            this.Dodge = 15;
            this.Health = 100;
            this.Nen = 0;
            this.Crit = 5;
        }

        public void printStatsGon()
        {
            Console.WriteLine($"{Name} a une puissance de {Powerfull}, une esquive de {Dodge}, {Health} poits de vie et" +
                              $" un Nen a {Nen}");
        }

        public void ChDodge()
        {
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

        public void Cc()
        {
            Random crit = new Random();
            int chance = crit.Next(0, 100);

            if (chance <= Crit)
            {
                Console.WriteLine("THAT'S A CRIT!!!");
            }

            if (chance > Crit)
            {
                Console.WriteLine("just a hit");
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