using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{   /// <summary>
   /// Pour faire un menu
    /// </summary>
    class Menu : MenuItem

    {
        private List<MenuItem> menuItems;
        private int i;

        public Menu()

        {
            menuItems = new List<MenuItem>();
        }

        /// <summary>
        /// Insère un MenuItems dans le menu
        /// </summary>
        /// <param name="item"></param>
        /// <exception cref="ArgumentException">Si le numéro de l'item est déjà présent</exception>
 
        public void InsererLigne(MenuItem item)

        {
            /*foreach (var ligne in menuItems)
             {
                 if (ligne.Numero == item.Numero)
                    throw new ArgumentException ($"Le numéro {item.Numero} existe déjà dans le menu");

             }
             }*/

            if (menuItems.Exists(x=>x.Numero == item.Numero))
            { throw new ArgumentException($"Le numéro {item.Numero}existe déjà"); }

            menuItems.Add(item);
        }

        /// <summary>
        /// Affiche les éléments du Menu
        /// </summary>
        public void Afficher()

        {
           
            foreach (MenuItem ligne in menuItems)

            {
                Console.WriteLine($"{ligne.Numero}-{ligne.Libelle}");

            }

        }

        public int Choisir()

        {
            // Récup choix utilisateur 
            Console.WriteLine("Saisir un choix");
            int choix;
            choix = int.Parse(Console.ReadLine());

            // test du choix par rapport aux éléments du Menu

            while (true)

            {
                foreach (MenuItem item in menuItems)
                {
                    if (choix == item.Numero)
                    {
                        return choix;
                    }


                }

                Console.WriteLine("Erreur lors de la saisie");
                choix = int.Parse(Console.ReadLine());

            }
        }

    }
}
