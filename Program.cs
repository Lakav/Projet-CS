using System;
using System.IO.MemoryMappedFiles;

namespace Project_CS
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*//Battle fight = new Battle();
            //fight.Fight(); */
           /* Gon gon = new Gon();
            gon.gon();
            gon.HitRange();
            gon.Cc();*/
            Gon gon = new Gon();
            Hisoka hisoka = new Hisoka();
            hisoka.Character();
            gon.Character();
            Console.WriteLine(hisoka.Name);
            Console.WriteLine(gon.Name);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
            gon.AllyAttack(hisoka);
        }
    }

    

}