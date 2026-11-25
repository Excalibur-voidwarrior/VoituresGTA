namespace VoituresGTA;
/*
    CONSIGNES
    1. Déclarer un tableau contenant cinq véhicules :
        - Banshee
        - Zentorno
        - Sultan
        - Sanchez
        - Buzzard
    2. Afficher tous les véhicules du garage avec une boucle for.
    3. Demander au joueur de saisir le numéro du véhicule qu'il souhaite remplacer (de 1 à 5).
    4. Demander le nom du nouveau véhicule.
    5. Remplacer l'ancien véhicule par le nouveau dans le tableau.
    6. Afficher le contenu actualisé du garage.
*/
class Program
{
    static void Main(string[] args)
    {
        string[] Voitures = { "Banshee", "Zentorno", "Sultan", "Sanchez", "Buzzard" };

        Console.WriteLine("garage automobile :");

        for (int i = 0 ; i < Voitures.Length ; i++)
        {
            Console.WriteLine((i + 1) + ". " + Voitures[i]);
        }

        Console.WriteLine(" ");

        Console.WriteLine("Quel véhicule souhaitez-vous remplacer ?");

       int Carnew = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" ");

        Console.WriteLine("Quel est le nom du nouveau véhicule ?");

        Voitures[Carnew - 1] = Console.ReadLine();

        Console.WriteLine(" ");

        Console.WriteLine("garage automobile :");

        for (int i = 0; i < Voitures.Length; i++)
        {
            Console.WriteLine((i + 1) + ". " + Voitures[i]);
        }


    }
    
}