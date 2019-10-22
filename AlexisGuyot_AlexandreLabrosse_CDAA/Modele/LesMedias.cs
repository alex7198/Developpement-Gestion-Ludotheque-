using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexisGuyot_AlexandreLabrosse_CDAA.Modele
{
    /// <summary>
    /// Représente une collection de médias gérée par la médiathèque
    /// </summary>
    public class LesMedias
    {
        private List<Media> medias;
        private bool triAlpha;          //Indique si la liste est triée par ordre alphabétique
        private bool triChrono;          //Indique si la liste est triée par ordre chronologique

        //Propriété associée à medias
        public List<Media> Medias { get { return medias; } }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public LesMedias()
        {
            this.medias = new List<Media>();
            this.triAlpha = false;
            this.triChrono = false;
        }

        /// <summary>
        /// Constructeur à partir d'une liste de médias existante
        /// </summary>
        /// <param name="liste">Autre collection de médias</param>
        public LesMedias(List<Media> liste)
        {
            if (liste != null) this.medias = liste;
            else this.medias = new List<Media>();
        }

        /// <summary>
        /// Ajout d'un média à la collection si celui-ci n'est pas déjà présent (référence identique)
        /// </summary>
        /// <param name="m">Media à ajouter</param>
        public void Ajout(Media m)
        {
            if (m != null && RechercheRef(m.Reference) == null) this.Medias.Add(m);
        }

        /// <summary>
        /// Permet d'isoler les livres parmi les médias de la collection
        /// </summary>
        /// <returns>Liste des livres présents dans la collection courante</returns>
        public LesMedias RechercheLivres()
        {
            LesMedias liste = new LesMedias();

            foreach (Media m in this.Medias)
                if (m is Livre) liste.Ajout(m);

            return liste;
        }

        /// <summary>
        /// Permet d'isoler les films parmi les médias de la collection
        /// </summary>
        /// <returns>Films contenus dans la collection courante</returns>
        public LesMedias RechercheFilms()
        {
            LesMedias liste = new LesMedias();

            foreach (Media m in this.Medias)
                if (m is Film) liste.Ajout(m);

            return liste;
        }

        /// <summary>
        /// Recherche un média dans la collection par sa référence
        /// </summary>
        /// <param name="r">Référence du média recherché</param>
        /// <returns>Le média trouvé ou null</returns>
        public Media RechercheRef(string r)
        {
            Media res = null;

            foreach(Media m in this.Medias)
            {
                if (m.Reference == r) res = m;
            }

            return res;
        }

        /// <summary>
        /// Recherche tous les médias de la collection possédant le titre passé en paramètre
        /// </summary>
        /// <param name="titre">Titre des médias recherchés</param>
        /// <returns>Tous les médias qui correspondent</returns>
        public LesMedias RechercheTitre(string titre)
        {
            /*On utilise ici la méthode findAll de la collection List<T>
             Celle-ci retourne une liste d'objets du type T pour lesquels l'expression
             de la fonction delegate renvoie true. Le media 'm' est le média de la liste
             en cours de traitement.*/
            LesMedias liste = new LesMedias(this.Medias.FindAll(delegate(Media m){
                return m.Titre.ToLower().Contains(titre.ToLower());
            }));

            return liste;
        }

        /// <summary>
        /// Recherche tous les médias parus l'année passée en paramètre
        /// </summary>
        /// <param name="annee">Année de parution</param>
        /// <returns>Les médias qui correspondent</returns>
        public LesMedias RechercheAnnee(int annee)
        {
            LesMedias liste = new LesMedias(this.Medias.FindAll(delegate (Media m) {
                return m.AnneeParution.Year == annee;
            }));

            return liste;
        }

        /// <summary>
        /// Retire le média de la liste possédant la référence r
        /// Il n'y en a forcément qu'un seul ou zéro puisque reference est unique grâce à la fonction d'ajout
        /// </summary>
        /// <param name="r">Reference du média à supprimer de la liste</param>
        public void Supprimer(string r)
        {
            Media m = this.RechercheRef(r);
            if(m != null) this.Medias.Remove(m);
        }

        /// <summary>
        /// Trie la liste des médias par ordre alphabétique des titres
        /// </summary>
        private void TrierAlphabetique()
        {
            //On peut utiliser la fonction Sort des Collections car les opérateurs sont surchargés dans Medias
            this.Medias.Sort();
            this.triAlpha = true;
            this.triChrono = false;
        }

        /// <summary>
        /// Trie la liste dans l'ordre alphabétique inverse
        /// </summary>
        public void TriAlphabetique()
        {
            //Si la liste est déjà triée par ordre alphabétique, on inverse juste l'ordre des éléments
            if (this.triAlpha) { this.Medias.Reverse(); this.triAlpha = false; }
            //Sinon on la trie puis on inverse
            else
            {
                this.TrierAlphabetique();
            }
            this.triChrono = false;
        }

        /// <summary>
        /// Trie la liste des médias selon leur date de parution
        /// </summary>
        private void TrierDatePublication()
        {
            //Ici on ne peut pas utliser la fonction Sort puisqu'on travaille sur les années de parution
            //On utilise donc un tri à bulles
            //Algorithme inspiré de celui trouvé au lien suivant : https://www.gladir.com/CODER/CSHARP/tribubble.htm
            for (int i = this.Medias.Count - 2; i >= 0; i--)
            {
                for(int j = 0; j <= i; j++)
                {
                    if(this.Medias[j+1].AnneeParution.Year < this.Medias[j].AnneeParution.Year)
                    {
                        Media m = this.Medias[j + 1];
                        this.Medias[j + 1] = this.Medias[j];
                        this.Medias[j] = m;
                    }
                }
            }
            this.triAlpha = false;
            this.triChrono = true;
        }

        /// <summary>
        /// Trie la liste dans l'ordre chronologique inverse
        /// </summary>
        public void TriChronologique()
        {
            //Si la liste est déjà triée par ordre chronologique, on inverse juste l'ordre des éléments
            if (this.triChrono) { this.Medias.Reverse(); this.triChrono = false; }
            //Sinon on la trie puis on inverse
            else
            {
                this.TrierDatePublication();
            }
            this.triAlpha = false;
        }

        /// <summary>
        /// Décrit tous les médias enregistrés dans la liste
        /// </summary>
        /// <returns>La description</returns>
        public override string ToString()
        {
            string s = "";

            if(this.Medias.Count != 0) s += Affichage.Titre1("Liste des médias enregistrés");
            //Cas où la liste est vide
            else s += Affichage.Titre1("Aucun résultat trouvé");

            foreach (Media m in this.Medias) s += m.ToStringMin();

            return s;
        }

        /// <summary>
        /// Retourne tous les médias de la liste qui possèdent le genre g
        /// </summary>
        /// <param name="g">Genre recherché</param>
        /// <returns>Médias qui possèdent ce genre</returns>
        public LesMedias GetMediaGenre(Genres g)
        {
            LesMedias liste = new LesMedias();

            foreach(Media m in this.Medias)
            {
                if (m.Genre == g) liste.Ajout(m);
            }

            return liste;
        }
    }
}
