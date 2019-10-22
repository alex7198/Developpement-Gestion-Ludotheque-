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
    public partial class ModifierMedia : Form
    {
        private Media m;            //Média à modifier
        private Media save_m;       //Sauvegarde en cas d'annulation

        /// <summary>
        /// Initialise et crée la fenêtre
        /// </summary>
        /// <param name="media">Média à modifier</param>
        public ModifierMedia(Media media)
        {
            this.m = media;
            if (m is Livre) this.save_m = new Livre(m as Livre);
            if (m is Film) this.save_m = new Film(m as Film);
            InitializeComponent();
            this.InitGrille();
        }

        /// <summary>
        /// Initialise le DataGridView
        /// </summary>
        private void InitGrille()
        {
            //La taille des lignes et colonnes d'adaptent au contenu
            this.Grille.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.Grille.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //Création de la colonne Genre
            DataGridViewComboBoxColumn genre = new DataGridViewComboBoxColumn();
            genre.Name = "Genre";
            genre.HeaderText = "Genre";
            genre.DataSource = Enum.GetNames(typeof(Genres));
            Grille.Columns.Add(genre);

            //Création des colonnes propres aux sous-classes Film et Livre
            DataGridViewColumn[] attFille = null;
            if (m is Livre) attFille = this.GrilleLivre();
            if (m is Film) attFille = this.GrilleFilm();
            Grille.Columns.AddRange(attFille);

            //Remplissage de la grille avec les valeurs de l'attribut
            Grille.Rows.Add(1);
            Grille.Rows[0].Cells["Miniature"].Value = m.Miniature;
            Grille.Rows[0].Cells["Reference"].Value = m.Reference;
            Grille.Rows[0].Cells["Titre"].Value = m.Titre;
            Grille.Rows[0].Cells["Description"].Value = m.Description;
            Grille.Rows[0].Cells["Jour"].Value = m.AnneeParution.Day;
            Grille.Rows[0].Cells["Mois"].Value = m.AnneeParution.Month;
            Grille.Rows[0].Cells["Annee"].Value = m.AnneeParution.Year;
            ((DataGridViewComboBoxCell)Grille.Rows[0].Cells["Genre"]).Value = genre.Items[(int)m.Genre];
            if(m is Livre)
            {
                Grille.Rows[0].Cells["Auteur"].Value = (m as Livre).Auteur;
                Grille.Rows[0].Cells["NbPages"].Value = (m as Livre).NbPages;
                Grille.Rows[0].Cells["Editeur"].Value = (m as Livre).Editeur;
            }
            if(m is Film)
            {
                Grille.Rows[0].Cells["Realisateur"].Value = (m as Film).Realisateur;
                Grille.Rows[0].Cells["Scenariste"].Value = (m as Film).Scenariste;
                Grille.Rows[0].Cells["Duree"].Value = (m as Film).Durée;
                Grille.Rows[0].Cells["Studio"].Value = (m as Film).Studio;
                Grille.Rows[0].Cells["Acteurs"].Value = (m as Film).ActeursS;
            }
        }

        /// <summary>
        /// Retourne les colonnes propres à la sous-classe Livre
        /// </summary>
        /// <returns>Les colonnes à ajouter à la DataGridView</returns>
        private DataGridViewColumn[] GrilleLivre()
        {
            DataGridViewTextBoxColumn auteur = new DataGridViewTextBoxColumn();
            auteur.Name = "Auteur";
            auteur.HeaderText = "Auteur";

            DataGridViewTextBoxColumn nbPages = new DataGridViewTextBoxColumn();
            nbPages.Name = "NbPages";
            nbPages.HeaderText = "Nombre de pages";

            DataGridViewTextBoxColumn editeur = new DataGridViewTextBoxColumn();
            editeur.Name = "Editeur";
            editeur.HeaderText = "Editeur";

            return new DataGridViewColumn[]{ auteur, nbPages, editeur };
        }

        /// <summary>
        /// Retourne les colonnes propres à la sous-classe Film
        /// </summary>
        /// <returns>Les colonnes à ajouter à la DataGridView</returns>
        private DataGridViewColumn[] GrilleFilm()
        {
            DataGridViewTextBoxColumn realisateur = new DataGridViewTextBoxColumn();
            realisateur.Name = "Realisateur";
            realisateur.HeaderText = "Réalisateur";

            DataGridViewTextBoxColumn scenariste = new DataGridViewTextBoxColumn();
            scenariste.Name = "Scenariste";
            scenariste.HeaderText = "Scénariste";

            DataGridViewTextBoxColumn duree = new DataGridViewTextBoxColumn();
            duree.Name = "Duree";
            duree.HeaderText = "Durée";

            DataGridViewTextBoxColumn studio = new DataGridViewTextBoxColumn();
            studio.Name = "Studio";
            studio.HeaderText = "Studio";

            DataGridViewTextBoxColumn acteurs = new DataGridViewTextBoxColumn();
            acteurs.Name = "Acteurs";
            acteurs.HeaderText = "Acteurs";

            return new DataGridViewColumn[] { realisateur, scenariste, duree, studio, acteurs };
        }

        /// <summary>
        /// Quand l'utilisateur fait une modification dans la grille
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Grille_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //On récupère la cellule concernée
            DataGridViewCell cell = (sender as DataGridView).Rows[0].Cells[e.ColumnIndex];

            //En fonction de la colonne sélectionnée
            switch (e.ColumnIndex)
            {
                //Titre
                case 2:
                    try { m.Titre = cell.Value.ToString(); } catch { }
                    break;
                //Description
                case 3:
                    try { m.Description = cell.Value.ToString(); } catch { }
                    break;
                //Jour
                case 4:
                    try
                    {
                        int jour = m.AnneeParution.Day;
                        try { jour = Int32.Parse(cell.Value.ToString()); } catch { }
                        m.AnneeParution = new DateTime(m.AnneeParution.Year, m.AnneeParution.Month, jour);
                    }
                    catch { }
                    break;
                //Mois
                case 5:
                    try
                    {
                        int mois = m.AnneeParution.Month;
                        try { mois = Int32.Parse(cell.Value.ToString()); } catch { }
                        m.AnneeParution = new DateTime(m.AnneeParution.Year, mois, m.AnneeParution.Day);
                    }
                    catch { }
                    break;
                //Année
                case 6:
                    try
                    {
                        int annee = m.AnneeParution.Year;
                        try { annee = Int32.Parse(cell.Value.ToString()); } catch { }
                        m.AnneeParution = new DateTime(annee, m.AnneeParution.Month, m.AnneeParution.Day);
                    }
                    catch { }
                    break;
                //Genre
                case 7:
                    try { m.GenreS = cell.Value.ToString(); } catch { }
                    break;
                //Auteur (Livre) / Realisateur (Film)
                case 8:
                    try
                    {
                        if (m is Livre) (m as Livre).Auteur = cell.Value.ToString();
                        if (m is Film) (m as Film).Realisateur = cell.Value.ToString();
                    }
                    catch { }
                    break;
                //Nombre de pages (Livre) / Scenariste (Film)
                case 9:
                    try
                    {
                        if (m is Livre) try { (m as Livre).NbPages = Int32.Parse(cell.Value.ToString()); } catch { }
                        if (m is Film) (m as Film).Scenariste = cell.Value.ToString();
                    }
                    catch { }
                    break;
                //Editeur (Livre) / Durée (Film)
                case 10:
                    try
                    {
                        if (m is Livre) (m as Livre).Editeur = cell.Value.ToString();
                        if (m is Film) try { (m as Film).Durée = Int32.Parse(cell.Value.ToString()); } catch { }
                    } catch { }
                    break;
                //Studio (Film)
                case 11:
                    try { (m as Film).Studio = cell.Value.ToString(); } catch { }
                    break;
                //Acteurs (Film)
                case 12:
                    try { (m as Film).ActeursS = cell.Value.ToString(); } catch { }
                    break;
            }
        }

        /// <summary>
        /// Quand l'utilisateur clique sur le bouton "Valider" ou appuie sur Entrée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Valider_Click(object sender, EventArgs e)
        {
            //On ferme
            this.Hide();
            this.Dispose();
        }

        /// <summary>
        /// Quand l'utilisateur clique sur "Annuler" ou appuie sur Echap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Annuler_Click(object sender, EventArgs e)
        {
            //On réinitialise les attributs du média grâce à la sauvegarde
            this.m.Titre = this.save_m.Titre;
            this.m.Description = this.save_m.Description;
            this.m.AnneeParution = this.save_m.AnneeParution;
            this.m.Genre = this.save_m.Genre;
            if (m is Livre) (m as Livre).Auteur = (save_m as Livre).Auteur;
            if (m is Livre) (m as Livre).NbPages = (save_m as Livre).NbPages;
            if (m is Livre) (m as Livre).Editeur = (save_m as Livre).Editeur;
            if (m is Film) (m as Film).Realisateur = (save_m as Film).Realisateur;
            if (m is Film) (m as Film).Scenariste = (save_m as Film).Scenariste;
            if (m is Film) (m as Film).Durée = (save_m as Film).Durée;
            if (m is Film) (m as Film).Studio = (save_m as Film).Studio;
            if (m is Film) (m as Film).Acteurs = (save_m as Film).Acteurs;

            //On ferme
            this.Hide();
            this.Dispose();
        }
    }
}
