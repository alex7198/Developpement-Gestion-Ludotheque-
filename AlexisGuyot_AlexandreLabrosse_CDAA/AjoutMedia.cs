using AlexisGuyot_AlexandreLabrosse_CDAA.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlexisGuyot_AlexandreLabrosse_CDAA
{
    public partial class AjoutFilm : Form
    {
        //Médiathèque dans laquelle ajouter le média
        private Mediatheque mediatheque;
        public Mediatheque Mediath { get { return mediatheque; } }

        /// <summary>
        /// Initialise et crée la fenêtre
        /// </summary>
        /// <param name="m">Médiathèque sur laquelle on travaille</param>
        public AjoutFilm(Mediatheque m)
        {
            InitializeComponent();
            this.mediatheque = m;
            this.initListeGenres();
        }

        /// <summary>
        /// Initialisation de la liste des genres disponibles pour un média
        /// </summary>
        private void initListeGenres()
        {
            foreach (string s in Enum.GetNames(typeof(Genres)))
                this.Genre.Items.Add(s);
        }

        /// <summary>
        /// Quand l'utilisateur choisit le type Livre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Livre_CheckedChanged(object sender, EventArgs e)
        {
            //On s'assure que le type Film ne soit pas sélectionné
            if (this.Film.Checked && this.Livre.Checked) this.Film.Checked = false;
        }

        /// <summary>
        /// Quand l'utilisateur choisit le type film
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Film_CheckedChanged(object sender, EventArgs e)
        {
            //On s'assure que le type Livre ne soit pas sélectionné
            if (this.Film.Checked && this.Livre.Checked) this.Livre.Checked = false;
        }

        /// <summary>
        /// Quand l'utilisateur clique sur le bouton "Annuler" ou appuie sur Echap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Annuler_Click(object sender, EventArgs e)
        {
            //On annule et on ferme la fenêtre
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
            this.Dispose();
        }

        /// <summary>
        /// Quand l'utilisateur clique sur le bouton "Valider" ou appuie sur la touche Entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Valider_Click(object sender, EventArgs e)
        {
            //On récupère les infos entrées dans le formulaire
            string reference = this.Reference.Text;
            string titre = this.Titre.Text;
            string description = this.Description.Text;
            string genre = this.Genre.Text;

            int jour;
            int mois;
            int annee;
            try { jour = Int32.Parse(this.Jour.Text); } catch (Exception) { jour = 1; }
            try { mois = Int32.Parse(this.Mois.Text); } catch (Exception) { mois = 1; }
            try { annee = Int32.Parse(this.Annee.Text); } catch (Exception) { annee = 1; }

            //La référence doit être unique pour continuer
            if(reference != "" && mediatheque.Medias.RechercheRef(reference) == null)
            {
                //Pour pouvoir continuer l'utilisateur doit avoir choisi un type de média
                if (this.Livre.Checked || this.Film.Checked)
                {
                    Media m = null; //Média à ajouter

                    //Si l'utilisateur veut créer un livre
                    if (this.Livre.Checked)
                    {
                        //On lance l'interface pour renseigner les attributs propres aux livres
                        AjoutLivre livre = new AjoutLivre();

                        //Si l'utilisateur a validé on crée le livre avec les infos renseignées sur les deux pages
                        if (livre.ShowDialog() == DialogResult.OK)
                        {
                            m = new Livre(reference, titre, description, genre, new DateTime(annee, mois, jour), livre.Auteur, livre.NbPages, livre.Editeur);
                        }
                    }

                    //Si l'uilisateur veur créer un film
                    if (this.Film.Checked)
                    {
                        //On lance l'interface pour renseigner les attributs propres aux films
                        AjoutFilms film = new AjoutFilms();

                        //Si l'utilisateur a validé on crée le film avec les infos renseignées sur les deux pages
                        if (film.ShowDialog() == DialogResult.OK)
                        {
                            m = new Film(reference, titre, description, genre, new DateTime(annee, mois, jour), film.Dur, film.Real, film.Scena, film.Stud, film.Act);
                        }
                    }

                    //Quand le média est créé, on l'ajoute à la médiathèque puis on ferme la fenêtre
                    this.mediatheque.Medias.Ajout(m);
                    this.Hide();
                    this.Dispose();
                }
            }

            //Sinon on indique à l'utilisateur qu'il y a un problème
            else
            {
                this.Reference.BorderStyle = BorderStyle.Fixed3D;
                this.Label_Reference.Text = "Cette référence est déjà utilisée";
            }
        }
    }
}
