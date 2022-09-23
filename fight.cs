using System;

namespace Project_CS
{
    public class Battle
    {
        public void CharacterChoice(string Choice)
        {
            if (Choice == "1")
            {
                Gon gon = new Gon();
                gon.Character();
                Console.WriteLine("Bienvenue Gon!");
            }
            if (Choice == "2")
            {
                Kirua kirua = new Kirua();
                kirua.Character();
                Console.WriteLine("Bienvenue Kirua!");

            }
            if (Choice == "3")
            {
                Zushi zushi = new Zushi();
                zushi.Character();
                Console.WriteLine("Bienvenue Zushi!");

            }
            Console.WriteLine("La selection n'est pas valide essayez a nouveau");
            CharacterChoice(Choice);
        }

        
        public void Fight()
        {
            Console.Clear();

            Console.WriteLine("Bienvenue dans la tour Celeste, il y a un total de 50 etages ici, tout les 10 étages il " +
                              "vous rencontrerez un maitre d'etage qui vous permettra si vous le battez a acceder a la " +
                              "dizaine d'etages suivante." +
                              "Vous avez le droit de combattre uniquement les maitres d'etages pour monter par dizaines " +
                              "mais les combats seront plus hardus");
            
            Console.Clear();

            Console.WriteLine("Je vais commencer par prendre votre identiée, qui etes vous?");
            Console.Clear();
            Console.WriteLine("Pour choisir votre personnage choisissez respectivement | 1 pour Gon | 2 pour Kirua | 3 pour Zishi | \n"+
                              "Gon : 1          Kirua               Zushi \n"+
                              "Vie : 100        Vie : 100           Vie : 100 \n"+
                              "Force : 12       Force : 9           Force : 9 \n"+
                              "Esquive : 15     Esquive : 20        Esquive : 15 \n"+
                              "Nen : 0          Nen : 0             Nen : 1 ");

            String Choice = Console.ReadLine();

            Console.WriteLine();

            
            



            
            
            
            
            
            
        }
      
    


    }
}


