using System;

namespace Project_CS
{
    public class Inventory : Ally
    {
        
        
        public void UpgradeNen(string price)
        {
            Money -= int.Parse(price);
            Nen += 1;
            Dodge += 5;
            Health += 25;
            Powerfull *= 2;
        }

        public void HealEndFight()
        {
            if (Nen == 0)
            {
                Health = 100;
            }
            if (Nen == 1)
            {
                Health = 125;
            }
            if (Nen == 2)
            {
                Health = 150;
            }
            if (Nen == 3)
            {
                Health = 175;
            }
            if (Nen == 4)
            {
                Health = 200;
            }
        }
    }
}