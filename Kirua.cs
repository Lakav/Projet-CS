using System;
namespace Project_CS
{
    public class Kirua : Entities
    {
        public void kirua()
        {
            this.Name = "Kirua";
            this.Powerfull = 9;
            this.Dodge = 20;
            this.Health = 100;
            this.Nen = 0;
        }
        public void printStatsKirua()
        {
            Console.WriteLine($"{Name} a une puissance de {Powerfull}, une esquive de {Dodge}, {Health} poits de vie et" +
                              $" un Nen a {Nen}");
        }
    }
    
}