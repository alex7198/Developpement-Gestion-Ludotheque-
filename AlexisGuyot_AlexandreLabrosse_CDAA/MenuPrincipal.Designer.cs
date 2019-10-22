namespace AlexisGuyot_AlexandreLabrosse_CDAA
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.Layout_Général = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_Barre_Laterale = new System.Windows.Forms.Panel();
            this.Layout_Barre_Laterale = new System.Windows.Forms.TableLayoutPanel();
            this.Visualiser = new System.Windows.Forms.Button();
            this.Accueil = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.Button();
            this.Panel_Corps = new System.Windows.Forms.Panel();
            this.Layout_Corps = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_Pied = new System.Windows.Forms.Panel();
            this.Layout_Tri = new System.Windows.Forms.TableLayoutPanel();
            this.Layout_Boutons_Tri = new System.Windows.Forms.TableLayoutPanel();
            this.TriAlpha = new System.Windows.Forms.Button();
            this.TriChrono = new System.Windows.Forms.Button();
            this.Panel_Mediatheque = new System.Windows.Forms.Panel();
            this.Layout_Mediatheque = new System.Windows.Forms.TableLayoutPanel();
            this.ListeMedias = new System.Windows.Forms.ListView();
            this.Miniature = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Affichage = new System.Windows.Forms.RichTextBox();
            this.Panel_Boutons = new System.Windows.Forms.Panel();
            this.Layout_Boutons = new System.Windows.Forms.TableLayoutPanel();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Rechercher = new System.Windows.Forms.Button();
            this.Panel_Infos = new System.Windows.Forms.Panel();
            this.Layout_Infos = new System.Windows.Forms.TableLayoutPanel();
            this.NomMediatheque = new System.Windows.Forms.Label();
            this.Layout_Coordonnees = new System.Windows.Forms.TableLayoutPanel();
            this.Ville = new System.Windows.Forms.Label();
            this.Adresse = new System.Windows.Forms.Label();
            this.CodePostal = new System.Windows.Forms.Label();
            this.Layout_Général.SuspendLayout();
            this.Panel_Barre_Laterale.SuspendLayout();
            this.Layout_Barre_Laterale.SuspendLayout();
            this.Panel_Corps.SuspendLayout();
            this.Layout_Corps.SuspendLayout();
            this.Panel_Pied.SuspendLayout();
            this.Layout_Tri.SuspendLayout();
            this.Layout_Boutons_Tri.SuspendLayout();
            this.Panel_Mediatheque.SuspendLayout();
            this.Layout_Mediatheque.SuspendLayout();
            this.Panel_Boutons.SuspendLayout();
            this.Layout_Boutons.SuspendLayout();
            this.Panel_Infos.SuspendLayout();
            this.Layout_Infos.SuspendLayout();
            this.Layout_Coordonnees.SuspendLayout();
            this.SuspendLayout();
            // 
            // Layout_Général
            // 
            this.Layout_Général.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Layout_Général.ColumnCount = 2;
            this.Layout_Général.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Layout_Général.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.Layout_Général.Controls.Add(this.Panel_Barre_Laterale, 0, 0);
            this.Layout_Général.Controls.Add(this.Panel_Corps, 1, 0);
            this.Layout_Général.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_Général.Location = new System.Drawing.Point(0, 0);
            this.Layout_Général.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Layout_Général.Name = "Layout_Général";
            this.Layout_Général.RowCount = 1;
            this.Layout_Général.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout_Général.Size = new System.Drawing.Size(1369, 754);
            this.Layout_Général.TabIndex = 0;
            // 
            // Panel_Barre_Laterale
            // 
            this.Panel_Barre_Laterale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.Panel_Barre_Laterale.Controls.Add(this.Layout_Barre_Laterale);
            this.Panel_Barre_Laterale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Barre_Laterale.Location = new System.Drawing.Point(3, 4);
            this.Panel_Barre_Laterale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel_Barre_Laterale.Name = "Panel_Barre_Laterale";
            this.Panel_Barre_Laterale.Size = new System.Drawing.Size(199, 746);
            this.Panel_Barre_Laterale.TabIndex = 0;
            // 
            // Layout_Barre_Laterale
            // 
            this.Layout_Barre_Laterale.ColumnCount = 1;
            this.Layout_Barre_Laterale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout_Barre_Laterale.Controls.Add(this.Visualiser, 0, 2);
            this.Layout_Barre_Laterale.Controls.Add(this.Accueil, 0, 0);
            this.Layout_Barre_Laterale.Controls.Add(this.Options, 0, 1);
            this.Layout_Barre_Laterale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_Barre_Laterale.Location = new System.Drawing.Point(0, 0);
            this.Layout_Barre_Laterale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Layout_Barre_Laterale.Name = "Layout_Barre_Laterale";
            this.Layout_Barre_Laterale.RowCount = 4;
            this.Layout_Barre_Laterale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Layout_Barre_Laterale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Layout_Barre_Laterale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Layout_Barre_Laterale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Layout_Barre_Laterale.Size = new System.Drawing.Size(199, 746);
            this.Layout_Barre_Laterale.TabIndex = 0;
            // 
            // Visualiser
            // 
            this.Visualiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Visualiser.BackgroundImage = global::AlexisGuyot_AlexandreLabrosse_CDAA.Properties.Resources.visualiser;
            this.Visualiser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Visualiser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Visualiser.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.Visualiser.FlatAppearance.BorderSize = 5;
            this.Visualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Visualiser.Font = new System.Drawing.Font("Gill Sans MT Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visualiser.ForeColor = System.Drawing.SystemColors.Control;
            this.Visualiser.Location = new System.Drawing.Point(0, 372);
            this.Visualiser.Margin = new System.Windows.Forms.Padding(0);
            this.Visualiser.Name = "Visualiser";
            this.Visualiser.Size = new System.Drawing.Size(199, 186);
            this.Visualiser.TabIndex = 2;
            this.Visualiser.Text = "VISUALISER";
            this.Visualiser.UseVisualStyleBackColor = false;
            this.Visualiser.Click += new System.EventHandler(this.Visualiser_Click);
            // 
            // Accueil
            // 
            this.Accueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Accueil.BackgroundImage = global::AlexisGuyot_AlexandreLabrosse_CDAA.Properties.Resources.maison;
            this.Accueil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Accueil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Accueil.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.Accueil.FlatAppearance.BorderSize = 5;
            this.Accueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Accueil.Font = new System.Drawing.Font("Gill Sans MT Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accueil.ForeColor = System.Drawing.SystemColors.Control;
            this.Accueil.Location = new System.Drawing.Point(0, 0);
            this.Accueil.Margin = new System.Windows.Forms.Padding(0);
            this.Accueil.Name = "Accueil";
            this.Accueil.Size = new System.Drawing.Size(199, 186);
            this.Accueil.TabIndex = 0;
            this.Accueil.Text = "ACCUEIL";
            this.Accueil.UseVisualStyleBackColor = false;
            this.Accueil.Click += new System.EventHandler(this.Accueil_Click);
            // 
            // Options
            // 
            this.Options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Options.BackgroundImage = global::AlexisGuyot_AlexandreLabrosse_CDAA.Properties.Resources.options;
            this.Options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Options.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Options.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.Options.FlatAppearance.BorderSize = 5;
            this.Options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Options.Font = new System.Drawing.Font("Gill Sans MT Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Options.ForeColor = System.Drawing.SystemColors.Control;
            this.Options.Location = new System.Drawing.Point(0, 186);
            this.Options.Margin = new System.Windows.Forms.Padding(0);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(199, 186);
            this.Options.TabIndex = 1;
            this.Options.Text = "OPTIONS";
            this.Options.UseVisualStyleBackColor = false;
            this.Options.Click += new System.EventHandler(this.Options_Click);
            // 
            // Panel_Corps
            // 
            this.Panel_Corps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Panel_Corps.Controls.Add(this.Layout_Corps);
            this.Panel_Corps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Corps.Location = new System.Drawing.Point(208, 4);
            this.Panel_Corps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel_Corps.Name = "Panel_Corps";
            this.Panel_Corps.Size = new System.Drawing.Size(1158, 746);
            this.Panel_Corps.TabIndex = 1;
            // 
            // Layout_Corps
            // 
            this.Layout_Corps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Layout_Corps.ColumnCount = 1;
            this.Layout_Corps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout_Corps.Controls.Add(this.Panel_Pied, 0, 3);
            this.Layout_Corps.Controls.Add(this.Panel_Mediatheque, 0, 2);
            this.Layout_Corps.Controls.Add(this.Panel_Boutons, 0, 1);
            this.Layout_Corps.Controls.Add(this.Panel_Infos, 0, 0);
            this.Layout_Corps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_Corps.Location = new System.Drawing.Point(0, 0);
            this.Layout_Corps.Name = "Layout_Corps";
            this.Layout_Corps.RowCount = 4;
            this.Layout_Corps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.Layout_Corps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.Layout_Corps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.Layout_Corps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.Layout_Corps.Size = new System.Drawing.Size(1158, 746);
            this.Layout_Corps.TabIndex = 0;
            // 
            // Panel_Pied
            // 
            this.Panel_Pied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Panel_Pied.Controls.Add(this.Layout_Tri);
            this.Panel_Pied.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Pied.Location = new System.Drawing.Point(3, 677);
            this.Panel_Pied.Name = "Panel_Pied";
            this.Panel_Pied.Size = new System.Drawing.Size(1152, 66);
            this.Panel_Pied.TabIndex = 3;
            // 
            // Layout_Tri
            // 
            this.Layout_Tri.ColumnCount = 2;
            this.Layout_Tri.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.Layout_Tri.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.Layout_Tri.Controls.Add(this.Layout_Boutons_Tri, 0, 0);
            this.Layout_Tri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_Tri.Location = new System.Drawing.Point(0, 0);
            this.Layout_Tri.Name = "Layout_Tri";
            this.Layout_Tri.RowCount = 1;
            this.Layout_Tri.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout_Tri.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.Layout_Tri.Size = new System.Drawing.Size(1152, 66);
            this.Layout_Tri.TabIndex = 0;
            // 
            // Layout_Boutons_Tri
            // 
            this.Layout_Boutons_Tri.ColumnCount = 4;
            this.Layout_Boutons_Tri.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.Layout_Boutons_Tri.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Layout_Boutons_Tri.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Layout_Boutons_Tri.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Layout_Boutons_Tri.Controls.Add(this.TriAlpha, 1, 0);
            this.Layout_Boutons_Tri.Controls.Add(this.TriChrono, 3, 0);
            this.Layout_Boutons_Tri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_Boutons_Tri.Location = new System.Drawing.Point(3, 3);
            this.Layout_Boutons_Tri.Name = "Layout_Boutons_Tri";
            this.Layout_Boutons_Tri.RowCount = 1;
            this.Layout_Boutons_Tri.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout_Boutons_Tri.Size = new System.Drawing.Size(374, 60);
            this.Layout_Boutons_Tri.TabIndex = 0;
            // 
            // TriAlpha
            // 
            this.TriAlpha.BackColor = System.Drawing.Color.Transparent;
            this.TriAlpha.BackgroundImage = global::AlexisGuyot_AlexandreLabrosse_CDAA.Properties.Resources.trialpha;
            this.TriAlpha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TriAlpha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TriAlpha.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.TriAlpha.FlatAppearance.BorderSize = 5;
            this.TriAlpha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TriAlpha.Location = new System.Drawing.Point(219, 3);
            this.TriAlpha.Name = "TriAlpha";
            this.TriAlpha.Size = new System.Drawing.Size(68, 54);
            this.TriAlpha.TabIndex = 0;
            this.TriAlpha.UseVisualStyleBackColor = false;
            this.TriAlpha.Click += new System.EventHandler(this.button1_Click);
            // 
            // TriChrono
            // 
            this.TriChrono.BackgroundImage = global::AlexisGuyot_AlexandreLabrosse_CDAA.Properties.Resources.trichrono;
            this.TriChrono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TriChrono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TriChrono.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.TriChrono.FlatAppearance.BorderSize = 5;
            this.TriChrono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TriChrono.Location = new System.Drawing.Point(300, 3);
            this.TriChrono.Name = "TriChrono";
            this.TriChrono.Size = new System.Drawing.Size(71, 54);
            this.TriChrono.TabIndex = 1;
            this.TriChrono.UseVisualStyleBackColor = true;
            this.TriChrono.Click += new System.EventHandler(this.button2_Click);
            // 
            // Panel_Mediatheque
            // 
            this.Panel_Mediatheque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Panel_Mediatheque.Controls.Add(this.Layout_Mediatheque);
            this.Panel_Mediatheque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Mediatheque.Location = new System.Drawing.Point(3, 180);
            this.Panel_Mediatheque.Name = "Panel_Mediatheque";
            this.Panel_Mediatheque.Size = new System.Drawing.Size(1152, 491);
            this.Panel_Mediatheque.TabIndex = 2;
            // 
            // Layout_Mediatheque
            // 
            this.Layout_Mediatheque.ColumnCount = 2;
            this.Layout_Mediatheque.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.Layout_Mediatheque.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.Layout_Mediatheque.Controls.Add(this.ListeMedias, 0, 0);
            this.Layout_Mediatheque.Controls.Add(this.Affichage, 1, 0);
            this.Layout_Mediatheque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_Mediatheque.Location = new System.Drawing.Point(0, 0);
            this.Layout_Mediatheque.Name = "Layout_Mediatheque";
            this.Layout_Mediatheque.RowCount = 1;
            this.Layout_Mediatheque.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout_Mediatheque.Size = new System.Drawing.Size(1152, 491);
            this.Layout_Mediatheque.TabIndex = 0;
            // 
            // ListeMedias
            // 
            this.ListeMedias.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.ListeMedias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ListeMedias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Miniature,
            this.ID,
            this.Nom});
            this.ListeMedias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeMedias.ForeColor = System.Drawing.SystemColors.Window;
            this.ListeMedias.GridLines = true;
            this.ListeMedias.Location = new System.Drawing.Point(3, 3);
            this.ListeMedias.MultiSelect = false;
            this.ListeMedias.Name = "ListeMedias";
            this.ListeMedias.Size = new System.Drawing.Size(374, 485);
            this.ListeMedias.TabIndex = 0;
            this.ListeMedias.UseCompatibleStateImageBehavior = false;
            this.ListeMedias.SelectedIndexChanged += new System.EventHandler(this.ListeMedias_SelectedIndexChanged);
            // 
            // Miniature
            // 
            this.Miniature.Text = "Miniature";
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            // 
            // Affichage
            // 
            this.Affichage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Affichage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Affichage.ForeColor = System.Drawing.SystemColors.Window;
            this.Affichage.Location = new System.Drawing.Point(383, 3);
            this.Affichage.Name = "Affichage";
            this.Affichage.ReadOnly = true;
            this.Affichage.Size = new System.Drawing.Size(766, 485);
            this.Affichage.TabIndex = 1;
            this.Affichage.Text = "";
            // 
            // Panel_Boutons
            // 
            this.Panel_Boutons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Panel_Boutons.Controls.Add(this.Layout_Boutons);
            this.Panel_Boutons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Boutons.Location = new System.Drawing.Point(3, 109);
            this.Panel_Boutons.Name = "Panel_Boutons";
            this.Panel_Boutons.Size = new System.Drawing.Size(1152, 65);
            this.Panel_Boutons.TabIndex = 1;
            // 
            // Layout_Boutons
            // 
            this.Layout_Boutons.ColumnCount = 4;
            this.Layout_Boutons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Layout_Boutons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Layout_Boutons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Layout_Boutons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Layout_Boutons.Controls.Add(this.Supprimer, 3, 0);
            this.Layout_Boutons.Controls.Add(this.Modifier, 2, 0);
            this.Layout_Boutons.Controls.Add(this.Ajouter, 1, 0);
            this.Layout_Boutons.Controls.Add(this.Rechercher, 0, 0);
            this.Layout_Boutons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_Boutons.Location = new System.Drawing.Point(0, 0);
            this.Layout_Boutons.Name = "Layout_Boutons";
            this.Layout_Boutons.RowCount = 1;
            this.Layout_Boutons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout_Boutons.Size = new System.Drawing.Size(1152, 65);
            this.Layout_Boutons.TabIndex = 0;
            // 
            // Supprimer
            // 
            this.Supprimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Supprimer.Enabled = false;
            this.Supprimer.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.Supprimer.FlatAppearance.BorderSize = 5;
            this.Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Supprimer.Font = new System.Drawing.Font("Gill Sans MT Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supprimer.ForeColor = System.Drawing.Color.DarkViolet;
            this.Supprimer.Location = new System.Drawing.Point(867, 3);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(282, 59);
            this.Supprimer.TabIndex = 3;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Modifier
            // 
            this.Modifier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Modifier.Enabled = false;
            this.Modifier.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.Modifier.FlatAppearance.BorderSize = 5;
            this.Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modifier.Font = new System.Drawing.Font("Gill Sans MT Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.ForeColor = System.Drawing.Color.DarkViolet;
            this.Modifier.Location = new System.Drawing.Point(579, 3);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(282, 59);
            this.Modifier.TabIndex = 2;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ajouter.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.Ajouter.FlatAppearance.BorderSize = 5;
            this.Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajouter.Font = new System.Drawing.Font("Gill Sans MT Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.ForeColor = System.Drawing.Color.DarkViolet;
            this.Ajouter.Location = new System.Drawing.Point(291, 3);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(282, 59);
            this.Ajouter.TabIndex = 1;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Rechercher
            // 
            this.Rechercher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rechercher.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.Rechercher.FlatAppearance.BorderSize = 5;
            this.Rechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rechercher.Font = new System.Drawing.Font("Gill Sans MT Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rechercher.ForeColor = System.Drawing.Color.DarkViolet;
            this.Rechercher.Location = new System.Drawing.Point(3, 3);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(282, 59);
            this.Rechercher.TabIndex = 0;
            this.Rechercher.Text = "Rechercher";
            this.Rechercher.UseVisualStyleBackColor = true;
            this.Rechercher.Click += new System.EventHandler(this.Rechercher_Click);
            // 
            // Panel_Infos
            // 
            this.Panel_Infos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Panel_Infos.Controls.Add(this.Layout_Infos);
            this.Panel_Infos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Infos.Location = new System.Drawing.Point(3, 3);
            this.Panel_Infos.Name = "Panel_Infos";
            this.Panel_Infos.Size = new System.Drawing.Size(1152, 100);
            this.Panel_Infos.TabIndex = 0;
            // 
            // Layout_Infos
            // 
            this.Layout_Infos.ColumnCount = 2;
            this.Layout_Infos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Layout_Infos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Layout_Infos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Layout_Infos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Layout_Infos.Controls.Add(this.NomMediatheque, 0, 0);
            this.Layout_Infos.Controls.Add(this.Layout_Coordonnees, 1, 0);
            this.Layout_Infos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_Infos.Location = new System.Drawing.Point(0, 0);
            this.Layout_Infos.Name = "Layout_Infos";
            this.Layout_Infos.RowCount = 1;
            this.Layout_Infos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout_Infos.Size = new System.Drawing.Size(1152, 100);
            this.Layout_Infos.TabIndex = 0;
            // 
            // NomMediatheque
            // 
            this.NomMediatheque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NomMediatheque.AutoSize = true;
            this.NomMediatheque.Font = new System.Drawing.Font("Gill Sans MT Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomMediatheque.ForeColor = System.Drawing.Color.DarkViolet;
            this.NomMediatheque.Location = new System.Drawing.Point(0, 0);
            this.NomMediatheque.Margin = new System.Windows.Forms.Padding(0);
            this.NomMediatheque.Name = "NomMediatheque";
            this.NomMediatheque.Size = new System.Drawing.Size(616, 100);
            this.NomMediatheque.TabIndex = 1;
            this.NomMediatheque.Text = "NOM MEDIATHEQUE";
            this.NomMediatheque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Layout_Coordonnees
            // 
            this.Layout_Coordonnees.ColumnCount = 1;
            this.Layout_Coordonnees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout_Coordonnees.Controls.Add(this.Ville, 0, 2);
            this.Layout_Coordonnees.Controls.Add(this.Adresse, 0, 0);
            this.Layout_Coordonnees.Controls.Add(this.CodePostal, 0, 1);
            this.Layout_Coordonnees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_Coordonnees.Location = new System.Drawing.Point(619, 3);
            this.Layout_Coordonnees.Name = "Layout_Coordonnees";
            this.Layout_Coordonnees.RowCount = 3;
            this.Layout_Coordonnees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Layout_Coordonnees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Layout_Coordonnees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Layout_Coordonnees.Size = new System.Drawing.Size(530, 94);
            this.Layout_Coordonnees.TabIndex = 2;
            // 
            // Ville
            // 
            this.Ville.AutoEllipsis = true;
            this.Ville.AutoSize = true;
            this.Ville.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ville.Font = new System.Drawing.Font("Gill Sans MT Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ville.ForeColor = System.Drawing.Color.DarkViolet;
            this.Ville.Location = new System.Drawing.Point(3, 62);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(524, 32);
            this.Ville.TabIndex = 5;
            this.Ville.Text = "VILLE";
            // 
            // Adresse
            // 
            this.Adresse.AutoEllipsis = true;
            this.Adresse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Adresse.Font = new System.Drawing.Font("Gill Sans MT Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adresse.ForeColor = System.Drawing.Color.DarkViolet;
            this.Adresse.Location = new System.Drawing.Point(3, 0);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(524, 31);
            this.Adresse.TabIndex = 3;
            this.Adresse.Text = "ADRESSE";
            this.Adresse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CodePostal
            // 
            this.CodePostal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodePostal.Font = new System.Drawing.Font("Gill Sans MT Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodePostal.ForeColor = System.Drawing.Color.DarkViolet;
            this.CodePostal.Location = new System.Drawing.Point(3, 31);
            this.CodePostal.Name = "CodePostal";
            this.CodePostal.Size = new System.Drawing.Size(524, 31);
            this.CodePostal.TabIndex = 4;
            this.CodePostal.Text = "CODE POSTAL";
            this.CodePostal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1369, 754);
            this.Controls.Add(this.Layout_Général);
            this.Font = new System.Drawing.Font("Gill Sans MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MenuPrincipal";
            this.Text = "Médiathèque - Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Layout_Général.ResumeLayout(false);
            this.Panel_Barre_Laterale.ResumeLayout(false);
            this.Layout_Barre_Laterale.ResumeLayout(false);
            this.Panel_Corps.ResumeLayout(false);
            this.Layout_Corps.ResumeLayout(false);
            this.Panel_Pied.ResumeLayout(false);
            this.Layout_Tri.ResumeLayout(false);
            this.Layout_Boutons_Tri.ResumeLayout(false);
            this.Panel_Mediatheque.ResumeLayout(false);
            this.Layout_Mediatheque.ResumeLayout(false);
            this.Panel_Boutons.ResumeLayout(false);
            this.Layout_Boutons.ResumeLayout(false);
            this.Panel_Infos.ResumeLayout(false);
            this.Layout_Infos.ResumeLayout(false);
            this.Layout_Infos.PerformLayout();
            this.Layout_Coordonnees.ResumeLayout(false);
            this.Layout_Coordonnees.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Layout_Général;
        private System.Windows.Forms.Panel Panel_Barre_Laterale;
        private System.Windows.Forms.Panel Panel_Corps;
        private System.Windows.Forms.TableLayoutPanel Layout_Barre_Laterale;
        private System.Windows.Forms.Button Accueil;
        private System.Windows.Forms.Button Options;
        private System.Windows.Forms.TableLayoutPanel Layout_Corps;
        private System.Windows.Forms.Panel Panel_Mediatheque;
        private System.Windows.Forms.Panel Panel_Boutons;
        private System.Windows.Forms.Panel Panel_Infos;
        private System.Windows.Forms.TableLayoutPanel Layout_Mediatheque;
        private System.Windows.Forms.TableLayoutPanel Layout_Boutons;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Rechercher;
        private System.Windows.Forms.ListView ListeMedias;
        private System.Windows.Forms.RichTextBox Affichage;
        private System.Windows.Forms.TableLayoutPanel Layout_Infos;
        private System.Windows.Forms.TableLayoutPanel Layout_Coordonnees;
        private System.Windows.Forms.Label Ville;
        private System.Windows.Forms.Label Adresse;
        private System.Windows.Forms.Label CodePostal;
        private System.Windows.Forms.ColumnHeader Miniature;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.Panel Panel_Pied;
        private System.Windows.Forms.Label NomMediatheque;
        private System.Windows.Forms.Button Visualiser;
        private System.Windows.Forms.TableLayoutPanel Layout_Tri;
        private System.Windows.Forms.TableLayoutPanel Layout_Boutons_Tri;
        private System.Windows.Forms.Button TriAlpha;
        private System.Windows.Forms.Button TriChrono;
    }
}