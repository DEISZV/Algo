using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Program
    {
        static void Main(string[] args)

        {
            List<MenuItem> list = new List<MenuItem>();
            // Création liste Menu avec Item
           
            {
           
                new MenuItem { Numero = 1, Libelle = "Menu 1",  };
                new MenuItem { Numero = 3, Libelle = "Menu 3" };
                new MenuItem { Numero = 4, Libelle = "Menu 4" };



            };

            Menu menu = new Menu();
            menu.InsererLigne(new MenuItem { Numero = 1, Libelle = "menu 1" });
            menu.InsererLigne(new MenuItem { Numero = 3, Libelle = "menu 3" });
            menu.InsererLigne(new MenuItem { Numero = 3, Libelle = "menu 3BIS" });
            menu.InsererLigne(new MenuItem { Numero = 4, Libelle = "menu 4" });

            menu.Afficher();

            int resultat = menu.Choisir();      
            Console.WriteLine(resultat);
            Console.ReadLine();
        

        }
       
 
    /// <summary>
    /// Affiche un menu, test et récupère la saisie de l'utilisateur
    /// </summary>
    /// <param name="menu">La liste des choix possible</param>
    /// <returns>choix utilisateur</returns>
        private static int GererMenu(List<MenuItem> menu)

        {   
            foreach (MenuItem ligne in menu)
            {
                Console.WriteLine($"{ligne.Numero} et {ligne.Libelle}");
            }

            int choix;
            choix = int.Parse(Console.ReadLine());
           
            foreach (MenuItem item in menu)
            {
                if (choix == item.Numero)
                    return choix;
            }

            Console.WriteLine("erreur dans la saisie");
                return -1;
            
        }
        
    }
}
