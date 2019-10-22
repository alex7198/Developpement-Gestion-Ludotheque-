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
    public partial class AjoutFilms : Form
    {
        //Attributs propres au film
        private string real;
        private string scena;
        private int dur;
        private string stud;
        private string act;

        //Propriétés
        public string Real { get { return real; } }
        public string Scena { get { return scena; } }
        public int Dur { get { return dur; } }
        public string Stud { get { return stud; } }
        public string Act { get { return act; } }

        /// <summary>
        /// Initialisation et création de la fenêtre
        /// </summary>
        public AjoutFilms()
        {
            InitializeComponent();
            this.real = "";
            this.scena = "";
            this.dur = -1;
            this.stud = "";
            this.act = "";
        }

        /// <summary>
        /// Quand l'utilisateur clique sur "Valider" ou appuie sur Entrée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Valider_Click(object sender, EventArgs e)
        {
            //On récupère les infos de l'interface
            this.real = this.Realisateur.Text;
            this.scena = this.Scenariste.Text;
            try { this.dur = Int32.Parse(this.Duree.Text); } catch (Exception) { }
            this.stud = this.Studio.Text;
            this.act = this.Acteurs.Text;

            //On indique que tout est bon puis on ferme
            this.DialogResult = DialogResult.OK;
            this.Hide();
            this.Dispose();
        }

        /// <summary>
        /// Quand on clique sur "Annuler" ou qu'on appuie sur Echap
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
