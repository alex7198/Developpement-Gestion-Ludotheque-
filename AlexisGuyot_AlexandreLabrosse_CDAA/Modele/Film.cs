using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexisGuyot_AlexandreLabrosse_CDAA.Modele
{
    /// <summary>
    /// Un film est un type de média stocké dans la médiathèque
    /// </summary>
    public class Film : Media
    {
        #region Attributs

        private int durée;              //En minutes
        private string realisateur;     //Part du principe que le film a été réalisé par une seule personne
        private string scenariste;      //Et qu'il a été écrit par une seule personne aussi
        private string studio;
        private List<String> acteurs;   //Liste des acteurs principaux

        #endregion

        #region Propriétés

        public int Durée { get { return durée; } set { durée = value; } }
        /// <summary>
        /// Permet de récupérer la durée du film sous le format HHhMM
        /// </summary>
        public string DuréeH
        {
            get { return this.Durée / 60 + "h" + this.Durée % 60; }
        }
        public string Realisateur { get { return realisateur; } set { realisateur = value; } }
        public string Scenariste { get { return scenariste; } set { scenariste = value; } }
        public string Studio { get { return studio; } set { studio = value; } }
        public List<string> Acteurs { get { return acteurs; } set { acteurs = value; } }
        public string ActeursS {
            //Format d'affichage de la liste en tant que string
            get { return String.Join(", ", this.Acteurs); }
            /*On peut remplir la liste en passant une chaîne de caractères contenant les noms
             des acteurs séparés d'une virgule*/
            set { this.Acteurs = value.Split(',').ToList(); }
        }

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur utilisant directement une liste d'acteurs
        /// </summary>
        /// <param name="r">Référence du média</param>
        /// <param name="t">Titre du média</param>
        /// <param name="d">Description/Résumé du média</param>
        /// <param name="g">Genre du média</param>
        /// <param name="a">Année de parution du média</param>
        /// <param name="_durée">Durée du film</param>
        /// <param name="_realisateur">Réalisateur du film</param>
        /// <param name="_scenariste">Scénariste du film</param>
        /// <param name="_studio">Studio qui a produit le film</param>
        /// <param name="_acteurs">Liste des acteurs principaux</param>
        public Film(string r, string t, string d, Genres g, DateTime a,
            int _durée, string _realisateur, string _scenariste, string _studio, List<string> _acteurs)
            : base(r, t, d, g, a)
        {
            this.Durée = _durée;
            this.Realisateur = _realisateur;
            this.Scenariste = _scenariste;
            this.Studio = _studio;
            this.Acteurs = _acteurs;
        }

        /// <summary>
        /// Constructeur utilisant une liste d'acteurs sous forme de chaîne à parser
        /// </summary>
        /// <param name="r">Référence du média</param>
        /// <param name="t">Titre du média</param>
        /// <param name="d">Description/Résumé du média</param>
        /// <param name="g">Genre du média</param>
        /// <param name="a">Année de parution du média</param>
        /// <param name="_durée">Durée du film</param>
        /// <param name="_realisateur">Réalisateur du film</param>
        /// <param name="_scenariste">Scénariste du film</param>
        /// <param name="_studio">Studio qui a produit le film</param>
        /// <param name="_acteurs">Liste des acteurs principaux</param>
        public Film(string r, string t, string d, Genres g, DateTime a,
            int _durée, string _realisateur, string _scenariste, string _studio, string _acteurs)
            : base(r, t, d, g, a)
        {
            this.Durée = _durée;
            this.Realisateur = _realisateur;
            this.Scenariste = _scenariste;
            this.Studio = _studio;
            this.ActeursS = _acteurs;
        }

        /// <summary>
        /// Constructeur utilisant une liste d'acteurs sous forme de chaîne à parser
        /// </summary>
        /// <param name="r">Référence du média</param>
        /// <param name="t">Titre du média</param>
        /// <param name="d">Description/Résumé du média</param>
        /// <param name="g">Genre du média</param>
        /// <param name="a">Année de parution du média</param>
        /// <param name="_durée">Durée du film</param>
        /// <param name="_realisateur">Réalisateur du film</param>
        /// <param name="_scenariste">Scénariste du film</param>
        /// <param name="_studio">Studio qui a produit le film</param>
        /// <param name="_acteurs">Liste des acteurs principaux</param>
        public Film(string r, string t, string d, string g, DateTime a,
            int _durée, string _realisateur, string _scenariste, string _studio, string _acteurs)
            : base(r, t, d, g, a)
        {
            this.Durée = _durée;
            this.Realisateur = _realisateur;
            this.Scenariste = _scenariste;
            this.Studio = _studio;
            this.ActeursS = _acteurs;
        }

        /// <summary>
        /// Constructeur par défaut d'un film
        /// </summary>
        public Film(Film modele) : base(modele)
        {
            this.Durée = modele.Durée;
            this.Realisateur = modele.Realisateur;
            this.Scenariste = modele.Scenariste;
            this.Studio = modele.Studio;
            this.Acteurs = modele.Acteurs;
        }

        /// <summary>
        /// Constructeur par défaut d'un film
        /// </summary>
        public Film() : base()
        {
            this.Durée = 0;
            this.Realisateur = "";
            this.Scenariste = "";
            this.Studio = "";
            this.Acteurs = new List<string>();
        }

        #endregion

        /// <summary>
        /// Idem que pour la classe Media mais rajoute ses attributs propres
        /// </summary>
        /// <returns>Représentation de l'instance sous forme de chaine</returns>
        public override string ToString()
        {
            return base.ToString()
                + "\nRealisateur : " + this.Realisateur
                + "\nScenariste : " + this.Scenariste
                + "\nStudio : " + this.Studio
                + "\nActeurs Principaux : " + this.ActeursS
                + "\nDurée : " + this.DuréeH;
        }

        /// <summary>
        /// Version minimaliste du ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToStringMin()
        {
            string s = base.ToStringMin() + " - " + this.Realisateur + " - " + this.DuréeH;

            return s;
        }

        /// <summary>
        /// Idem que la classe média mais demande en plus la saisie de ses attributs propres
        /// </summary>
        public override void Saisie()
        {
            base.Saisie();
            this.SaisieRealisateur();
            this.SaisieScenariste();
            this.SaisieStudio();
            this.SaisieDurée();
            this.SaisieActeurs();
        }

        /// <summary>
        /// Agrémente la fonction saisiePartielle de la classe mère avec les attributs propres aux films
        /// </summary>
        /// <returns>Les nouveaux choix propres au film</returns>
        protected override string ChoixEnfant()
        {
            return "   6. Réalisateur (" + this.Realisateur + ") \n" +
                "   7. Scénariste (" + this.Scenariste + ") \n" +
                "   8. Studio de production (" + this.Studio + ") \n" +
                "   9. Durée (" + this.Durée + ") \n" +
                "   10. Acteurs (" + this.ActeursS + ") \n";
        }

        /// <summary>
        /// Suite de la fonction SaisiePartielle qui gère les choix ajoutés par le film
        /// </summary>
        /// <param name="choix">Choix saisi précédemment par l'utilisateur</param>
        protected override void SaisiePartielleEnfant(string choix)
        {
            if (choix.ToLower().Contains("realisateur") || choix == "6")
            {
                this.SaisieRealisateur();
            }
            if (choix.ToLower().Contains("scenariste") || choix == "7")
            {
                this.SaisieScenariste();
            }
            if (choix.ToLower().Contains("studio") || choix == "8")
            {
                this.SaisieStudio();
            }
            if (choix.ToLower().Contains("durée") || choix == "9")
            {
                this.SaisieDurée();
            }
            if (choix.ToLower().Contains("acteurs") || choix == "10")
            {
                this.SaisieActeurs();
            }
        }

        #region Fonctions privées utiles pour Saisie et SaisiePartielle

        /*Même explication que pour la classe Media*/

        /// <summary>
        /// Saisie dans la console du réalisateur
        /// </summary>
        private void SaisieRealisateur()
        {
            try
            {
                Console.Write("-- Réalisateur ? ");
                this.Realisateur = Console.ReadLine();
            }
            catch (Exception) { Console.WriteLine(Affichage.Erreur("Saisie non conforme")); }
        }

        /// <summary>
        /// Saisie dans la console du scénariste
        /// </summary>
        private void SaisieScenariste()
        {
            try
            {
                Console.Write("-- Scénariste ? ");
                this.Scenariste = Console.ReadLine();
            }
            catch (Exception) { Console.WriteLine(Affichage.Erreur("Saisie non conforme")); }
        }

        /// <summary>
        /// Saisie dans la console du studio
        /// </summary>
        private void SaisieStudio()
        {
            try
            {
                Console.Write("-- Studio ? ");
                this.Studio = Console.ReadLine();
            }
            catch (Exception) { Console.WriteLine(Affichage.Erreur("Saisie non conforme")); }
        }

        /// <summary>
        /// Saisie dans la console de la durée
        /// </summary>
        private void SaisieDurée()
        {
            try
            {
                Console.Write("-- Durée (en minutes) ? ");
                this.Durée = Int32.Parse(Console.ReadLine());
            }
            catch (Exception) { Console.WriteLine(Affichage.Erreur("Saisie non conforme")); }
        }

        /// <summary>
        /// Saisie dans la console des acteurs principaux
        /// </summary>
        private void SaisieActeurs()
        {
            try
            {
                Console.Write("-- Acteurs Principaux ? ");
                //Pour ajouter un acteur à la liste, l'utilisateur entre son nom et appuie sur Entrée
                Console.Write("\n----- Tapez le nom de l'acteur puis appuyez sur 'Entrée' pour l'ajouter à la liste.");
                //Il pourra faire cette manipulation jusqu'à ce qu'il entre "stop"
                Console.Write("\n----- Tapez \"stop\" quand la liste est complète.\n");

                string s;
                List<string> act = new List<string>();

                //L'utilisateur saisira toujours au moins un mot, on peut utiliser une boucle do-while
                do
                {
                    //La fonction Trim permet d'enlever les espaces inutiles au début et à la fin de l'entrée de l'utilisateur
                    //Permet d'éviter un certain nombre d'erreurs d'inattention lors de la saisie
                    s = Console.ReadLine().Trim();
                    if (s != "stop") act.Add(s);
                } while (s != "stop");

                this.Acteurs = act;
            }
            catch (Exception) { Console.WriteLine(Affichage.Erreur("Saisie non conforme")); }
        }

        #endregion
    }
}
