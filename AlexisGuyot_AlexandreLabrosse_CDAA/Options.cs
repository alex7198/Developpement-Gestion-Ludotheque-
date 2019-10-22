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
    public partial class Options : Form
    {
        //Attributs de la médiathèque
        private string nom;
        private string adresse;
        private int codePostal;
        private string ville;

        //Propriétés
        public string _Nom { get { return nom; } }
        public string _Adresse { get { return adresse; } }
        public int _CodePostal { get { return codePostal; } }
        public string _Ville { get { return ville; } }

        /// <summary>
        /// Initialise et crée la fenêtre
        /// </summary>
        /// <param name="n">Nom de la médiathèque</param>
        /// <param name="a">Adresse de la médiathèque</param>
        /// <param name="c">Code Postal de la médiathèque</param>
        /// <param name="v">Ville de la médiathèque</param>
        public Options(string n, string a, int c, string v)
        {
            InitializeComponent();
            this.nom = n;
            this.adresse = a;
            this.codePostal = c;
            this.ville = v;
            this.InitFormulaire();
        }

        /// <summary>
        /// Initialise les champs du formulaire
        /// </summary>
        private void InitFormulaire()
        {
            this.Nom.Text = this.nom;
            this.Adresse.Text = this.adresse;
            this.Ville.Text = this.ville;
            this.CodePostal.Text = this.codePostal.ToString();
            while (this.CodePostal.Text.Length < 5) this.CodePostal.Text = "0" + this.CodePostal.Text;
        }

        /// <summary>
        /// Quand l'utilisateur clique sur "Valider" ou appuie sur la touche Entrée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Valider_Click(object sender, EventArgs e)
        {
            //On récupère les données du formulaire
            this.nom = this.Nom.Text;
            this.adresse = this.Adresse.Text;
            this.ville = this.Ville.Text;
            try { codePostal = Int32.Parse(this.CodePostal.Text); } catch (Exception) { }

            //On valide puis on ferme
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
