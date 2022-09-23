using System;
using System.IO.MemoryMappedFiles;

namespace Project_CS
{
    public class Program
    {
        static void Main(string[] args)
        {
           // Battle fight = new Battle(); 
           // fight.Fight(); 
           /*
            Gon gon = new Gon();
            Hisoka hisoka = new Hisoka();
            hisoka.Character();
            gon.Character();
            Console.WriteLine(hisoka.Name);
            Console.WriteLine(gon.Name);
            gon.AllyAttack(hisoka);*/

           Gon gon = new Gon();
           gon.Character();
           Hisoka hisoka = new Hisoka();
           hisoka.Character();
           gon.AllyAttack(hisoka);
           hisoka.EnnemyAttack(gon);
           gon.AllyAttack(hisoka);
           hisoka.EnnemyAttack(gon);
           gon.AllyAttack(hisoka);
           hisoka.EnnemyAttack(gon);
           gon.AllyAttack(hisoka);
           hisoka.EnnemyAttack(gon);
           gon.AllyAttack(hisoka);
           hisoka.EnnemyAttack(gon);
           gon.AllyAttack(hisoka);
           hisoka.EnnemyAttack(gon);
           
        }
    }

    

}