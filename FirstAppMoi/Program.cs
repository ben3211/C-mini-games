// Programme de jeu deviner un nombre

// Constantes = Valeurs utilisées 
const int MIN_VALUE = 1;
const int MAX_VALUE = 100;
const int MAX_ESSAIS = 6;

static int GetIntFromUser()

// Créer un générateur de nb aléatoires
Random MonGenerateur = new Random();

// Choisir un nombre au hazard
int NombreADeviner = MonGenerateur.Next(MIN_VALUE, MAX_VALUE + 1);

int NombreEssaisRealises = 0;

bool? PartieGagner = null;

while (PartieGagner == null)
{
    #region Demander à l'utilisateur d'entrer un entier 
    // Afficher le message d'entrée 
    Console.Write("Entrez votre proposition : (" + (NombreEssaisRealises + 1) + "/" + MAX_ESSAIS + "): ");

    // Récupération du text
    string EntreeUtilisateur = Console.ReadLine();

    // Transformation du text en nombre
    int NombreEntreParUtilisateur = int.Parse(EntreeUtilisateur);
    #endregion

    if (NombreEntreParUtilisateur == NombreADeviner)
    {
        Console.WriteLine("Vous avez gagné");
        PartieGagner = true;
    }
    else
    {
        if (NombreEntreParUtilisateur > NombreADeviner)
        {
            Console.WriteLine("Trop grand");
        }
        else
        {
            Console.WriteLine("Trop petit");
        }
    }

    NombreEssaisRealises++;
    if (NombreEssaisRealises >= MAX_ESSAIS && PartieGagner! == true)
    {
        PartieGagner = false;
        Console.WriteLine("Looser");
    }
}
