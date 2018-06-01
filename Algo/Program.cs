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
                new MenuItem { Numero = 1, Libelle = "Menu 1" };
                new MenuItem { Numero = 3, Libelle = "Menu 3" };
                new MenuItem { Numero = 4, Libelle = "Menu 4" };
            };

            int resultat = GererMenu(list);
            Console.WriteLine(resultat);
            Console.ReadLine();
        }


        /// <summary>
        /// Affiche un menu, test et récupère la saisie de l'utilisateur
        /// </summary>
        /// <param name="menu">La liste des choix possible</param>
        /// <returns>choix utilisateur</returns>
        private static int GererMenu(List<MenuItem> menu)

        {   // Affiche les éléments du Menu
            foreach (MenuItem ligne in menu)
                
            {
                Console.WriteLine($"{ligne.Numero}-{ligne.Libelle}");

            }

            // Récup choix utilisateur 
            Console.WriteLine("Saisir un choix");
            int choix;
            choix = int.Parse(Console.ReadLine());

            // test du choix par rapport aux éléments du Menu
            while (true)
            
            {
                foreach (MenuItem item in menu)
                {
                    if (choix == item.Numero)
                    {
                        return choix;
                    }


                }

                Console.WriteLine("Erreur lors de la saisie");
                choix = int.Parse(Console.ReadLine());
               
            }

            // return -1;
        }

        /// <summary>
        /// Représente une ligne du menu
        /// </summary>
        class MenuItem

        {
            public int Numero { get; set; }
            public string Libelle { get; set; }

        }

    }
}
