using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace Project_CS
{
    public class Entities
    {

        private int _health;
        private int _powerfull;
        private int _nen;
        private int _dodge;
        private string _name;
        private int _money = 20;
        private int _crit;

        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public int Powerfull
        {
            get { return _powerfull; }
            set { _powerfull = value; }
        }

        public int Nen
        {
            get { return _nen; }
            set { _nen = value; }
        }

        public int Dodge
        {
            get { return _dodge; }
            set { _dodge = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Money
        {
            get { return _money; }
            set { _money = value; }
        }

        public int Crit
        {
            get { return _crit; }
            set { _crit = value; }
        }

        public void Character()
        {
            this.Name = "";
            this.Powerfull = 0;
            this.Dodge = 0;
            this.Health = 0;
            this.Nen = 0;
            this.Crit = 0;
        }
        public void printStats()
        {
            Console.WriteLine($"{Name} a une puissance de {Powerfull}, une esquive de {Dodge}, {Health} poits de vie et" +
                              $" un Nen a {Nen}");
        }
        public void ChDodge()
        {
            Random dodge = new Random();
            int chance = dodge.Next(0, 100);
            
            if (chance <= Dodge)
            {
                Console.WriteLine("You have dodged");
            }
            else if (chance > Dodge)
            {
                Console.WriteLine("You haven't dodged");
            }
        }

        public void Cc()
        {
            Random crit = new Random();
            int chance = crit.Next(0, 100);

            if (chance <= Crit)
            {
                Console.WriteLine("THAT'S A CRIT!!!");
            }

            if (chance > Crit)
            {
                Console.WriteLine("just a hit");
            }
        }

        public void CharacterChoice()
        {
            
        }

    }
}