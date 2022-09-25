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
                Console.WriteLine("Je vais commencer par prendre votre identiée, qui etes vous?");
                Console.WriteLine("Pour choisir votre personnage choisissez respectivement : | 1 pour Gon | 2 pour Kirua | 3 pour Zishi | \n"+
                                  "\n"+
                                  "Gon              Kirua               Zushi \n"+
                                  "Vie : 100        Vie : 100           Vie : 125 \n"+
                                  "Force : 12       Force : 9           Force : 9 \n"+
                                  "Esquive : 15     Esquive : 20        Esquive : 15 \n"+
                                  "Nen : 0          Nen : 0             Nen : 1 \n"+
                                  "");


                string choice = Console.ReadLine();
                switch (choice)
                
                {
                    case ("1") :
                        
                    Console.WriteLine("Vous avez choisi Gon");
                    Console.WriteLine("es-tu vraiement sûr de ton choix");
                    Console.WriteLine("Y/N");

                    string validation = Console.ReadLine();

                    if(validation == "Y" || validation == "y")
                    {
                        gon.Character();
                        Console.Clear();
                        gon.printStats(); 
                    }

                    if(validation == "N" || validation == "n")
                    {
                        Console.WriteLine("Choix annulé");
                        CharacterChoice();
                    }
                    else if(validation != "Y" && validation != "y" && validation != "N" && validation != "n") 
                    {
                        Console.WriteLine("Choix Incompris");
                        CharacterChoice();
                    }
                    break;
                        
                    
                    case ("2") : 
                        
                    Console.WriteLine("Vous avez choisi Kirua");
                    Console.WriteLine("es-tu vraiement sûr de ton choix");
                    Console.WriteLine("Y/N");

                    string validation2 = Console.ReadLine();

                    if(validation2 == "Y" || validation2 == "y")
                    {
                        kirua.Character();
                        Console.Clear();
                        kirua.printStats(); 
                    }

                    if(validation2 == "N" || validation2 == "n")
                    {
                        Console.WriteLine("Choix annulé");
                        CharacterChoice();
                    }
                    else if(validation2 != "Y" && validation2 != "y" && validation2 != "N" && validation2 != "n") 
                    {
                        Console.WriteLine("Choix Incompris");
                        CharacterChoice();
                    }
                    break;
                    
                    case ("3"):
                        
                    Console.WriteLine("Vous avez choisi Zushi");
                    Console.WriteLine("es-tu vraiement sûr de ton choix");
                    Console.WriteLine("Y/N");

                    string validation3 = Console.ReadLine();

                    if(validation3 == "Y" || validation3 == "y")
                    {
                        zushi.Character();
                        Console.Clear();
                        zushi.printStats(); 
                    }

                    if(validation3 == "N" || validation3 == "n")
                    {
                        Console.WriteLine("Choix annulé");
                        CharacterChoice();
                    }
                    else if(validation3 != "Y" && validation3 != "y" && validation3 != "N" && validation3 != "n") 
                    {
                        Console.WriteLine("Choix Incompris");
                        CharacterChoice();
                    }
                    break;
                
                    default:
                        
                        Console.WriteLine("La selection n'est pas bonne.");
                        Console.Clear();
                        CharacterChoice();
                        break;
                }
            }
            
            void Startfight(Ally ally , Ennemies ennemy)
            {
                Console.Clear();
                Console.WriteLine($"THE FIGHT START : {ally.Name} VS {ennemy.Name}");
                Console.ReadLine();
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
                    Console.WriteLine("GAME OVER !!!");
                                      
                    Environment.Exit(0);
                }
            }

            void Menu(Ally ally)
            {
                Console.Clear();
                Console.WriteLine("Bienvenue au centre d'entrainement du professeur Wing\n"+
                                  "ici vous allez pouvoir dépenser l'argent dans des entrainements pour améliorer vos " +
                                  "compétences.");
                Console.WriteLine($"Tapez le chiffre respectif aux choix que vous souhaitez.\n" +
                                  "\n" +
                                  "\n" +
                                  "    Nen : 1    |   Force : 2    |    Dodge : 3    |    Crit : 4\n" +
                                  "    25 000C    |    55 000C     |     22 000C     |    18 000C\n" +
                                  "               |                |                 |              \n" +
                                  "    PDV + 25   |    Force x2    |    Dodge +10    |    Crit +15\n" +
                                  "    Force +10  |                |                 |\n" +
                                  "    Dodge +3   |                |                 |\n" +
                                  "    Crit +5    |                |                 |\n" +
                                  "\n" +
                                 $"    Money : {ally.Money}                                             Sortie : 5");
                                  
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    if (ally.Money >= 25000)
                    {
                        Console.Clear();
                        Console.WriteLine("Vous avez choisi d'améliorer le Nen");
                        Console.WriteLine("es-tu vraiement sûr de ton choix");
                        Console.WriteLine("Y/N");

                        string validation = Console.ReadLine();

                    if(validation == "Y" || validation == "y")
                    {
                        ally.Health += 25;
                        ally.Powerfull += 10;
                        ally.Dodge += 3;
                        ally.Crit += 5;
                        ally.Nen += 1;
                        ally.Money -= 25000;
                        Console.WriteLine($"Il vous reste {ally.Money}");
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
                    else if (ally.Money < 25000)
                    {
                        Console.WriteLine("Vous n'avez pas assez d'argent");
                        Menu(ally);
                    }
                    
                }

                if (choice == "2")
                {
                    if (ally.Money >= 55000)
                    {
                        Console.WriteLine("Vous avez choisi d'améliorer votre force");
                        Console.WriteLine("es-tu vraiement sûr de ton choix");
                        Console.WriteLine("Y/N");

                    string validation = Console.ReadLine();

                    if(validation == "Y" || validation == "y")
                    {
                        ally.Powerfull *= 2;
                        ally.Money -= 55000;
                        Console.WriteLine($"Il vous reste {ally.Money}");
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
                    else if (ally.Money < 55000)
                    {
                        Console.WriteLine("Vous n'avez pas assez d'argent");
                        Menu(ally);
                    }
                    
                }

                    

                if (choice == "3")
                {
                    if (ally.Money >= 22000)
                    {
                        Console.WriteLine("Vous avez choisi d'améliorer votre esquive");
                        Console.WriteLine("es-tu vraiement sûr de ton choix");
                        Console.WriteLine("Y/N");

                    string validation = Console.ReadLine();

                    if(validation == "Y" || validation == "y")
                    { 
                        ally.Dodge += 10;
                        ally.Money -= 22000;
                        Console.WriteLine($"Il vous reste {ally.Money}");
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
                    else if (ally.Money < 22000)
                    {
                        Console.WriteLine("Vous n'avez pas assez d'argent");
                        Menu(ally);
                    }
                }

                if (choice == "4")
                {
                    if(ally.Money >= 18000)
                    {
                        Console.WriteLine("Vous avez choisi d'améliorer vos coups critique");
                        Console.WriteLine("es-tu vraiement sûr de ton choix");
                        Console.WriteLine("Y/N");

                    string validation = Console.ReadLine();
                    
                    if(validation == "Y" || validation == "y")
                    {
                        ally.Crit += 15;
                        ally.Money -= 18000;
                        Console.WriteLine($"Il vous reste {ally.Money}");
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
                    else if (ally.Money < 18000)
                    {
                        Console.WriteLine("Vous n'avez pas assez d'argent");
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


            }

            Console.Clear();

            Console.WriteLine("Bienvenue dans la tour Celeste, il y a un total de 50 etages ici, \n" +
                              "tout les 10 étages il vous rencontrerez un maitre d'etage qui vous \n" +
                              "permettra si vous le battez a acceder a la dizaine d'etages suivante.\n" +
                              "Vous avez le droit de combattre uniquement les maitres d'etages pour \n" +
                              "monter par dizaines mais les combats seront plus hardus.");
            Console.ReadLine();
            Console.Clear();


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
            
/////////////////////////////////////////////////////////////////// FIGHT 1 
            Guido guido = new Guido();  
            guido.Character();

            if (gon.Health > 1)
            {
                Startfight(gon , guido);
                gon.Heal(gon);
                gon.Money += 30000;
                Console.WriteLine("Vous recevez 30 000 crédit");
                Console.WriteLine($"Vous avez {gon.Money} crédit dans votre portfeuille");

            }
            if (kirua.Health > 1)
            {
                Startfight(kirua , guido);
                kirua.Heal(kirua);
                kirua.Money += 30000;
                Console.WriteLine("Vous recevez 30 000 crédit");
                Console.WriteLine($"Vous avez {kirua.Money} crédit dans votre portfeuille");

            }
            if (zushi.Health > 1)
            {
                Startfight(zushi , guido);
                zushi.Heal(zushi);
                zushi.Money += 30000;
                Console.WriteLine("Vous recevez 30 000 crédit");
                Console.WriteLine($"Vous avez {zushi.Money} crédit dans votre portfeuille");
            }
            
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

/////////////////////////////////////////////////////////////////// FIGHT 2

            Riehvelt riehvelt = new Riehvelt();
            riehvelt.Character();

            if (gon.Health > 1)
            {
                Startfight(gon , riehvelt);
                gon.Heal(gon);
                gon.Money += 30000;
                Console.WriteLine("Vous recevez 30 000 crédit");
                Console.WriteLine($"Vous avez {gon.Money} crédit dans votre portfeuille");

            }
            if (kirua.Health > 1)
            {
                Startfight(kirua , riehvelt);
                kirua.Heal(kirua);
                kirua.Money += 30000;
                Console.WriteLine("Vous recevez 30 000 crédit");
                Console.WriteLine($"Vous avez {kirua.Money} crédit dans votre portfeuille");

            }
            if (zushi.Health > 1)
            {
                Startfight(zushi , riehvelt);
                zushi.Heal(zushi);
                zushi.Money += 30000;
                Console.WriteLine("Vous recevez 30 000 crédit");
                Console.WriteLine($"Vous avez {zushi.Money} crédit dans votre portfeuille");
            }


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

/////////////////////////////////////////////////////////////////// FIGHT 3


            Kastrot kastrot = new Kastrot();
            kastrot.Character();

            if (gon.Health > 1)
            {
                Startfight(gon , kastrot);
                gon.Heal(gon);
                gon.Money += 30000;
                Console.WriteLine("Vous recevez 30 000 crédit");
                Console.WriteLine($"Vous avez {gon.Money} crédit dans votre portfeuille");

            }
            if (kirua.Health > 1)
            {
                Startfight(kirua , kastrot);
                kirua.Heal(kirua);
                kirua.Money += 30000;
                Console.WriteLine("Vous recevez 30 000 crédit");
                Console.WriteLine($"Vous avez {kirua.Money} crédit dans votre portfeuille");

            }
            if (zushi.Health > 1)
            {
                Startfight(zushi , kastrot);
                zushi.Heal(zushi);
                zushi.Money += 30000;
                Console.WriteLine("Vous recevez 30 000 crédit");
                Console.WriteLine($"Vous avez {zushi.Money} crédit dans votre portfeuille");
            }
            
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

/////////////////////////////////////////////////////////////////// FIGHT 4
            
            Kuroro kuroro = new Kuroro();
            kuroro.Character();

            if (gon.Health > 1)
            {
                Startfight(gon , kuroro);
                gon.Heal(gon);
                gon.Money += 30000;
                Console.WriteLine("Vous recevez 30 000 crédit");
                Console.WriteLine($"Vous avez {gon.Money} crédit dans votre portfeuille");
            }
            if (kirua.Health > 1)
            {
                Startfight(kirua , kuroro);
                kirua.Heal(kirua);
                kirua.Money += 30000;
                Console.WriteLine("Vous recevez 30 000 crédit");
                Console.WriteLine($"Vous avez {kirua.Money} crédit dans votre portfeuille");

            }
            if (zushi.Health > 1)
            {
                Startfight(zushi , kuroro);
                zushi.Heal(zushi);
                zushi.Money += 30000;
                Console.WriteLine("Vous recevez 30 000 crédit");
                Console.WriteLine($"Vous avez {zushi.Money} crédit dans votre portfeuille");
            }


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

/////////////////////////////////////////////////////////////////// FIGHT 5

            Hisoka hisoka = new Hisoka();
            hisoka.Character();

            if (gon.Health > 1)
            {
                Startfight(gon , hisoka);
                gon.Heal(gon);
                gon.Money += 30000;
                Console.WriteLine("Vous recevez 30 000 crédit");
                Console.WriteLine($"Vous avez {kirua.Money} crédit dans votre portfeuille");
        

            }
            if (kirua.Health > 1)
            {
                Startfight(kirua , hisoka);
                kirua.Heal(kirua);
                kirua.Money += 30000;
                Console.WriteLine("Vous recevez 30 000 crédit");
                Console.WriteLine($"Vous avez {kirua.Money} crédit dans votre portfeuille");

            }
            if (zushi.Health > 1)
            {
                Startfight(zushi , hisoka);
                zushi.Heal(zushi);
                zushi.Money += 30000;
                Console.WriteLine("Vous recevez 30 000 crédit");
                Console.WriteLine($"Vous avez {zushi.Money} crédit dans votre portfeuille");
            }

            
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Félicitations vous avez réussi à gravir la tour !!!");           
            
        }
    }
}
