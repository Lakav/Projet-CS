using System;

namespace Project_CS
{
    public class Ally : Entities
    {
        public void AllyCharacter()
        {
            Name = "Ally";
            Powerfull = 0;
            Dodge = 0;
            Health = 0;
            Nen = 0;
            Crit = 0;
        }
        
        public void AllyAttack(Ally ally , Ennemies ennemy)
        {
            if (ally.Health > 0)
            {
                Random dodge = new Random();
                int chanceD = dodge.Next(0, 100);

                if (chanceD <= Dodge)
                {
                    Console.WriteLine($"{Name} have dodged");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (chanceD > Dodge)
                {

                    Random crit = new Random();
                    int chance = crit.Next(0, 100);

                    if (chance <= Crit)
                    {
                        Console.WriteLine($"{Name} : THAT'S A CRIT!!!");
                        Powerfull *= 2;
                        int max = Powerfull + 4;
                        int min = Powerfull - 4;
                        Random hRange = new Random();
                        int HR = hRange.Next(min, max);

                        Console.WriteLine($"- {HR} HP!");
                        ennemy.Health -= HR;
                        Console.WriteLine($"{ennemy.Name} is {ennemy.Health} remaining");
                        if (ennemy.Health <= 0)
                        {

                            Console.WriteLine("He's dead...");
                        }

                        Powerfull /= 2;
                        Console.ReadLine();
                        Console.Clear();
                    }

                    if (chance > Crit)
                    {
                        Console.WriteLine($"{Name} : just a hit");
                        int max = Powerfull + 4;
                        int min = Powerfull - 4;
                        Random hRange = new Random();
                        int HR = hRange.Next(min, max);
                        Console.WriteLine($"- {HR} HP!");
                        ennemy.Health -= HR;
                        Console.WriteLine($"{ennemy.Name} is {ennemy.Health} remaining");
                        if (ennemy.Health <= 0)
                        {

                            Console.WriteLine("He's dead...");

                        }

                        Console.ReadLine();
                        Console.Clear();

                    }
                }

            }


        }

        public void Heal(Ally ally)
        {
            if (ally.Nen == 0)
            {
                ally.Health = 100;
            }
            if (ally.Nen == 1)
            {
                ally.Health = 125;
            }
            if (ally.Nen == 2)
            {
                ally.Health = 150;
            }
            if (ally.Nen == 3)
            {
                ally.Health = 175;
            }
            if (ally.Nen == 4)
            {
                ally.Health = 200;
            }
            if (ally.Nen == 5)
            {
                ally.Health = 250;
            }
            
            
        }

    }
}
