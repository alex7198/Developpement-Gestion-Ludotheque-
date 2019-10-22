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
    public partial class MenuPrincipal : Form
    {
        Mediatheque mediatheque;        //Médiathèque manipulée par l'application
        LesMedias listeAffichée;        //Liste affichée dans la ListView

        /// <summary>
        /// Initialisation et création de la fenêtre
        /// </summary>
        /// <param name="m">Médiathèque manipulée par l'application</param>
        public MenuPrincipal(Mediatheque m)
        {
            this.mediatheque = m;
            this.listeAffichée = this.mediatheque.Medias;
            InitializeComponent();
            this.InitInfos();
            this.InitContenu();
            this.initListe();
        }

        #region Initialisation de la médiathèque avec quelques valeurs
        /// <summary>
        /// Ajoute quelques médias à la médiathèque pour pouvoir tester les différentes fonctionnalités
        /// </summary>
        private void InitContenu()
        {
            //Création des livres
            Media m = new Livre("1", "Les Miserables", "Aventures de Jean Valjean, Cosette, Fantine, Gravroche et compagnie", "Roman", new DateTime(1862, 1, 1), "Victor Hugo", 2000, "Albert Lacroix et cie");
            Media m2 = new Livre("2", "La Peste", "L’histoire se déroule dans les années 1940. Elle a pour théâtre Oran durant la période de l’Algérie française. Le roman raconte sous forme de chronique la vie quotidienne des habitants pendant une épidémie de peste qui frappe la ville et la coupe du monde extérieur.", "Roman", new DateTime(1947, 6, 1), "Albert Camus", 279, "Gallimard");
            Media m3 = new Livre("3", "Candide", "Récit de formation spirituelle du jeune Candide.", "Philosophie", new DateTime(1759, 1, 1), "Voltaire", 128, "Gabriel Cramer");
            Media m4 = new Livre("4", "Programmation Objet en Langage C++", "Cours, conseils et exemples pour apprendre à coder en objet avec C++ dans la bonne humeur", "Roman", new DateTime(2008, 1, 22), "Alexandre Guidet", 364, "Ellipses Marketing");

            //Création des films
            Media m5 = new Film("5", "Inception", "Leonardo Di Caprio interprète un « extracteur », un voleur qui subtilise des informations sensibles dans un contexte d'espionnage industriel en infiltrant le subconscient de ses cibles au cours d'un « rêve partagé ». Alors qu'il est recherché par la police américaine, on lui offre une chance de retrouver son ancienne vie en échange d'un travail considéré comme impossible : l'« inception ». À l'inverse de l’extraction, il s'agit de l'implantation d'une idée étrangère dans le subconscient d'un sujet qui la considérera à son réveil comme étant l'une des siennes.", Genres.ScienceFiction, new DateTime(2010, 7, 16), 148, "Christopher Nolan", "Christopher Nolan", "Warner Bros", "Leonardo Di Caprio,Ellen Page,Ken Watanabe,Joseph Gordon-Levitt,Marion Cotillard");
            Media m6 = new Film("6", "RRRrrrr!!!", "Première enquête policière de l'histoire, à l'âge de Pierre.", Genres.Comédie, new DateTime(2004, 1, 28), 148, "Alain Chabat", "Alain Chabat", "Studio Canal", "Alain Chabat,Jean-Paul Rouve,Gerard Depardieu,Pierre-François Martin-Laval");
            Media m7 = new Film("7", "La cité de la peur", "Prenez un chewing-gum Emile", Genres.Comédie, new DateTime(1994, 3, 9), 93, "Alain Berbérian", "Les Nuls", "AMLF", "Alain Chabat,Chantal Lauby,Dominique Farrugia,Gérard Darmon");
            Media m8 = new Film("8", "Le Roi Lion", "Le film raconte le périple de Simba, jeune lion promis à régner un jour sur la savanne", Genres.Animation, new DateTime(1995, 10, 10), 89, "Roger Allers", "Irene Mecchi", "Walt Disney Pictures", "Simba,Timon,Pumbaa,Zazu,Nala,Mufasa,Scar");

            //Ajout des miniatures
            m.Miniature = Image.FromFile("../../Resources/les-miserables.jpg");
            m2.Miniature = Image.FromFile("../../Resources/la-peste.jpg");
            m3.Miniature = Image.FromFile("../../Resources/candide.jpg");
            m4.Miniature = Image.FromFile("../../Resources/langage.jpg");
            m5.Miniature = Image.FromFile("../../Resources/inception.jpg");
            m6.Miniature = Image.FromFile("../../Resources/rrrrrrr.jpg");
            m7.Miniature = Image.FromFile("../../Resources/la-cite-de-la-peur.jpg");
            m8.Miniature = Image.FromFile("../../Resources/roi-lion.jpg");

            //Ajout des médias à la liste
            mediatheque.Medias.Ajout(m);
            mediatheque.Medias.Ajout(m2);
            mediatheque.Medias.Ajout(m3);
            mediatheque.Medias.Ajout(m4);
            mediatheque.Medias.Ajout(m5);
            mediatheque.Medias.Ajout(m6);
            mediatheque.Medias.Ajout(m7);
            mediatheque.Medias.Ajout(m8);
        }
        #endregion

        /// <summary>
        /// Initialise les informations de l'en-tête
        /// </summary>
        private void InitInfos()
        {
            this.NomMediatheque.Text = this.mediatheque.Nom.ToUpper();
            this.Adresse.Text = this.mediatheque.Adresse.ToUpper();
            string codePostal = this.mediatheque.CodePostal.ToString();
            while (codePostal.Length < 5) codePostal = "0" + codePostal;
            this.CodePostal.Text = codePostal;
            this.Ville.Text = this.mediatheque.Ville.ToUpper();
        }

        /// <summary>
        /// Initialise l'affichage de la liste des médias présents dans la médiathèque
        /// </summary>
        private void initListe()
        {
            this.ListeMedias.LargeImageList = new ImageList();
            this.ListeMedias.Items.Clear();
            this.ListeMedias.LargeImageList.ImageSize = new Size(177,256);  //Taille des images

            int i = 0;
            foreach(Media m in this.listeAffichée.Medias)
            {
                this.ListeMedias.Items.Add(m.ToStringMin());                //Texte de légende
                this.ListeMedias.LargeImageList.Images.Add(m.Miniature);    //Affiche / Couverture
                this.ListeMedias.Items[i].ImageIndex = i;                   //Lien entre les deux
                i++;
            }
        }

        /// <summary>
        /// Quand l'utilisateur clique sur un média de la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListeMedias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Media media = this.RecupererMediaSelectionne();
            //Si un média est sélectionné
            if (media != null)
            {
                //On affiche sa description complète
                this.Affichage.Text = media.ToString();
                     
                //On active les boutons modifier et supprimer
                this.Modifier.Enabled = true;
                this.Supprimer.Enabled = true;
            }
            //Sinon
            else
            {
                //On désactive les boutons
                this.Affichage.Text = "";
                this.Modifier.Enabled = false;
                this.Supprimer.Enabled = false;
            }
        }

        /// <summary>
        /// Quand l'utilisateur clique sur le bouton accueil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Accueil_Click(object sender, EventArgs e)
        {
            //On réinitialise l'interface
            this.Modifier.Enabled = false;
            this.Supprimer.Enabled = false;
            this.Affichage.Text = "";
            this.listeAffichée = this.mediatheque.Medias;
            this.initListe();
        }

        /// <summary>
        /// Quand l'utilisateur clique sur le bouton "Options"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Options_Click(object sender, EventArgs e)
        {
            //On modifie les options de la médiathèque
            Options opt = new Options(this.mediatheque.Nom, this.mediatheque.Adresse, this.mediatheque.CodePostal, this.mediatheque.Ville);
            if(opt.ShowDialog() == DialogResult.OK)
            {
                this.mediatheque.Nom = opt._Nom;
                this.mediatheque.Adresse = opt._Adresse;
                this.mediatheque.CodePostal = opt._CodePostal;
                this.mediatheque.Ville = opt._Ville;
                this.InitInfos();
            }
        }

        /// <summary>
        /// Quand l'utilisateur clique sur le bouton "Rechercher"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rechercher_Click(object sender, EventArgs e)
        {
            RechercherMedia rech = new RechercherMedia(this.mediatheque);
            if(rech.ShowDialog() == DialogResult.OK)
            {
                this.listeAffichée = rech.Resultat;
                this.initListe();

                this.Affichage.Text = "";
                if (rech.Resultat.Medias.Count == 0) this.Affichage.Text = "Aucun résultat trouvé.\n";
                this.Affichage.Text += "Appuyez sur la touche Accueil pour ré-afficher le contenu de la médiathèque";
            }
        }

        /// <summary>
        /// Quand l'utilisateur appuie sur le bouton "Ajouter"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ajouter_Click(object sender, EventArgs e)
        {
            AjoutFilm ajout = new AjoutFilm(this.mediatheque);
            ajout.ShowDialog();
            this.initListe();
        }

        /// <summary>
        /// Quand l'utilisateur appuie sur le bouton "Modifier"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Modifier_Click(object sender, EventArgs e)
        {
            ModifierMedia modif = new ModifierMedia(this.RecupererMediaSelectionne());
            modif.ShowDialog();
            this.initListe();
            this.Affichage.Text = "";
        }

        /// <summary>
        /// Quand l'utilisateur appuie sur le bouton "Supprimer"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Supprimer_Click(object sender, EventArgs e)
        {
            //On supprime le média de la liste
            Media media = this.RecupererMediaSelectionne();
            this.mediatheque.Medias.Supprimer(media.Reference);
            this.initListe();
        }

        private Media RecupererMediaSelectionne()
        {
            Media media = null;
            //On récupère les items sélectionnés (en pratique un seul à chaque fois)
            ListView.SelectedListViewItemCollection selec = this.ListeMedias.SelectedItems;

            foreach (ListViewItem item in selec)
            {
                string ID = item.Text.Split(' ')[0];                    //On récupère la référence du média
                media = this.mediatheque.Medias.RechercheRef(ID);       //On recherche dans la liste le média associé
            }

            return media;
        }

        /// <summary>
        /// Quand l'utilisateur clique sur le bouton de tri alphabétique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.listeAffichée.TriAlphabetique();
            this.initListe();
        }

        /// <summary>
        /// Quand l'utilisateur clique sur le bouton de tri chronologique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.listeAffichée.TriChronologique();
            this.initListe();
        }

        /// <summary>
        /// Quand l'utilisateur clique sur le bouton "Visualiser"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Visualiser_Click(object sender, EventArgs e)
        {
            VisualiserMediatheque visu = new VisualiserMediatheque(this.mediatheque);
            visu.ShowDialog();
        }
    }
}
