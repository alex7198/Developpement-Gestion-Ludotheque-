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
    public partial class RechercherMedia : Form
    {
        private Mediatheque mediatheque;    //Mediathèque où effectuer la recherche
        private LesMedias resultat;         //Liste de médias qui contient les résultats

        //Propriétés
        public Mediatheque Media { get { return mediatheque; } }
        public LesMedias Resultat { get { return resultat; } }

        /// <summary>
        /// Initialise et crée la fenêtre
        /// </summary>
        /// <param name="m">Mediathèque où effectuer la recherche</param>
        public RechercherMedia(Mediatheque m)
        {
            InitializeComponent();
            this.mediatheque = m;
            this.resultat = new LesMedias();
        }

        private void Type_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //On récupère le type sélectionné
            string choix = this.Type.SelectedItem.ToString();

            //En fonction de ce choix on modifie l'interface
            switch (choix)
            {
                case "Tous les livres":
                    this.Label_Motif.Visible = false;
                    this.Motif.Visible = false;
                    break;
                case "Tous les films":
                    this.Label_Motif.Visible = false;
                    this.Motif.Visible = false;
                    break;
                case "Recherche par référence":
                    this.Label_Motif.Visible = true;
                    this.Motif.Visible = true;
                    this.Label_Motif.Text = "Entrez la référence du média recherché";
                    break;
                case "Recherche par titre":
                    this.Label_Motif.Visible = true;
                    this.Motif.Visible = true;
                    this.Label_Motif.Text = "Entrez le titre ou un morceau du titre du média recherché";
                    break;
                case "Recherche par date de publication":
                    this.Label_Motif.Visible = true;
                    this.Motif.Visible = true;
                    this.Label_Motif.Text = "Entrez l'année de publication du média recherché";
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
            //On récupère le type de recherche voulu
            string choix = this.Type.SelectedItem.ToString();

            //En fonction de ce type, on effectue la recherche puis on valide
            switch (choix)
            {
                case "Tous les livres":
                    this.resultat = this.mediatheque.Medias.RechercheLivres();
                    this.ValiderBouton();
                    break;
                case "Tous les films":
                    this.resultat = this.mediatheque.Medias.RechercheFilms();
                    this.ValiderBouton();
                    break;
                case "Recherche par référence":
                    this.resultat.Ajout(this.mediatheque.Medias.RechercheRef(this.Motif.Text));
                    this.ValiderBouton();
                    break;
                case "Recherche par titre":
                    this.resultat = this.mediatheque.Medias.RechercheTitre(this.Motif.Text);
                    this.ValiderBouton();
                    break;
                case "Recherche par date de publication":
                    try { this.resultat = this.mediatheque.Medias.RechercheAnnee(Int32.Parse(this.Motif.Text)); }
                    catch (Exception) { }
                    this.ValiderBouton();
                    break;
            }
        }

        /// <summary>
        /// Indique que le processus s'est bien passé puis ferme la fenêtre
        /// </summary>
        private void ValiderBouton()
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
            this.Dispose();
        }

        /// <summary>
        /// Quand l'utilisateur clique sur "Annuler" ou appuie sur la touche Echap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Annuler_Click(object sender, EventArgs e)
        {
            //On annule puis on ferme
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
            this.Dispose();
        }
    }
}
