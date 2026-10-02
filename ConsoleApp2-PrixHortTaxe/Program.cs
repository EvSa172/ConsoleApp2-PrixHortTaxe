// Programme qui calcule la tva apres le prix hors taxe (HT) et affiche le prix TTC

using System;

class Program
{
    static void Main()
    {
        decimal prixHT = 1;
        const decimal tauxTVA = 0.20m; 

        Console.WriteLine("Calculateur de TVA ");

        
        while (prixHT != 0)
        {
            Console.Write("Saisissez le prix hors-taxes (HT) : ");
           
             prixHT = Convert.ToDecimal(Console.ReadLine());

            if (prixHT > 0)
            {
                decimal montantTVA = prixHT * tauxTVA;
                decimal prixTTC = prixHT + montantTVA;

                Console.WriteLine($"Montant de la TVA : {montantTVA} €");
                Console.WriteLine($" Prix TTC : {prixTTC} €");
            }
            else
            {
                Console.WriteLine("Erreur : Veuillez entrer un nombre valide.");
            }
               
        }

       
    }
}