class Partie
{
    // Constructeur avec paramètre nom
    public Partie(string nom){
        // Je stocke le nom passé en paramètre dans la case (champ = field)
        this.NomDuJoueur = nom;
    }
    public string NomDuJoueur=null;
    public int NombreMin = 0;
    public int NombreMax = 100;
    public int NombreEssaisMax=6;
    private int? NombreAleatoire = null; //0 le ? permet de donner comme valeur 0 à un int
    public EtatPartie Etat=EtatPartie.NonCommencee;
    public List<Essai> Essais = new List<Essai>();
}