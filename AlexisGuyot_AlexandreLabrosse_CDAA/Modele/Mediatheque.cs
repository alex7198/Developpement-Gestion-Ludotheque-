using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexisGuyot_AlexandreLabrosse_CDAA.Modele
{
    /// <summary>
    /// Médiathèque dont l'application gère la liste des médias
    /// </summary>
    public class Mediatheque
    {
        #region Attributs

        private static Mediatheque instance = null;

        private string nom;
        private string adresse;
        private int codePostal;
        private string ville;
        private LesMedias medias;

        #endregion

        #region Propriétés

        public string Nom { get { return nom; } set { nom = value; } }
        public string Adresse { get { return adresse; } set { adresse = value; } }
        public int CodePostal { get { return codePostal; } set { codePostal = value; } }
        public string Ville { get { return ville; } set { ville = value; } }
        public LesMedias Medias { get { return medias; } set { medias = value; } }

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="n">Nom de la médiathèque</param>
        /// <param name="a">Adresse de la médiathèque</param>
        /// <param name="c">Code Postal de la médiathèque</param>
        /// <param name="v">Ville de la médiathèque</param>
        /// <param name="m">Médias stockés dans la médiathèque</param>
        private Mediatheque(string n, string a, int c, string v, LesMedias m)
        {
            this.Nom = n;
            this.Adresse = a;
            this.CodePostal = c;
            this.Ville = v;
            this.Medias = m;
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        private Mediatheque()
        {
            this.Nom = "";
            this.Adresse = "";
            this.CodePostal = 0;
            this.Ville = "";
            this.Medias = new LesMedias();
        }

        /// <summary>
        /// Constructeur du singleton sans paramètres
        /// </summary>
        /// <returns></returns>
        public static Mediatheque Instance()
        {
            if (instance == null) instance = new Mediatheque();
            return instance;
        }

        /// <summary>
        /// Constructeur du singleton sans paramètres
        /// </summary>
        /// <param name="n">Nom de la mediathèque</param>
        /// <param name="a">Adresse de la mediathèque</param>
        /// <param name="c">Code Postal de la médiathèque</param>
        /// <param name="v">Ville de la médiathèque</param>
        /// <param name="m">Liste de médias contenus dans la médiathèque</param>
        /// <returns></returns>
        public static Mediatheque Instance(string n, string a, int c, string v, LesMedias m)
        {
            if (instance == null) instance = new Mediatheque(n, a, c, v, m);
            return instance;
        }

        #endregion

        /// <summary>
        /// Permet de saisir à la console les informations concernant la médiathèque
        /// </summary>
        public void Saisie()
        {
            this.SaisieNom();
            this.SaisieAdresse();
            this.SaisieCodePostal();
            this.SaisieVille();
        }

        /// <summary>
        /// Affiche les informations enregistrées sur la médiathèque
        /// </summary>
        public void Affiche()
        {
            Console.WriteLine(this.ToString());
        }

        /// <summary>
        /// Permet de modifier un des attributs en particulier, sans toucher aux autres
        /// </summary>
        /// <returns>1 si un attribut a été modifié, 0 si non</returns>
        public virtual void SaisiePartielle()
        {
            string choix;

            //Chaque attribut est associé à un code pour pouvoir le choisir
            Console.WriteLine(Affichage.Titre1("Modifier un champ"));
            Console.WriteLine("Quel champ voulez-vous modifier ?\n" +
                "   1. Nom (" + this.Nom + ") \n" +
                "   2. Adresse (" + this.Adresse + ") \n" +
                "   3. Code Postal (" + this.CodePostal + ") \n" +
                "   4. Ville (" + this.Ville + ") \n");

            //L'utilisateur fait son choix
            choix = Console.ReadLine();

            //En fonction de ce choix ...
            //Pour chaque possibilité, on regarde si le choix de l'utilisateur correspond à un code
            //Ou s'il a entré le nom du choix (le ToLower permet de ne pas se soucier de la casse)
            if (choix.ToLower().Contains("nom") || choix == "1")
            {
                this.SaisieNom();
            }
            if (choix.ToLower().Contains("adresse") || choix == "2")
            {
                this.SaisieAdresse();
            }
            if (choix.ToLower().Contains("code") || choix == "3")
            {
                this.SaisieCodePostal();
            }
            if (choix.ToLower().Contains("ville") || choix == "4")
            {
                this.SaisieVille();
            }
        }

        #region Fonctions privées de saisie

        /// <summary>
        /// Saisit le nom de la médiathèque via la console
        /// </summary>
        private void SaisieNom()
        {
            Console.Write("-- Nom de la médiatèque ? "); this.Nom = Console.ReadLine();
            if(this.Nom == "") Console.WriteLine(Affichage.Erreur("Champ vide. Vous pourrez modifier cette information ultérieurement."));
        }

        /// <summary>
        /// Saisit l'adresse de la médiathèque via la console
        /// </summary>
        private void SaisieAdresse()
        {
            Console.Write("-- Adresse ? "); this.Adresse = Console.ReadLine();
            if (this.Adresse == "") Console.WriteLine(Affichage.Erreur("Champ vide. Vous pourrez modifier cette information ultérieurement."));
        }

        /// <summary>
        /// Saisit le code postal de la médiathèque via la console
        /// </summary>
        private void SaisieCodePostal()
        {
            Console.Write("-- Code Postal ? ");
            try {
                int cp = Int32.Parse(Console.ReadLine());
                //On vérifie que le code postal vérifie le format des cp français
                if (cp.ToString().Length == 5) this.CodePostal = cp;
                //Sinon le format est incorrect
                else throw new Exception();
            } catch (Exception) { Console.WriteLine(Affichage.Erreur("Format incorrect. Vous pourrez modifier cette information ultérieurement.")); }
        }

        /// <summary>
        /// Saisit la ville de la médiathèque via la console
        /// </summary>
        private void SaisieVille()
        {
            Console.Write("-- Ville ? "); this.Ville = Console.ReadLine();
            if (this.Ville == "") Console.WriteLine(Affichage.Erreur("Champ vide. Vous pourrez modifier cette information ultérieurement."));
        }

        #endregion
    }
}
