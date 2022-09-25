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
                    Console.WriteLine("you loose ...\n" +
                                      "restart for a new game");
                    Environment.Exit(0);
                }
            }

            void Menu(Ally ally)
            {
                Console.WriteLine("Choisissez qu'elle compétence améliorer");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("Vous avez choisi d'améliorer le Nen");
                    Console.WriteLine("es-tu vraiement sûr de ton choix");
                    Console.WriteLine("Y/N");

                    string validation = Console.ReadLine();

                    if(validation == "Y" || validation == "y")
                    {
                        ally.Health += 25;
                        ally.Powerfull += 10;
                        ally.Dodge += 3;
                        ally.Crit += 15;
                        ally.Nen += 1;
                        ally.printStats();
                        Menu(ally); 
                    }

                    if(validation == "N" || validation == "n")
                    {
                        Console.WriteLine("Choix annulé");
                        Menu(ally);
                    }
                    else if(validation != "Y" && validation != "y" && validation != "N" && validation != "n") 
                    {
                        Console.WriteLine("Choix Incompris");
                        Menu(ally);
                    }
                }

                if (choice == "2")
                {
                    Console.WriteLine("Vous avez choisi d'améliorer votre force");
                    Console.WriteLine("es-tu vraiement sûr de ton choix");
                    Console.WriteLine("Y/N");

                    string validation = Console.ReadLine();

                    if(validation == "Y" || validation == "y")
                    {
                        ally.Powerfull *= 2;
                        ally.printStats();
                        Menu(ally);
                    }

                    if(validation == "N" || validation == "n")
                    {
                        Console.WriteLine("Choix annulé");
                        Menu(ally);
                    }
                    else if(validation != "Y" && validation != "y" && validation != "N" && validation != "n") 
                    {
                        Console.WriteLine("Choix Incompris");
                        Menu(ally);
                    }
                }

                    

                if (choice == "3")
                {
                    Console.WriteLine("Vous avez choisi d'améliorer votre esquive");
                    Console.WriteLine("es-tu vraiement sûr de ton choix");
                    Console.WriteLine("Y/N");

                    string validation = Console.ReadLine();

                    if(validation == "Y" || validation == "y")
                    { 
                        ally.Dodge += 3;
                        Menu(ally);
                    }

                    if(validation == "N" || validation == "n")
                    {
                        Console.WriteLine("Choix annulé");
                        Menu(ally);
                    }
                    else if(validation != "Y" && validation != "y" && validation != "N" && validation != "n") 
                    {
                        Console.WriteLine("Choix Incompris");
                        Menu(ally);
                    }

                   
                }

                if (choice == "4")
                {
                    Console.WriteLine("Vous avez choisi d'améliorer vos coups critique");
                    Console.WriteLine("es-tu vraiement sûr de ton choix");
                    Console.WriteLine("Y/N");

                    string validation = Console.ReadLine();
                    
                    if(validation == "Y" || validation == "y")
                    {
                    ally.Crit += 15;
                    Menu(ally);
                    }

                    if(validation == "N" || validation == "n")
                    {
                        Console.WriteLine("Choix annulé");
                        Menu(ally);
                    }
                    else if(validation != "Y" && validation != "y" && validation != "N" && validation != "n")
                    {
                        Console.WriteLine("Choix Incompris");
                        Menu(ally);
                    }
                }

                if (choice == "5")
                {
                    Console.WriteLine("Vous avez choisi de quitter le menu");
                    Console.WriteLine("es-tu vraiement sûr de ton choix");
                    Console.WriteLine("Y/N");

                    string validation = Console.ReadLine();

                    if(validation == "Y" || validation == "y")
                    {
                        Console.WriteLine("Bon match !!");
                    }
                    if(validation == "N" || validation == "n")
                    {
                        Console.WriteLine("Choix annulé");
                        Menu(ally);
                    }
                    else if(validation != "Y" && validation != "y" && validation != "N" && validation != "n")
                    {
                        Console.WriteLine("Choix Incompris");
                        Menu(ally);
                    }
                }
                else if(choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5")
                {
                    Console.WriteLine("Choix Incompris");
                    Menu(ally); 
                }

            /* 
            ici c'est le menu ou tu peux t'ammeliorer
            -> ameliorer le nen : vie +25 ; puissance +10 ; dodge +3 ; crit +3
            -> ameliorer la puissance *2
            -> ameliorer le dodge +15
            -> ameliorer le crit +15
            */
            }

            Console.Clear();

            Console.WriteLine("Bienvenue dans la tour Celeste, il y a un total de 50 etages ici, \n" +
                              "tout les 10 étages il vous rencontrerez un maitre d'etage qui vous \n" +
                              "permettra si vous le battez a acceder a la dizaine d'etages suivante.\n" +
                              "Vous avez le droit de combattre uniquement les maitres d'etages pour \n" +
                              "monter par dizaines mais les combats seront plus hardus.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Je vais commencer par prendre votre identiée, qui etes vous?");
            Console.WriteLine("Pour choisir votre personnage choisissez respectivement : | 1 pour Gon | 2 pour Kirua | 3 pour Zishi | \n"+
                              "\n"+
                              "Gon              Kirua               Zushi \n"+
                              "Vie : 100        Vie : 100           Vie : 125 \n"+
                              "Force : 12       Force : 9           Force : 9 \n"+
                              "Esquive : 15     Esquive : 20        Esquive : 15 \n"+
                              "Nen : 0          Nen : 0             Nen : 1 \n"+
                              "");

            
            CharacterChoice();

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Avant toute chose laissez-moi vous présenter maître Wing, son rôle sera de vous accompagner \n"+
                              "tout au long de votre ascension dans la tour céleste, en vous permettant à la fin de chaque \n"+
                              "combat d'améliorer différentes compétences en échange de crédit que vous obtiendrez après chaque victoire.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Commençons sans attendre le premier combat");
            
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
            Console.WriteLine("Menu inter combat");
            Console.ReadLine();
            Console.Clear();

            if (gon.Health > 1)
            {
                Menu(gon);
            }
            if (kirua.Health > 1)
            {
                Menu(kirua);
            }
            if (zushi.Health > 1)
            {
                Menu(zushi);
            }

