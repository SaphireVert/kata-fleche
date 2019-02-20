using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flèche
{
    class Program
    {

        
        //cki
        static void Main(string[] args)
        {
            while (true == true)
            {
                Console.Clear();
            Console.WriteLine("Bienvenue dans \"Flèches\", saisissez un nombre entre 2 et 20 et appuyez sur Entrée");
            string touchetemp = Console.ReadLine();
            //int nbtouche = int.Parse(touchetemp);
            if(touchetemp.Length > 0)
                {
                    if (int.Parse(touchetemp) > 2 && int.Parse(touchetemp) < 20 && touchetemp.Length > 0)
                    {
                        Classefleche classefleche = new Classefleche();
                        classefleche.Taillefleche = int.Parse(touchetemp);
                        classefleche.fonctionfleche();
                        Console.WriteLine("Appuyez sur une touche pour continuer...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Erreur... Le nombre " + int.Parse(touchetemp) + " ne se situe pas entre 2 et 20");
                        Console.WriteLine("Appuyez sur une touche pour continuer...");
                        Console.ReadKey();

                    }
                }




            }


        }
    }
}
