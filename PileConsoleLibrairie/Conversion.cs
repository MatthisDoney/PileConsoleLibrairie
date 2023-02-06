using MesOutils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PileConsoleLibrairie
{
    class Conversion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisissez le nombre maximal d'éléments dans la liste.");
            int pNbElements = Utilitaires.SaisirNb();
            Console.WriteLine("Saisissez le nombre à convertir.");
            int pNbAConvertir = Utilitaires.SaisirNb();
            Console.WriteLine("Saissez la nouvelle base.");
            int pNewBase = Utilitaires.SaisirNb();


            Pile<int> unePile = new Pile<int>();
            string retour = "";

            while (pNbAConvertir != 0)
            {
                unePile.Empiler(pNbAConvertir % pNewBase);
                pNbAConvertir /= pNewBase;
            }

            while (!unePile.PileVide())
            {
                int nbDepile = unePile.Depiler();
                if (nbDepile >= 10)
                {
                    retour += nbDepile.ToString("X");
                }
                else
                {
                    retour += nbDepile.ToString();
                }
            }
            Console.WriteLine(retour);
        }
    }
}
