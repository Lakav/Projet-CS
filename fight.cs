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
            }
            if (Choice == "2")
            {
                Kirua kirua = new Kirua();
                kirua.Character();
            }
            if (Choice == "3")
            {
                Zushi zushi = new Zushi();
                zushi.Character();
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
            Console.ReadLine();
            
            Console.Clear();

            Console.WriteLine("Je vais commencer par prendre votre identiée, qui etes vous?");

            Console.WriteLine("");
            String Choice = Console.ReadLine();
            



            
            
            
            
            
            
        }
      
    


    }
}


