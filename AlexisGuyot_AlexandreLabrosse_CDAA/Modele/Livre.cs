using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexisGuyot_AlexandreLabrosse_CDAA.Modele
{
    /// <summary>
    /// Un livre est un type de média stocké dans la médiathèque
    /// </summary>
    public class Livre : Media
    {
        #region Attributs

        private string auteur;
        private int nbPages;
        private string editeur;

        #endregion

        #region Propriétés

        public string Auteur { get { return auteur; } set { auteur = value; } }
        public int NbPages { get { return nbPages; } set { nbPages = value; } }
        public string Editeur { get { return editeur; } set { editeur = value; } }

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="r">Référence du média</param>
        /// <param name="t">Titre du média</param>
        /// <param name="d">Description/Résumé du média</param>
        /// <param name="g">Genre du média</param>
        /// <param name="a">Année de parution du média</param>
        /// <param name="_auteur">Auteur du livre</param>
        /// <param name="_nbPages">Nombre de pages du livre</param>
        /// <param name="e">Editeur du livre</param>
        public Livre(string r, string t, string d, Genres g, DateTime a, 
            string _auteur, int _nbPages, string e)
            : base(r, t, d, g, a)
        {
            this.Auteur = _auteur;
            this.NbPages = _nbPages;
            this.Editeur = e;
        }

        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="r">Référence du média</param>
        /// <param name="t">Titre du média</param>
        /// <param name="d">Description/Résumé du média</param>
        /// <param name="g">Genre du média</param>
        /// <param name="a">Année de parution du média</param>
        /// <param name="_auteur">Auteur du livre</param>
        /// <param name="_nbPages">Nombre de pages du livre</param>
        /// <param name="e">Editeur du livre</param>
        public Livre(string r, string t, string d, string g, DateTime a,
            string _auteur, int _nbPages, string e)
            : base(r, t, d, g, a)
        {
            this.Auteur = _auteur;
            this.NbPages = _nbPages;
            this.Editeur = e;
        }

        /// <summary>
        /// Constructeur par copie
        /// </summary>
        /// <param name="modele">Modele à copier</param>
        public Livre(Livre modele) : base(modele)
        {
            this.Auteur = modele.Auteur;
            this.NbPages = modele.NbPages;
            this.Editeur = modele.Editeur;
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Livre() : base()
        {
            this.Auteur = "";
            this.NbPages = -1;
            this.Editeur = "";
        }

        #endregion

        /// <summary>
        /// Idem que pour la classe Media mais ajoute les attributs propres à un livre
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() 
                + "\nAuteur : " + this.Auteur 
                + "\nEditeur : " + this.Editeur
                + "\nNombre de Pages : " +this.NbPages + "\n";
        }

        /// <summary>
        /// Version minimaliste du ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToStringMin()
        {
            string s = base.ToStringMin() + " - " + this.Auteur + " - " + this.NbPages + " page";
            if (this.NbPages > 1) s += "s";

            return s;
        }

        /// <summary>
        /// Idem que pour la classe Media mais demande la saisie des attributs propres à un livre
        /// </summary>
        public override void Saisie()
        {
            base.Saisie();
            this.SaisieAuteur();
            this.SaisieNbPages();
            this.SaisieEditeur();
        }

        #region Ancienne version de SaisiePartielle n'utilisant pas les notions d'abstract
        /*public override int SaisiePartielle()
        {
            string choix;
            int sortie;

            sortie = base.SaisiePartielle();

            //On propose de modifier un des champs de la sous-classe uniquement si aucune modification n'a été faite sur les attributs de la classe mère
            if (sortie == 0)
            {
                //Chaque attribut est associé à un code pour pouvoir le choisir
                Console.Clear();
                Console.WriteLine(Affichage.Titre1("Modifier un champ"));
                Console.WriteLine("Quel champ voulez-vous modifier ?\n" +
                    "   6. Auteur (" + this.Auteur + ") \n" +
                    "   7. Editeur (" + this.Editeur + ") \n" +
                    "   8. Nombre de pages (" + this.NbPages + ") \n");

                //L'utilisateur fait son choix
                choix = Console.ReadLine();

                if (choix.ToLower().Contains("auteur") || choix.ToLower().Contains("6"))
                {
                    this.SaisieAuteur();
                    sortie = 1;
                }
                if (choix.ToLower().Contains("editeur") || choix.ToLower().Contains("7"))
                {
                    this.SaisieEditeur();
                    sortie = 1;
                }
                if (choix.ToLower().Contains("pages") || choix.ToLower().Contains("8"))
                {
                    this.SaisieNbPages();
                    sortie = 1;
                }
            }

            return sortie;
        }*/
        #endregion

        /// <summary>
        /// Agrémente la fonction saisiePartielle de la classe mère avec les attributs propres aux livres
        /// </summary>
        /// <returns>Les nouveaux choix propres au livre</returns>
        protected override string ChoixEnfant()
        {
            return "   6. Auteur (" + this.Auteur + ") \n" +
                "   7. Editeur (" + this.Editeur + ") \n" +
                "   8. Nombre de pages (" + this.NbPages + ") \n";
        }

        /// <summary>
        /// Suite de la fonction SaisiePartielle qui gère les choix ajoutés par le livre
        /// </summary>
        /// <param name="choix">Choix saisi précédemment par l'utilisateur</param>
        protected override void SaisiePartielleEnfant(string choix)
        {
            if (choix.ToLower().Contains("auteur") || choix == "6")
            {
                this.SaisieAuteur();
            }
            if (choix.ToLower().Contains("editeur") || choix == "7")
            {
                this.SaisieEditeur();
            }
            if (choix.ToLower().Contains("pages") || choix == "8")
            {
                this.SaisieNbPages();
            }
        }

        #region Fonctions privées utiles pour les fonctions Saisie et SaisiePartielle

        /// <summary>
        /// Saisie dans la console d'un auteur
        /// </summary>
        private void SaisieAuteur()
        {
            try
            {
                Console.Write("-- Auteur ? ");
                this.Auteur = Console.ReadLine();
            }
            catch (Exception) { Console.WriteLine(Affichage.Erreur("Saisie non conforme")); }
        }

        /// <summary>
        /// Saisie dans la console du nombre de pages
        /// </summary>
        private void SaisieNbPages()
        {
            try
            {
                Console.Write("-- Nombre de Pages ? ");
                this.NbPages = Int32.Parse(Console.ReadLine());
            }
            catch (Exception) { Console.WriteLine(Affichage.Erreur("Saisie non conforme")); }
        }

        /// <summary>
        /// Saisie dans la console de l'éditeur
        /// </summary>
        private void SaisieEditeur()
        {
            try
            {
                Console.Write("-- Editeur ? ");
                this.Editeur = Console.ReadLine();
            }
            catch (Exception) { Console.WriteLine(Affichage.Erreur("Saisie non conforme")); }
        }

        #endregion
    }
}
