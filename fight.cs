using System;

namespace Project_CS
{
    public class Battle
    {
        public void CharacterChoice(string choice)
        {
            if (choice == "1")
            {
                Console.Clear();
                
                Gon gon = new Gon();
                gon.Character();
                gon.printStats();
            }
            if (choice == "2")
            {
                Console.Clear();

                Kirua kirua = new Kirua();
                kirua.Character();
                kirua.printStats();

            }
            if (choice == "3")
            {
                Console.Clear();

                Zushi zushi = new Zushi();
                zushi.Character();
                zushi.printStats();

            }
            else
            {
                Console.WriteLine("La selection n'est pas bonne.");
                choice = Console.ReadLine();
                CharacterChoice(choice);
            }
        }

        
        public void Fight()
        {
            Console.Clear();

            Console.WriteLine("Bienvenue dans la tour Celeste, il y a un total de 50 etages ici, tout les 10 étages il " +
                              "vous rencontrerez un maitre d'etage qui vous permettra si vous le battez a acceder a la " +
                              "dizaine d'etages suivante." +
                              "Vous avez le droit de combattre uniquement les maitres d'etages pour monter par dizaines " +
                              "mais les combats seront plus hardus");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Je vais commencer par prendre votre identiée, qui etes vous?");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Pour choisir votre personnage choisissez respectivement : 1 pour Gon | 2 pour Kirua | 3 pour Zishi | \n"+
                              "Gon : 1          Kirua               Zushi \n"+
                              "Vie : 100        Vie : 100           Vie : 125 \n"+
                              "Force : 12       Force : 9           Force : 9 \n"+
                              "Esquive : 15     Esquive : 20        Esquive : 15 \n"+
                              "Nen : 0          Nen : 0             Nen : 1 ");

            String choice = Console.ReadLine();

            CharacterChoice(choice);

            Console.ReadLine();

            
            



            
            
            
            
            
            
        }
      
    


    }
}


