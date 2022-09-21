using System;
namespace Project_CS
{
    public class Zushi : Entities
    {
        public void zushi()
        {
            this.Name = "Zushi";
            this.Powerfull = 9;
            this.Dodge = 15;
            this.Health = 110;
            this.Nen = 1;
        }
        public void printStatsZushi()
        {
            Console.WriteLine($"{Name} a une puissance de {Powerfull}, une esquive de {Dodge}, {Health} poits de vie et" +
                              $" un Nen a {Nen}");
        }
    }
    
}