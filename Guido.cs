using System;
namespace Project_CS
{
    public class Guido : Ennemies
    {
        public void guido()
        {
            this.Name = "Guido";
            this.Powerfull = 3;
            this.Dodge = 5;
            this.Health = 55;
            this.Nen = 3;
        }
        public void printStatsGuido()
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
    }
}