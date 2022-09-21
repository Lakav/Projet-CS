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
    }
}