using System;
namespace Project_CS
{
    public class Hisoka : Ennemies
    {
        public new void Character()
        {
            this.Name = "hisoka";
            this.Powerfull = 50;
            this.Dodge = 35;
            this.Health = 200;
            this.Nen = 5;
        }
    }
}