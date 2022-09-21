using System;
using System.Security.Cryptography.X509Certificates;

namespace Project_CS
{
    public class Entities
    {
        public int health { get; set; } = 0;
        public int powerfull { get; set; }
        public int dodge { get; set; }
        public int Nen { get; set; } = 0;

        public Entities(int _health, int _powerfull, int _dodge, int _nen)
        {
            health = _health;
            powerfull = _powerfull;
            dodge = _dodge;
            Nen = _nen;
        }
    }
}