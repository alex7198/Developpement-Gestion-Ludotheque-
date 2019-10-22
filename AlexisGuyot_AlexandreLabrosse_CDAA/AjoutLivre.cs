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
    public partial class AjoutLivre : Form
    {
        //Attributs spécifiques au livre
        private string auteur;
        private int nbPages;
        private string editeur;

        //Propriétés
        public string Auteur { get { return auteur; } }
        public int NbPages { get { return nbPages; } }
        public string Editeur { get { return editeur; } }

        /// <summary>
        /// Initialisation et création de la fenêtre
        /// </summary>
        public AjoutLivre()
        {
            InitializeComponent();
            auteur = "";
            nbPages = -1;
            editeur = "";
        }

        /// <summary>
        /// Quand l'utilisateur clique sur "Valider" ou appuie sur Entrée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Valider_Click(object sender, EventArgs e)
        {
            //On récupère les infos entrées
            this.auteur = this.Textbox_Auteur.Text;
            try { this.nbPages = Int32.Parse(this.Textbox_NbPages.Text); } catch (Exception) { }
            this.editeur = this.Textbox_Editeur.Text;

            //On indique que tout est ok et on ferme la fenêtre
            this.DialogResult = DialogResult.OK;
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
            //On indique qu'il faut annuler et on ferme
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
            this.Dispose();
        }
    }
}
