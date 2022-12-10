// Programme exercice calcule

// Définir les variables
const int MIN_VALUE_FIRST_NUMBER = 1;
const int MIN_VALUE_SECOND_NUMBER = 1;

const int MAX_VALUE_FIRST_NUMBER = 10;
const int MAX_VALUE_SECOND_NUMBER = 10;


// Générer 2 nombres aléatoire

Random MonGenerateur = new Random();


int Score = 0;
int NumbeOfOperation = 0;

while (true)
{
    int NombreADeviner1 = MonGenerateur.Next(MIN_VALUE_FIRST_NUMBER, MAX_VALUE_FIRST_NUMBER + 1);
    int NombreADeviner2 = MonGenerateur.Next(MIN_VALUE_SECOND_NUMBER, MAX_VALUE_SECOND_NUMBER + 1);

    var GoodAnswer = NombreADeviner1 * NombreADeviner2;

    var Message = string.Format("Combien font {0} x {1} ?", NombreADeviner1, NombreADeviner2);
    Console.Write(Message);

    string EntreeUtilisateur = Console.ReadLine();

    int NombreEntreParUtilisateur = int.Parse(EntreeUtilisateur);
    if (NombreEntreParUtilisateur == GoodAnswer)
    {
        Score++;
        NumbeOfOperation++;
        Console.ForegroundColor=ConsoleColor.Green; 
        Console.WriteLine("Suuuperbe, score :" + (Score) + "/" + (NumbeOfOperation));
        Console.ForegroundColor=ConsoleColor.White; 
    }
    else
    {
        NumbeOfOperation++;
        Console.ForegroundColor=ConsoleColor.Red; 
        Console.WriteLine("Dommage essaie encore! La bonne réponse était" + GoodAnswer + "\nscore" + Score + "/" + NumbeOfOperation);
        Console.ForegroundColor=ConsoleColor.White; 
    }

}