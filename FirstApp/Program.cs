// Programme de jeu deviner un nombre

// Les constantes = Les valeurs qui seront utilisées dans le code
// Et qui permettent de modifier le jeu sans revenir dans les lignes de code

static int GetIntFromUser(string message, int minimum=int.MinValue, int maximum=int.MaxValue)
{
    while (true)
    {
        Console.Write(message);
        string EntreeUtilisateur = Console.ReadLine();

        try
        {
            int NombreEntre; 
            try
            {      
                
                   NombreEntre = int.Parse(EntreeUtilisateur);
            }
            catch (System.Exception)
            {
                
                throw new Exception("Entrez un entier");
            }
          
            if(NombreEntre<minimum || NombreEntre>maximum ){
                // Constitution du message erreur
                var MessageErreur=string.Format("Votre entier doit être entre {0} et {1}", minimum, maximum);
                throw new Exception(MessageErreur);
                
            }
            return NombreEntre;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(ex.Message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

}

int ValeurMinimale=GetIntFromUser("Entrez la valeur minimale à deviner : ",1,10000);
int ValeurMaximale=GetIntFromUser("Entrez la valeur maximale",ValeurMinimale,10000);
int NombreEssaisMax=GetIntFromUser("Combien d'essais",1, 100);

// Créer un générateur de nombres aléatoires
var MonGenerateur = new Random();

// Choisir un nombre au hasard
int NombreADeviner = MonGenerateur.Next(ValeurMinimale, ValeurMaximale + 1);

int NombreEssaisRealises = 0;

bool? PartieGagnee = null;


while (PartieGagnee == null)
{
    // Afficher le message d'entrée


    int NombreEntreParUtilisateur = GetIntFromUser("Entrez votre proposition : ",ValeurMinimale,ValeurMaximale);


    

    if (NombreEntreParUtilisateur == NombreADeviner)
    {
        Console.WriteLine("Vous avez gagné");
        PartieGagnee = true;
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
    // Le joueur a perdu si
    // 1) Il a fait le nombre d'essais maximum
    // ET
    // Il n'a pas encore gagné
    if (NombreEssaisRealises >= NombreEssaisMax && PartieGagnee != true)
    {
        PartieGagnee = false;
        Console.WriteLine("Vous avez perdu");
    }
}

var faux= 1!=1;
var vrai = 1==1;
faux =!(1!=1 && 2==2+2 || 2==2);