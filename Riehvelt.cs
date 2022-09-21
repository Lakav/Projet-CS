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
    }
}