///////////////////////////////////////////////////////////////////

            Riehvelt riehvelt = new Riehvelt();
            riehvelt.Character();

            if (gon.Health > 1)
            {
                Startfight(gon , riehvelt);
                gon.Heal(gon);
                gon.printStats();

            }
            if (kirua.Health > 1)
            {
                Startfight(kirua , riehvelt);
                kirua.Heal(kirua);
                kirua.printStats();

            }
            if (zushi.Health > 1)
            {
                Startfight(zushi , riehvelt);
                zushi.Heal(zushi);
                zushi.printStats();
            }

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Menu inter combat");
            Console.ReadLine();
            Console.Clear();

            if (gon.Health > 1)
            {
                Menu(gon);
            }
            if (kirua.Health > 1)
            {
                Menu(kirua);
            }
            if (zushi.Health > 1)
            {
                Menu(zushi);
            }

///////////////////////////////////////////////////////////////////

            Kastrot kastrot = new Kastrot();
            kastrot.Character();

            if (gon.Health > 1)
            {
                Startfight(gon , kastrot);
                gon.Heal(gon);
                gon.printStats();

            }
            if (kirua.Health > 1)
            {
                Startfight(kirua , kastrot);
                kirua.Heal(kirua);
                kirua.printStats();

            }
            if (zushi.Health > 1)
            {
                Startfight(zushi , kastrot);
                zushi.Heal(zushi);
                zushi.printStats();
            }

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Menu inter combat");
            Console.ReadLine();
            Console.Clear();

            if (gon.Health > 1)
            {
                Menu(gon);
            }
            if (kirua.Health > 1)
            {
                Menu(kirua);
            }
            if (zushi.Health > 1)
            {
                Menu(zushi);
            }

///////////////////////////////////////////////////////////////////
            
            Kuroro kuroro = new Kuroro();
            kuroro.Character();

            if (gon.Health > 1)
            {
                Startfight(gon , kuroro);
                gon.Heal(gon);
                gon.printStats();

            }
            if (kirua.Health > 1)
            {
                Startfight(kirua , kuroro);
                kirua.Heal(kirua);
                kirua.printStats();

            }
            if (zushi.Health > 1)
            {
                Startfight(zushi , kuroro);
                zushi.Heal(zushi);
                zushi.printStats();
            }

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Menu inter combat");
            Console.ReadLine();
            Console.Clear();

            if (gon.Health > 1)
            {
                Menu(gon);
            }
            if (kirua.Health > 1)
            {
                Menu(kirua);
            }
            if (zushi.Health > 1)
            {
                Menu(zushi);
            }

///////////////////////////////////////////////////////////////////

            Hisoka hisoka = new Hisoka();
            hisoka.Character();

            if (gon.Health > 1)
            {
                Startfight(gon , hisoka);
                gon.Heal(gon);
                gon.printStats();

            }
            if (kirua.Health > 1)
            {
                Startfight(kirua , hisoka);
                kirua.Heal(kirua);
                kirua.printStats();

            }
            if (zushi.Health > 1)
            {
                Startfight(zushi , hisoka);
                zushi.Heal(zushi);
                zushi.printStats();
            }

            
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Félicitations vous avez réussi à gravir la tour !!!");           
            
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
    
