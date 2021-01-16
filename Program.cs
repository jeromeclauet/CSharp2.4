using System;

namespace Exercice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choississez un mois de l'année");
            string month = Console.ReadLine();
            if ((month == "Mars") || (month == "Avril") || (month == "Mai"))
            {
                Console.WriteLine("La saison du mois saisi est le PRINTEMPS");
            }
            else if ((month == "Juin") || (month == "Juillet") || (month == "Août"))
            {
                Console.WriteLine("La saison du mois saisi est l'ETE");
            }
            else if ((month == "Septembre") || (month == "Octobre") || (month == "Novembre")) 
            {
                Console.WriteLine("La saison du mois saisi est l'AUTOMNE");
            }
            else if ((month == "Décembre") || (month == "Janvier") || (month == "Février"))
            {
                Console.WriteLine("La saison du mois saisi est l'HIVER");
            }
            else 
            {
                Console.WriteLine("Le mois est mal saisi ou mal orthographié");
            }
        }
    }
}
