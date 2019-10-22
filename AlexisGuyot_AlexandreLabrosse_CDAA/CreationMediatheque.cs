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
    public partial class CreationMediatheque : Form
    {
        /// <summary>
        /// Initialise et crée la fenêtre
        /// </summary>
        public CreationMediatheque()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Quand l'utilisateur appuie sur le bouton "Valider", il faut créer la médiathèque avec les
        /// informations données puis lancer l'application principale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Valider_Click(object sender, EventArgs e)
        {
            try
            {
                //On récupère les infos entrées par l'utilisateur
                int codePostal = Int32.Parse(this.CodePostal.Text);
                string nom = this.Nom.Text;
                string adresse = this.Adresse.Text;
                string ville = this.Ville.Text;

                //On crée la médiathèque
                LesMedias liste = new LesMedias();
                Mediatheque m = Mediatheque.Instance(nom, adresse, codePostal, ville, liste);

                //On crée l'application princale, on cache la fenêtre de création puis on lance
                MenuPrincipal menu = new MenuPrincipal(m);
                this.Hide();
                menu.ShowDialog();

                //Quand l'application principale est fermée, on ferme cette fenêtre
                this.Dispose();
            }
            catch(FormatException)
            {
                //Si l'utilisateur entre un code postal qui n'est pas un chiffre, on annule la
                //validation puis on lui indique son erreur
                this.CodePostal.BorderStyle = BorderStyle.Fixed3D;
                this.CodePostal.Text = "Le code postal doit être un chiffre";
            }
        }
    }
}
