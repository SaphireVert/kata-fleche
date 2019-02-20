using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flèche
{
    public class Classefleche
    {
        public int Taillefleche = 19;



        public void fonctionfleche()
        {


            int i;
            for (i = 0; i < Taillefleche - 1; i++)
            {

                Console.Write(StringRepetition(Taillefleche - i - 1, " "));
                Console.Write("*");

                Console.Write(StringRepetition(i * 2 - 1, " "));

                if (i != 0)
                {
                    Console.Write("*");

                }
                Console.WriteLine();

            }
            Console.WriteLine(StringRepetition(Taillefleche * 2 - 1, "*"));

            for(i = 0; i < Taillefleche; i++)
            {
                Console.WriteLine(StringRepetition(Taillefleche - 1, " ") + "*");
            }

        }

        public string StringRepetition(int No, string caractere)
        {
            string s = string.Empty;

            int i;
            for(i = 0; i < No; i++)
            {
                s = s + caractere;

            }
            return s;
        }






    }
}
