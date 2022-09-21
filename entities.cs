using System;
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
    }
}