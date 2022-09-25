using System;
using System.Security.Cryptography.X509Certificates;

namespace Project_CS
{
    public class Battle
    {

        public void Fight()
        {
            
            Gon gon = new Gon();
            Kirua kirua = new Kirua();
            Zushi zushi = new Zushi();


            void CharacterChoice()
            {
                
                string choice = Console.ReadLine();
                switch (choice)
                
                {
                    case ("1") :
                        
                        gon.Character();
                        Console.Clear();
                        gon.printStats();
                        break;
                    
                    case ("2") : 
                        
                        kirua.Character();
                        Console.Clear();
                        kirua.printStats();
                        break;
                    
                    case ("3"):
                        
                        zushi.Character();
                        Console.Clear();
                        zushi.printStats();
                        break;
                
                    default:
                        
                        Console.WriteLine("La selection n'est pas bonne.");
                        CharacterChoice();
                        break;
                }
            }
            
            void Startfight(Ally ally , Ennemies ennemy)
            {
                
                Console.WriteLine($"THE FIGHT START : {ally.Name} VS {ennemy.Name}");
                while (ally.Health > 0 && ennemy.Health > 0)
                {
                    ally.AllyAttack(ally , ennemy);
                    ennemy.EnnemyAttack(ennemy, ally);
                }

                if (ally.Health > 0)
                {
                    Console.WriteLine("YOU WIN!"); 
                    
                }
                else if (ennemy.Health >0)
                {
                    Console.WriteLine("you loose ... try again");
                    Startfight(ally,ennemy);
                }
            }

            void menu(Ally ally)
            {
                
            }

            Console.Clear();

            Console.WriteLine("Bienvenue dans la tour Celeste, il y a un total de 50 etages ici, \n" +
                              "tout les 10 étages il vous rencontrerez un maitre d'etage qui vous \n" +
                              "permettra si vous le battez a acceder a la dizaine d'etages suivante.\n" +
                              "Vous avez le droit de combattre uniquement les maitres d'etages pour \n" +
                              "monter par dizaines mais les combats seront plus hardus");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Je vais commencer par prendre votre identiée, qui etes vous?");
            Console.WriteLine("Pour choisir votre personnage choisissez respectivement : 1 pour Gon | 2 pour Kirua | " +
                              "3 pour Zishi | \n"+
                              "Gon : 1          Kirua               Zushi \n"+
                              "Vie : 100        Vie : 100           Vie : 125 \n"+
                              "Force : 12       Force : 9           Force : 9 \n"+
                              "Esquive : 15     Esquive : 20        Esquive : 15 \n"+
                              "Nen : 0          Nen : 0             Nen : 1 ");


            CharacterChoice();

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Laissez moi vous presentez maitre wing .... ");
            Console.WriteLine("Utlilité du role de wing");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("proposition du combat");
            
            Console.ReadLine();
            Console.Clear();
            

            Guido guido = new Guido();
            guido.Character();

            if (gon.Health > 1)
            {
                Startfight(gon , guido);
                gon.Heal(gon);
                gon.printStats();

            }
            if (kirua.Health > 1)
            {
                Startfight(kirua , guido);
                kirua.Heal(kirua);
                kirua.printStats();

            }
            if (zushi.Health > 1)
            {
                Startfight(zushi , guido);
                zushi.Heal(zushi);
                zushi.printStats();
            }
            
            
            
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("menu inter combat");
            Console.ReadLine();
            Console.Clear();
            
        }
    }
}








    /* 
    ici c'est le menu ou tu peux t'ammeliorer
    -> ameliorer le nen : vie +25 ; puissance +10 ; dodge +3 ; crit +3
    -> ameliorer la puissance *2
    -> ameliorer le dodge +15
    -> ameliorer le crit +15
    */
    
