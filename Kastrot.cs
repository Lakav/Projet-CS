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
    }
}