using System;

namespace Project_CS
{
    public class 
        Battle
    {
        public void CharacterChoice()
        {
            string choice = Console.ReadLine();
            switch (choice)
            {
                case ("1") :
                    Console.Clear();
                
                    Gon gon = new Gon();
                    gon.Character();
                    gon.printStats();
                    break;
                    
                case ("2") : 
                    Console.Clear();

                    Kirua kirua = new Kirua();
                    kirua.Character();
                    kirua.printStats();
                    break;
                    
                case ("3"):
                    Console.Clear();

                    Zushi zushi = new Zushi();
                    zushi.Character();
                    zushi.printStats();
                    break;
                
                default:
                    Console.WriteLine("La selecn n'est pas bonne.");
                    CharacterChoice();
                    break;
            }
        }
        
        
        public void Fight()
        {
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

            Console.WriteLine("bienvenu de la part de wing");
            
            
            
            
            



            
            
            
            
            
            
        }
      
    


    }
}


