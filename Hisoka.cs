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
    }
}