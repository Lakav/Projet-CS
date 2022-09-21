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
        }

        public void printStatsGon()
        {
            Console.WriteLine($"{Name} a une puissance de {Powerfull}, une esquive de {Dodge}, {Health} poits de vie et" +
                              $" un Nen a {Nen}");
        }
    }
    
}