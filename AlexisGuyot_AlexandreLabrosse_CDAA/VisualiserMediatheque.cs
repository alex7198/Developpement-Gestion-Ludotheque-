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
    public partial class VisualiserMediatheque : Form
    {
        private Mediatheque mediatheque;

        public VisualiserMediatheque(Mediatheque m)
        {
            this.mediatheque = m;
            InitializeComponent();
            this.MiniatureMedia.SizeMode = PictureBoxSizeMode.Zoom;
            this.InitArbre();
        }

        /// <summary>
        /// Initialise l'arbe de visualisation
        /// </summary>
        private void InitArbre()
        {
            //Pour chaque genre
            foreach(Genres g in Enum.GetValues(typeof(Genres)))
            {
                //On crée un nouveau noeud
                TreeNode crt = new TreeNode(g.ToString());
                crt.ForeColor = Color.DarkViolet;

                //On récupère la liste des médias qui possèdent ce genre
                LesMedias liste = this.mediatheque.Medias.GetMediaGenre(g);

                //On ajoute chaque média dans le noeud courant
                foreach(Media m in liste.Medias)
                {
                    TreeNode tn = new TreeNode(m.ToStringMin());
                    tn.Name = m.Reference;
                    crt.Nodes.Add(tn);
                }

                //On ajoute le noeud à l'arbre
                this.Arbre.Nodes.Add(crt);
            }
        }

        /// <summary>
        /// Quand l'utilisateur sélectionne un noeud
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Arbre_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //On récupère le média associé au noeud
            Media selec = this.mediatheque.Medias.RechercheRef(e.Node.Name);

            //Si un média est associé, on modifie la partie Affichage
            if (selec != null)
            {
                this.Affichage.Text = selec.ToString();
                this.MiniatureMedia.Image = selec.Miniature;
                this.TitreMedia.Text = selec.Titre.ToUpper();
            }
            //Sinon on nettoie toute la partie Affichage
            else {
                this.Affichage.Text = "";
                this.MiniatureMedia.Image = null;
                this.TitreMedia.Text = "";
            };
        }
    }
}
