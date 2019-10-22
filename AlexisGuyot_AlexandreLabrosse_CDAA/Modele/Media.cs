using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexisGuyot_AlexandreLabrosse_CDAA.Modele
{
    /// <summary>
    /// Média stocké dans la médiathèque
    /// </summary>
    public abstract class Media : IEquatable<Media>, IComparable<Media>
    {
        #region Attributs

        private string reference;   //Identifiant du media
        private string titre;
        private string description;
        private Genres genre;
        private DateTime anneeParution;
        private DateTime dateEntree;    //Date à laquelle le média a été entré dans l'application
        private Image miniature;

        #endregion

        #region Propriétés

        public string Reference { get { return reference; } set { reference = value; } }
        public string Titre { get { return titre; } set { titre = value; } }
        public string Description { get { return description; } set { description = value; } }
        public Genres Genre { get { return genre; } set { genre = value; } }
        /// <summary>
        /// Définition/Accès au type énuméré à travers des chaînes de caractères
        /// </summary>
        public string GenreS {
            get { return Enum.Format(typeof(Genres), this.genre, "g"); }
            set { try { this.genre = (Genres)Enum.Parse(typeof(Genres), value, false); }
                  catch (Exception) { this.genre = Genres.Autres;  } }
        }
        public DateTime AnneeParution { get { return anneeParution; } set { anneeParution = value; } }
        public DateTime DateEntree { get { return dateEntree; } set { dateEntree = value; } }
        public Image Miniature { get { return miniature; } set { miniature = value; } }

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur utilisant le type énuméré Genres
        /// </summary>
        /// <param name="r">Référence du média</param>
        /// <param name="t">Titre du média</param>
        /// <param name="d">Description/Résumé de l'histoire du média</param>
        /// <param name="g">Genre du média</param>
        /// <param name="a">Année de parution du média</param>
        /// <param name="dateEnt">Date d'entrée du média dans l'application</param>
        public Media(string r, string t, string d, Genres g, DateTime a)
        {
            Reference = r;
            Titre = t;
            Description = d;
            Genre = g;
            AnneeParution = a;
            /*La date d'entrée du média est renseignée par la classe DateTime, 
             * qui nous donne ici l'heure courante au moment de l'exécution du code*/
            DateEntree = DateTime.Now;
            Miniature = Image.FromFile("../../Resources/NA.jpg");
        }

        /// <summary>
        /// Constructeur utilisant un string plutôt que le type énuméré Genres
        /// </summary>
        /// <param name="r">Référence du média</param>
        /// <param name="t">Titre du média</param>
        /// <param name="d">Description/Résumé de l'histoire du média</param>
        /// <param name="g">Genre du média</param>
        /// <param name="a">Année de parution du média</param>
        /// <param name="dateEnt">Date d'entrée du média dans l'application</param>
        public Media(string r, string t, string d, string g, DateTime a)
        {
            Reference = r;
            Titre = t;
            Description = d;
            GenreS = g;
            AnneeParution = a;
            DateEntree = DateTime.Now;
            Miniature = Image.FromFile("../../Resources/NA.jpg");
        }

        /// <summary>
        /// Constructeur par copie
        /// </summary>
        /// <param name="m">Media à copier</param>
        public Media(Media m)
        {
            Reference = m.Reference;
            Titre = m.Titre;
            Description = m.Description;
            GenreS = m.GenreS;
            AnneeParution = m.AnneeParution;
            DateEntree = DateTime.Now;
            Miniature = m.Miniature;
        }

        /// <summary>
        /// Constructeur par défaut d'un média
        /// Référence -->  Chaine vide
        /// Titre et Description --> "N/A" pour "Not Available"
        /// Genre --> Autres
        /// Date au Premier Janvier de l'an 1
        /// </summary>
        public Media()
        {
            this.Reference = "";
            this.Titre = "N/A";
            this.Description = "N/A";
            this.Genre = Genres.Autres;
            this.AnneeParution = new DateTime(1, 1, 1);
            this.DateEntree = DateTime.Now;
            Miniature = Image.FromFile("../../Resources/NA.jpg");
        }
        #endregion

        #region Surcharge Opérateurs
        
        /// <summary>
        /// Surcharge de l'opérateur ==
        /// </summary>
        /// <param name="m1">Media à gauche du ==</param>
        /// <param name="m2">Media à droite du ==</param>
        /// <returns>True si les médias sont égaux, false si non</returns>
        public static bool operator ==(Media m1, Media m2)
        {
            bool res;

            if ((Object) m1 == null) res = ((Object) m2 == null);
            else res = m1.Equals(m2);

            return res;
        }

        /// Surcharge de l'opérateur !=
        /// </summary>
        /// <param name="m1">Media à gauche du !=</param>
        /// <param name="m2">Media à droite du !=</param>
        /// <returns>True si les médias sont différents, false si non</returns>
        public static bool operator !=(Media m1, Media m2)
        {
            return !(m1 == m2);
        }

        /// Surcharge de l'opérateur <
        /// </summary>
        /// <param name="m1">Media à gauche du <</param>
        /// <param name="m2">Media à droite du <</param>
        /// <returns>True si le média de gauche est inférieur à celui de droite, false si non</returns>
        public static bool operator <(Media m1, Media m2)
        {
            if (m1.CompareTo(m2) == -1) return true;
            return false;
        }

        /// Surcharge de l'opérateur >
        /// </summary>
        /// <param name="m1">Media à gauche du ></param>
        /// <param name="m2">Media à droite du ></param>
        /// <returns>True si le média de gauche est supérieur à celui de droite, false si non</returns>
        public static bool operator >(Media m1, Media m2)
        {
            if (m1.CompareTo(m2) == 1) return true;
            return false;
        }

        /// Surcharge de l'opérateur <=
        /// </summary>
        /// <param name="m1">Media à gauche du <=</param>
        /// <param name="m2">Media à droite du <=</param>
        /// <returns>True si le média de gauche est inférieur ou égal à celui de droite, false si non</returns>
        public static bool operator <=(Media m1, Media m2)
        {
            if (m1.CompareTo(m2) == -1 || m1.CompareTo(m2) == 0) return true;
            return false;
        }

        /// Surcharge de l'opérateur >=
        /// </summary>
        /// <param name="m1">Media à gauche du >=</param>
        /// <param name="m2">Media à droite du >=</param>
        /// <returns>True si le média de gauche est supérieur ou égal à celui de droite, false si non</returns>
        public static bool operator >=(Media m1, Media m2)
        {
            if (m1.CompareTo(m2) == 1 || m1.CompareTo(m2) == 0) return true;
            return false;
        }

        /// <summary>
        /// Indique dans quelles conditions l'objet en paramètre est égal à l'objet courante
        /// </summary>
        /// <param name="obj">Objet à comparer avec l'instance courante</param>
        /// <returns>True si les deux objets sont égaux, false si non</returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Media m = obj as Media;
            if (m == null) return false;
            else return Equals(m);
        }

        /// <summary>
        /// Indique comment deux médias s'ordonnent entre eux
        /// </summary>
        /// <param name="other">Autre média</param>
        /// <returns>1 si le média courant est plus grand que l'autre, 0 s'ils sont égaux et -1 s'il est plus petit</returns>
        public int CompareTo(Media other)
        {
            //J'ai fait le choix de dire que les médias s'ordonnent entre eux de façon alphabétique selon leur titre
            if (other == null) return 1;
            return this.Titre.CompareTo(other.Titre);
        }

        /// <summary>
        /// Indique si le média courant est égal au média passé en paramètre (références identiques)
        /// </summary>
        /// <param name="other">Autre média à comparer</param>
        /// <returns>true s'ils sont identiques, false sinon</returns>
        public bool Equals(Media other)
        {
            bool res = false;

            if (other != null)
            {
                Media m = (Media) other;
                res = (this.Reference == m.Reference);
            }

            return res;
        }

        /// <summary>
        /// Définit un hashcode (code unique) pour identifier l'instance
        /// Fonction à surcharger lorsque Equals est surchargée
        /// Ici générée par l'IDE
        /// </summary>
        /// <returns>Le hashcode généré</returns>
        public override int GetHashCode()
        {
            var hashCode = 1663584693;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(reference);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(titre);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(description);
            hashCode = hashCode * -1521134295 + genre.GetHashCode();
            hashCode = hashCode * -1521134295 + anneeParution.GetHashCode();
            hashCode = hashCode * -1521134295 + dateEntree.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Reference);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Titre);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            hashCode = hashCode * -1521134295 + Genre.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GenreS);
            hashCode = hashCode * -1521134295 + AnneeParution.GetHashCode();
            hashCode = hashCode * -1521134295 + DateEntree.GetHashCode();
            return hashCode;
        }

        #endregion

        /// <summary>
        /// Retourne une chaîne de caractères contenant la valeur des attributs de la classe
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string s = "\n";

            //Ajoute un petit effet pour mettre en avant le titre lors de l'affichage
            s += Affichage.Titre1(this.Titre);

            s += "Description : " + this.Description + "\n";

            s += "\nReference : " + this.Reference + "\n";
            s += "Genre : " + this.GenreS + "\n";
            s += "Année de Parution : " + this.AnneeParution + "\n";

            s += "\nDate de saisie dans l'application : " + this.DateEntree + "\n";

            return s;
        }

        /// <summary>
        /// Version alternative de la fonction ToString(), plus minimaliste
        /// </summary>
        /// <returns>La référence, le titre et l'année de parution du média</returns>
        public virtual string ToStringMin()
        {
            return this.Reference + " - " + this.Titre.ToUpper() + " (" + this.AnneeParution.Year + ")";
        }

        /// <summary>
        /// Affiche dans la console le résultat du ToString de l'instance
        /// </summary>
        public void Afficher()
        {
            Console.WriteLine(this.ToString());
        }

        /// <summary>
        /// Permet de modifier complètement la valeur de tous les attributs depuis la console
        /// </summary>
        public virtual void Saisie()
        {
            //Mise en évidence dans la console du but de la fonction
            Console.WriteLine(Affichage.Titre1("Saisie d'un nouveau media"));

            //Mise à jour des différents attributs
            this.SaisieRef();
            this.SaisieTitre();
            this.SaisieDescription();
            this.SaisieGenre();
            this.SaisieAnnee();

            //La date d'entrée du média devient la date de dernière modification
            this.DateEntree = DateTime.Now;
        }

        #region Autre Version de SaisiePartielle n'utilisant pas le abstract
        /*
        /// <summary>
        /// Permet de modifier un des attributs en particulier, sans toucher aux autres
        /// </summary>
        /// <returns>1 si un attribut a été modifié, 0 si non</returns>
        public virtual int SaisiePartielle()
        {
            string choix;
            int sortie = 0;
            int borneSub = 49;

            if (this.Description.Length <= 49) borneSub = this.Description.Length;

            //Chaque attribut est associé à un code pour pouvoir le choisir
            Console.WriteLine(Affichage.Titre1("Modifier un champ"));
            Console.WriteLine("Quel champ voulez-vous modifier ?\n" +
                "   1. Reference (" + this.Reference + ") \n" +
                "   2. Titre (" + this.Titre + ") \n" +
                "   3. Description (" + this.Description.Substring(0,borneSub) + "..." + ") \n" +
                "   4. Genre (" + this.GenreS + ") \n" +
                "   5. Année de parution (" + this.AnneeParution + ") \n" +
                "   6. ...\n");

            //L'utilisateur fait son choix
            choix = Console.ReadLine();

            //En fonction de ce choix ...
            //Pour chaque possibilité, on regarde si le choix de l'utilisateur correspond à un code
            //Ou s'il a entré le nom du choix (le ToLower permet de ne pas se soucier de la casse)
            if(choix.ToLower().Contains("reference") || choix.ToLower().Contains("1"))
            {
                this.SaisieRef();
                sortie = 1;
            }
            if (choix.ToLower().Contains("titre") || choix.ToLower().Contains("2"))
            {
                this.SaisieTitre();
                sortie = 1;
            }
            if (choix.ToLower().Contains("description") || choix.ToLower().Contains("3"))
            {
                this.SaisieDescription();
                sortie = 1;
            }
            if (choix.ToLower().Contains("genre") || choix.ToLower().Contains("4"))
            {
                this.SaisieGenre();
                sortie = 1;
            }
            if (choix.ToLower().Contains("parution") || choix.ToLower().Contains("5"))
            {
                this.SaisieAnnee();
                sortie = 1;
            }

            return sortie;
        }*/
        #endregion

        /// <summary>
        /// Permet de modifier un des attributs en particulier, sans toucher aux autres
        /// </summary>
        /// <returns>1 si un attribut a été modifié, 0 si non</returns>
        public virtual void SaisiePartielle()
        {
            string choix;
            int borneSub = 49;

            //Réduit l'affichage de la description si celle-ci fait plus de 49 caractères
            if (this.Description.Length <= 49) borneSub = this.Description.Length;
            string desc;
            if (borneSub == 49) desc = this.Description.Substring(0, borneSub) + "...";
            else desc = this.Description;

            //Chaque attribut est associé à un code pour pouvoir le choisir
            Console.WriteLine(Affichage.Titre1("Modifier un champ"));
            Console.WriteLine("Quel champ voulez-vous modifier ?\n" +
                "   1. Reference (" + this.Reference + ") \n" +
                "   2. Titre (" + this.Titre + ") \n" +
                "   3. Description (" + desc + ") \n" +
                "   4. Genre (" + this.GenreS + ") \n" +
                "   5. Année de parution (" + this.AnneeParution + ") \n" +
                this.ChoixEnfant());

            //L'utilisateur fait son choix
            choix = Console.ReadLine();

            //En fonction de ce choix ...
            //Pour chaque possibilité, on regarde si le choix de l'utilisateur correspond à un code
            //Ou s'il a entré le nom du choix (le ToLower permet de ne pas se soucier de la casse)
            if (choix.ToLower().Contains("reference") || choix == "1")
            {
                this.SaisieRef();
            }
            if (choix.ToLower().Contains("titre") || choix == "2")
            {
                this.SaisieTitre();
            }
            if (choix.ToLower().Contains("description") || choix == "3")
            {
                this.SaisieDescription();
            }
            if (choix.ToLower().Contains("genre") || choix == "4")
            {
                this.SaisieGenre();
            }
            if (choix.ToLower().Contains("parution") || choix == "5")
            {
                this.SaisieAnnee();
            }

            this.SaisiePartielleEnfant(choix);
        }

        /*En tant que tel, un média, qui est une notion abstraite, ne connait pas la totalité
         des options parmi lesquelles l'utilisateur va pouvoir choisir. Seule la classe fille
         concrète pourra le savoir. En utilisant cette technique, cette dernière va renseigner
         les options et les traitements qu'elle souhaite ajouter en fonction de ses besoins et
         la classe Media ira compléter son code avec ceux implémentés dans la classe fille
         courante.*/
        protected abstract string ChoixEnfant();
        protected abstract void SaisiePartielleEnfant(string choix);

        #region Fonctions pour SaisiePartielle

        /*Plutôt que de répéter le code de saisie d'un attribut dans Saisie et SaisiePartielle,
         on le place dans une fonction privée qu'on appelle plusieurs fois*/

        /// <summary>
        /// Saisie dans la console de la référence
        /// </summary>
        private void SaisieRef()
        {
            bool ok = false;
            while (!ok)
            {
                try
                {
                    Console.Write("-- Reference ? ");
                    this.Reference = Console.ReadLine();
                    if (this.Reference == "") throw new Exception();
                    else ok = true;
                }
                catch (Exception) { Console.WriteLine(Affichage.Erreur("Saisie non conforme")); }
            }
        }

        /// <summary>
        /// Saisie dans la console du titre
        /// </summary>
        private void SaisieTitre()
        {
            try
            {
                Console.Write("-- Titre ? ");
                this.Titre = Console.ReadLine();
            }
            catch (Exception) { Console.WriteLine(Affichage.Erreur("Saisie non conforme")); }
        }

        /// <summary>
        /// Saisie dans la console de la description/du résumé
        /// </summary>
        private void SaisieDescription()
        {
            try
            {
                Console.Write("-- Description ? ");
                this.Description = Console.ReadLine();
            }
            catch (Exception) { Console.WriteLine(Affichage.Erreur("Saisie non conforme")); }
        }

        /// <summary>
        /// Saisie dans la console du genre
        /// </summary>
        private void SaisieGenre()
        {
            try
            {
                Console.Write("-- Genre ? ");
                this.GenreS = Console.ReadLine();
            }
            catch (Exception) { Console.WriteLine(Affichage.Erreur("Saisie non conforme")); }
        }

        /// <summary>
        /// Saisie dans la console de l'année de parution
        /// </summary>
        private void SaisieAnnee()
        {
            try
            {
                Console.Write("-- Année de parution (Format : JJ/MM/YYYY ou JJ/MM/YYYY HH:mm:s) ? ");
                this.AnneeParution = DateTime.Parse(Console.ReadLine());
            }
            //Le premier catch va intercepter les exceptions levées lorsque l'utilisateur entre une date qui ne respecte pas les formats imposés
            catch (FormatException) { Console.WriteLine(Affichage.Erreur("La date ne respecte pas les formats ci-dessus.")); }
            catch (Exception) { Console.WriteLine(Affichage.Erreur("Saisie non conforme")); }
        }

        #endregion
    }
}
