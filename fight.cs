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
                Console.WriteLine("I will start by taking your identity, who are you ?");
                Console.WriteLine("To choose your character choose respectively : | 1 for Gon | 2 for Kirua | 3 for Zushi | \n"+
                                  "\n"+
                                  "     Gon             |    Kirua          |     Zushi \n"+
                                  "     Life : 100      |    Life : 100     |     Life : 125 \n"+
                                  "     Damage : 12     |    Damage : 10    |     Damage : 9 \n"+
                                  "     Dodge  : 15     |    Dodge  : 20    |     Dodge  : 15 \n"+
                                  "     Crit : 5        |    Crit : 8       |     Crit : 5 \n"+
                                  "     Nen : 0         |    Nen : 0        |     Nen : 1 \n"+
                                  "");


                string choice = Console.ReadLine();
                switch (choice)
                
                {
                    case ("1") :
                        
                    Console.WriteLine("You have chosen Gon");
                    Console.WriteLine("Are you really sure of your choice ?");
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
                        Console.WriteLine("Choice cancelled");
                        CharacterChoice();
                    }
                    else if(validation != "Y" && validation != "y" && validation != "N" && validation != "n") 
                    {
                        Console.WriteLine("Misunderstood Choice");
                        CharacterChoice();
                    }
                    break;
                        
                    
                    case ("2") : 
                        
                    Console.WriteLine("You have chosen Kirua");
                    Console.WriteLine("Are you really sure of your choice ?");
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
                        Console.WriteLine("Choice cancelled");
                        CharacterChoice();
                    }
                    else if(validation2 != "Y" && validation2 != "y" && validation2 != "N" && validation2 != "n") 
                    {
                        Console.WriteLine("Misunderstood Choice");
                        CharacterChoice();
                    }
                    break;
                    
                    case ("3"):
                        
                    Console.WriteLine("You have chosen Zushi");
                    Console.WriteLine("Are you really sure of your choice ?");
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
                        Console.WriteLine("Choice cancelled");
                        CharacterChoice();
                    }
                    else if(validation3 != "Y" && validation3 != "y" && validation3 != "N" && validation3 != "n") 
                    {
                        Console.WriteLine("Misunderstood Choice");
                        CharacterChoice();
                    }
                    break;
                
                    default:
                        
                        Console.WriteLine("The selection is not good");
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
                Console.WriteLine("Welcome to Professor Wing's training centre\n"+
                                  "here you will be able to spend the money on training to improve your " +
                                  "Skills.");
                Console.WriteLine($"Type in the respective number for the choices you want.\n");
                ally.printStats();
                Console.WriteLine("\n" +
                                  "    Nen : 1    |   D : 2    |    Dodge : 3    |    Crit : 4\n" +
                                  "    25 000C    |    55 000C     |     22 000C     |    18 000C\n" +
                                  "               |                |                 |              \n" +
                                  "    HP + 25    |    Damage x2   |    Dodge +10    |    Crit +15\n" +
                                  "    Damage +10 |                |                 |\n" +
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
                        Console.WriteLine("You have chosen to improve the Nen");
                        Console.WriteLine("Are you really sure of your choice ?");
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
                        Console.WriteLine($"You ave {ally.Money} left");
                        ally.printStats();
                        Menu(ally); 
                    }

                    if(validation == "N" || validation == "n")
                    {
                        Console.WriteLine("Choice cancelled");
                        Menu(ally);
                    }
                    else if(validation != "Y" && validation != "y" && validation != "N" && validation != "n") 
                    {
                        Console.WriteLine("Misunderstood Choice");
                        Menu(ally);
                    }  
                    }
                    else if (ally.Money < 25000)
                    {
                        Console.WriteLine("You don't have enough money");
                        Menu(ally);
                    }
                    
                }

                if (choice == "2")
                {
                    if (ally.Money >= 55000)
                    {
                        Console.WriteLine("You have chosen to improve your damage");
                        Console.WriteLine("are you really sure of your choice ?");
                        Console.WriteLine("Y/N");

                    string validation = Console.ReadLine();

                    if(validation == "Y" || validation == "y")
                    {
                        ally.Powerfull *= 2;
                        ally.Money -= 55000;
                        Console.WriteLine($"You ave {ally.Money} left");
                        ally.printStats();
                        Menu(ally);
                    }

                    if(validation == "N" || validation == "n")
                    {
                        Console.WriteLine("Choice cancelled");
                        Menu(ally);
                    }
                    else if(validation != "Y" && validation != "y" && validation != "N" && validation != "n") 
                    {
                        Console.WriteLine("Misunderstood Choice");
                        Menu(ally);
                    }
                    }
                    else if (ally.Money < 55000)
                    {
                        Console.WriteLine("You don't have enough money");
                        Menu(ally);
                    }
                    
                }

                    

                if (choice == "3")
                {
                    if (ally.Money >= 22000)
                    {
                        Console.WriteLine("You have chosen to improve your dodge");
                        Console.WriteLine("are you really sure of your choice ?");
                        Console.WriteLine("Y/N");

                    string validation = Console.ReadLine();

                    if(validation == "Y" || validation == "y")
                    { 
                        ally.Dodge += 10;
                        ally.Money -= 22000;
                        Console.WriteLine($"You ave {ally.Money} left");
                        Menu(ally);
                    }

                    if(validation == "N" || validation == "n")
                    {
                        Console.WriteLine("Choice cancelled");
                        Menu(ally);
                    }
                    else if(validation != "Y" && validation != "y" && validation != "N" && validation != "n") 
                    {
                        Console.WriteLine("Misunderstood Choice");
                        Menu(ally);
                    }
                    }
                    else if (ally.Money < 22000)
                    {
                        Console.WriteLine("You don't have enough money");
                        Menu(ally);
                    }
                }

                if (choice == "4")
                {
                    if(ally.Money >= 18000)
                    {
                        Console.WriteLine("You have chosen to improve your critical hits");
                        Console.WriteLine("Are you really sure of your choice ?");
                        Console.WriteLine("Y/N");

                    string validation = Console.ReadLine();
                    
                    if(validation == "Y" || validation == "y")
                    {
                        ally.Crit += 15;
                        ally.Money -= 18000;
                        Console.WriteLine($"You ave {ally.Money} left");
                        Menu(ally);
                    }

                    if(validation == "N" || validation == "n")
                    {
                        Console.WriteLine("Choice cancelled");
                        Menu(ally);
                    }
                    else if(validation != "Y" && validation != "y" && validation != "N" && validation != "n")
                    {
                        Console.WriteLine("Misunderstood Choice");
                        Menu(ally);
                    }
                    }
                    else if (ally.Money < 18000)
                    {
                        Console.WriteLine("You don't have enough money");
                        Menu(ally);
                    }
                    
                }

                if (choice == "5")
                {
                    Console.WriteLine("You have chosen to leave the Menu");
                    Console.WriteLine("Are you really sure of your choice ?");
                    Console.WriteLine("Y/N");

                    string validation = Console.ReadLine();

                    if(validation == "Y" || validation == "y")
                    {
                        Console.WriteLine("Good game !!");
                    }
                    if(validation == "N" || validation == "n")
                    {
                        Console.WriteLine("Choice cancelled");
                        Menu(ally);
                    }
                    else if(validation != "Y" && validation != "y" && validation != "N" && validation != "n")
                    {
                        Console.WriteLine("Misunderstood Choice");
                        Menu(ally);
                    }
                }
                else if(choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5")
                {
                    Console.WriteLine("Misunderstood Choice");
                    Menu(ally); 
                }


            }

            Console.Clear();

            Console.WriteLine("Welcome to the Celestial Tower, there are a total of 50 floors here,\n" +
                              "every 10 floors you will meet a floor master who will allow you if you beat him to access the next ten floors.\n" +
                              "You are allowed to fight only the floor masters to get up to the next ten floors but the fights will be more difficult.");
                              
            Console.ReadLine();
            Console.Clear();


            CharacterChoice();

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("First of all let me introduce you to Master Wing, his role will be to accompany you \n"+
                              "throughout your ascent in the celestial tower, allowing you at the end of each \n"+
                              "fight to improve different skills in exchange for credits that you will get after each victory.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Let's start the first fight without waiting !");
            
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
                Console.WriteLine("You receive 30 000 credits");
                Console.WriteLine($"You have {gon.Money} credits in your portfolio");

            }
            if (kirua.Health > 1)
            {
                Startfight(kirua , guido);
                kirua.Heal(kirua);
                kirua.Money += 30000;
                Console.WriteLine("You receive 30 000 credits");
                Console.WriteLine($"You have {kirua.Money} credits in your portfolio");

            }
            if (zushi.Health > 1)
            {
                Startfight(zushi , guido);
                zushi.Heal(zushi);
                zushi.Money += 30000;
                Console.WriteLine("You receive 30 000 credits");
                Console.WriteLine($"You have {zushi.Money} credits in your portfolio");
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
                Console.WriteLine("You receive 30 000 credits");
                Console.WriteLine($"You have {gon.Money} credits in your portfolio");

            }
            if (kirua.Health > 1)
            {
                Startfight(kirua , riehvelt);
                kirua.Heal(kirua);
                kirua.Money += 30000;
                Console.WriteLine("You receive 30 000 credits");
                Console.WriteLine($"You have {kirua.Money} credits in your portfolio");

            }
            if (zushi.Health > 1)
            {
                Startfight(zushi , riehvelt);
                zushi.Heal(zushi);
                zushi.Money += 30000;
                Console.WriteLine("You receive 30 000 credits");
                Console.WriteLine($"You have {zushi.Money} credits in your portfolio");
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
                Console.WriteLine("You receive 30 000 credits");
                Console.WriteLine($"You have {gon.Money} credits in your portfolio");

            }
            if (kirua.Health > 1)
            {
                Startfight(kirua , kastrot);
                kirua.Heal(kirua);
                kirua.Money += 30000;
                Console.WriteLine("You receive 30 000 credits");
                Console.WriteLine($"You have {kirua.Money} credits in your portfolio");

            }
            if (zushi.Health > 1)
            {
                Startfight(zushi , kastrot);
                zushi.Heal(zushi);
                zushi.Money += 30000;
                Console.WriteLine("You receive 30 000 credits");
                Console.WriteLine($"You have {zushi.Money} credits in your portfolio");
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
                Console.WriteLine("You receive 30 000 credits");
                Console.WriteLine($"You have {gon.Money} credits in your portfolio");
            }
            if (kirua.Health > 1)
            {
                Startfight(kirua , kuroro);
                kirua.Heal(kirua);
                kirua.Money += 30000;
                Console.WriteLine("You receive 30 000 credits");
                Console.WriteLine($"You have {kirua.Money} credits in your portfolio");

            }
            if (zushi.Health > 1)
            {
                Startfight(zushi , kuroro);
                zushi.Heal(zushi);
                zushi.Money += 30000;
                Console.WriteLine("You receive 30 000 credits");
                Console.WriteLine($"You have {zushi.Money} credits in your portfolio");
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
                Console.WriteLine("You receive 30 000 credits");
                Console.WriteLine($"You have {gon.Money} credits in your portfolio");
        

            }
            if (kirua.Health > 1)
            {
                Startfight(kirua , hisoka);
                kirua.Heal(kirua);
                kirua.Money += 30000;
                Console.WriteLine("You receive 30 000 credits");
                Console.WriteLine($"You have {kirua.Money} credits in your portfolio");

            }
            if (zushi.Health > 1)
            {
                Startfight(zushi , hisoka);
                zushi.Heal(zushi);
                zushi.Money += 30000;
                Console.WriteLine("You receive 30 000 credits");
                Console.WriteLine($"You have {zushi.Money} credits in your portfolio");
            }

            
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Congratulations you have successfully climbed the tower!!!");           
            
        }
    }
}
