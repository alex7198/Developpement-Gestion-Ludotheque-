namespace AlexisGuyot_AlexandreLabrosse_CDAA
{
    partial class AjoutFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutFilm));
            this.Layout_Général = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_Pied = new System.Windows.Forms.Panel();
            this.Panel_Corps = new System.Windows.Forms.Panel();
            this.Layout_Corps = new System.Windows.Forms.TableLayoutPanel();
            this.Layout_TitreRef = new System.Windows.Forms.TableLayoutPanel();
            this.Titre = new System.Windows.Forms.TextBox();
            this.Label_Titre = new System.Windows.Forms.Label();
            this.Label_Reference = new System.Windows.Forms.Label();
            this.Reference = new System.Windows.Forms.TextBox();
            this.Layout_GenreDate = new System.Windows.Forms.TableLayoutPanel();
            this.Label_Genre = new System.Windows.Forms.Label();
            this.Label_Date = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.ComboBox();
            this.Layout_Date = new System.Windows.Forms.TableLayoutPanel();
            this.Annee = new System.Windows.Forms.TextBox();
            this.Mois = new System.Windows.Forms.TextBox();
            this.Jour = new System.Windows.Forms.TextBox();
            this.Layout_Description = new System.Windows.Forms.TableLayoutPanel();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Label_Acteurs = new System.Windows.Forms.Label();
            this.Layout_Boutons = new System.Windows.Forms.TableLayoutPanel();
            this.Annuler = new System.Windows.Forms.Button();
            this.Valider = new System.Windows.Forms.Button();
            this.Layout_Type = new System.Windows.Forms.TableLayoutPanel();
            this.Label_Type = new System.Windows.Forms.Label();
            this.Layout_LivreFilm = new System.Windows.Forms.TableLayoutPanel();
            this.Film = new System.Windows.Forms.RadioButton();
            this.Livre = new System.Windows.Forms.RadioButton();
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.TitreFenetre = new System.Windows.Forms.Label();
            this.Layout_Général.SuspendLayout();
            this.Panel_Corps.SuspendLayout();
            this.Layout_Corps.SuspendLayout();
            this.Layout_TitreRef.SuspendLayout();
            this.Layout_GenreDate.SuspendLayout();
            this.Layout_Date.SuspendLayout();
            this.Layout_Description.SuspendLayout();
            this.Layout_Boutons.SuspendLayout();
            this.Layout_Type.SuspendLayout();
            this.Layout_LivreFilm.SuspendLayout();
            this.Panel_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Layout_Général
            // 
            this.Layout_Général.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Layout_Général.ColumnCount = 1;
            this.Layout_Général.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout_Général.Controls.Add(this.Panel_Pied, 0, 2);
            this.Layout_Général.Controls.Add(this.Panel_Corps, 0, 1);
            this.Layout_Général.Controls.Add(this.Panel_Header, 0, 0);
            this.Layout_Général.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_Général.Location = new System.Drawing.Point(0, 0);
            this.Layout_Général.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Layout_Général.Name = "Layout_Général";
            this.Layout_Général.RowCount = 3;
            this.Layout_Général.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Layout_Général.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.Layout_Général.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Layout_Général.Size = new System.Drawing.Size(898, 822);
            this.Layout_Général.TabIndex = 0;
            // 
            // Panel_Pied
            // 
            this.Panel_Pied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Panel_Pied.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Pied.Location = new System.Drawing.Point(3, 702);
            this.Panel_Pied.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel_Pied.Name = "Panel_Pied";
            this.Panel_Pied.Size = new System.Drawing.Size(892, 116);
            this.Panel_Pied.TabIndex = 2;
            // 
            // Panel_Corps
            // 
            this.Panel_Corps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Panel_Corps.Controls.Add(this.Layout_Corps);
            this.Panel_Corps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Corps.Location = new System.Drawing.Point(3, 127);
            this.Panel_Corps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel_Corps.Name = "Panel_Corps";
            this.Panel_Corps.Size = new System.Drawing.Size(892, 567);
            this.Panel_Corps.TabIndex = 1;
            // 
            // Layout_Corps
            // 
            this.Layout_Corps.ColumnCount = 1;
            this.Layout_Corps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout_Corps.Controls.Add(this.Layout_TitreRef, 0, 0);
            this.Layout_Corps.Controls.Add(this.Layout_GenreDate, 0, 1);
            this.Layout_Corps.Controls.Add(this.Layout_Description, 0, 2);
            this.Layout_Corps.Controls.Add(this.Layout_Boutons, 0, 4);
            this.Layout_Corps.Controls.Add(this.Layout_Type, 0, 3);
            this.Layout_Corps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_Corps.Location = new System.Drawing.Point(0, 0);
            this.Layout_Corps.Name = "Layout_Corps";
            this.Layout_Corps.RowCount = 5;
            this.Layout_Corps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Layout_Corps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Layout_Corps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.Layout_Corps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Layout_Corps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Layout_Corps.Size = new System.Drawing.Size(892, 567);
            this.Layout_Corps.TabIndex = 0;
            // 
            // Layout_TitreRef
            // 
            this.Layout_TitreRef.ColumnCount = 2;
            this.Layout_TitreRef.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Layout_TitreRef.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Layout_TitreRef.Controls.Add(this.Titre, 1, 1);
            this.Layout_TitreRef.Controls.Add(this.Label_Titre, 1, 0);
            this.Layout_TitreRef.Controls.Add(this.Label_Reference, 0, 0);
            this.Layout_TitreRef.Controls.Add(this.Reference, 0, 1);
            this.Layout_TitreRef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_TitreRef.Location = new System.Drawing.Point(3, 3);
            this.Layout_TitreRef.Name = "Layout_TitreRef";
            this.Layout_TitreRef.RowCount = 2;
            this.Layout_TitreRef.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Layout_TitreRef.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Layout_TitreRef.Size = new System.Drawing.Size(886, 79);
            this.Layout_TitreRef.TabIndex = 0;
            // 
            // Titre
            // 
            this.Titre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Titre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Titre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Titre.Location = new System.Drawing.Point(446, 42);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(437, 29);
            this.Titre.TabIndex = 1;
            // 
            // Label_Titre
            // 
            this.Label_Titre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Titre.ForeColor = System.Drawing.SystemColors.Control;
            this.Label_Titre.Location = new System.Drawing.Point(446, 0);
            this.Label_Titre.Name = "Label_Titre";
            this.Label_Titre.Size = new System.Drawing.Size(437, 39);
            this.Label_Titre.TabIndex = 4;
            this.Label_Titre.Text = "Titre";
            this.Label_Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Reference
            // 
            this.Label_Reference.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Reference.ForeColor = System.Drawing.SystemColors.Control;
            this.Label_Reference.Location = new System.Drawing.Point(3, 0);
            this.Label_Reference.Name = "Label_Reference";
            this.Label_Reference.Size = new System.Drawing.Size(437, 39);
            this.Label_Reference.TabIndex = 3;
            this.Label_Reference.Text = "Référence";
            this.Label_Reference.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Reference
            // 
            this.Reference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Reference.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Reference.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Reference.Location = new System.Drawing.Point(3, 42);
            this.Reference.Name = "Reference";
            this.Reference.Size = new System.Drawing.Size(437, 29);
            this.Reference.TabIndex = 0;
            // 
            // Layout_GenreDate
            // 
            this.Layout_GenreDate.ColumnCount = 2;
            this.Layout_GenreDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Layout_GenreDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Layout_GenreDate.Controls.Add(this.Label_Genre, 1, 0);
            this.Layout_GenreDate.Controls.Add(this.Label_Date, 0, 0);
            this.Layout_GenreDate.Controls.Add(this.Genre, 1, 1);
            this.Layout_GenreDate.Controls.Add(this.Layout_Date, 0, 1);
            this.Layout_GenreDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_GenreDate.Location = new System.Drawing.Point(3, 88);
            this.Layout_GenreDate.Name = "Layout_GenreDate";
            this.Layout_GenreDate.RowCount = 2;
            this.Layout_GenreDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Layout_GenreDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Layout_GenreDate.Size = new System.Drawing.Size(886, 79);
            this.Layout_GenreDate.TabIndex = 1;
            // 
            // Label_Genre
            // 
            this.Label_Genre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Genre.ForeColor = System.Drawing.SystemColors.Control;
            this.Label_Genre.Location = new System.Drawing.Point(446, 0);
            this.Label_Genre.Name = "Label_Genre";
            this.Label_Genre.Size = new System.Drawing.Size(437, 39);
            this.Label_Genre.TabIndex = 3;
            this.Label_Genre.Text = "Genre";
            this.Label_Genre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Date
            // 
            this.Label_Date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Date.ForeColor = System.Drawing.SystemColors.Control;
            this.Label_Date.Location = new System.Drawing.Point(3, 0);
            this.Label_Date.Name = "Label_Date";
            this.Label_Date.Size = new System.Drawing.Size(437, 39);
            this.Label_Date.TabIndex = 2;
            this.Label_Date.Text = "Date de publication (jour - mois - année)";
            this.Label_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Genre
            // 
            this.Genre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Genre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Genre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Genre.FormattingEnabled = true;
            this.Genre.Location = new System.Drawing.Point(446, 42);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(437, 37);
            this.Genre.TabIndex = 5;
            // 
            // Layout_Date
            // 
            this.Layout_Date.ColumnCount = 3;
            this.Layout_Date.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Layout_Date.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Layout_Date.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Layout_Date.Controls.Add(this.Annee, 0, 0);
            this.Layout_Date.Controls.Add(this.Mois, 0, 0);
            this.Layout_Date.Controls.Add(this.Jour, 0, 0);
            this.Layout_Date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_Date.Location = new System.Drawing.Point(3, 42);
            this.Layout_Date.Name = "Layout_Date";
            this.Layout_Date.RowCount = 1;
            this.Layout_Date.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout_Date.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.Layout_Date.Size = new System.Drawing.Size(437, 34);
            this.Layout_Date.TabIndex = 5;
            // 
            // Annee
            // 
            this.Annee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Annee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Annee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Annee.Location = new System.Drawing.Point(293, 3);
            this.Annee.Name = "Annee";
            this.Annee.Size = new System.Drawing.Size(141, 29);
            this.Annee.TabIndex = 4;
            // 
            // Mois
            // 
            this.Mois.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Mois.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mois.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mois.Location = new System.Drawing.Point(148, 3);
            this.Mois.Name = "Mois";
            this.Mois.Size = new System.Drawing.Size(139, 29);
            this.Mois.TabIndex = 3;
            // 
            // Jour
            // 
            this.Jour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Jour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Jour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Jour.Location = new System.Drawing.Point(3, 3);
            this.Jour.Name = "Jour";
            this.Jour.Size = new System.Drawing.Size(139, 29);
            this.Jour.TabIndex = 2;
            // 
            // Layout_Description
            // 
            this.Layout_Description.ColumnCount = 1;
            this.Layout_Description.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout_Description.Controls.Add(this.Description, 0, 1);
            this.Layout_Description.Controls.Add(this.Label_Acteurs, 0, 0);
            this.Layout_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_Description.Location = new System.Drawing.Point(3, 173);
            this.Layout_Description.Name = "Layout_Description";
            this.Layout_Description.RowCount = 2;
            this.Layout_Description.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Layout_Description.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.5F));
            this.Layout_Description.Size = new System.Drawing.Size(886, 220);
            this.Layout_Description.TabIndex = 2;
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description.Location = new System.Drawing.Point(3, 30);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(880, 187);
            this.Description.TabIndex = 6;
            this.Description.Text = "";
            // 
            // Label_Acteurs
            // 
            this.Label_Acteurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Acteurs.ForeColor = System.Drawing.SystemColors.Control;
            this.Label_Acteurs.Location = new System.Drawing.Point(3, 0);
            this.Label_Acteurs.Name = "Label_Acteurs";
            this.Label_Acteurs.Size = new System.Drawing.Size(880, 27);
            this.Label_Acteurs.TabIndex = 1;
            this.Label_Acteurs.Text = "Description";
            this.Label_Acteurs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Layout_Boutons
            // 
            this.Layout_Boutons.ColumnCount = 5;
            this.Layout_Boutons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.Layout_Boutons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Layout_Boutons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Layout_Boutons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Layout_Boutons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.Layout_Boutons.Controls.Add(this.Annuler, 3, 0);
            this.Layout_Boutons.Controls.Add(this.Valider, 1, 0);
            this.Layout_Boutons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_Boutons.Location = new System.Drawing.Point(3, 484);
            this.Layout_Boutons.Name = "Layout_Boutons";
            this.Layout_Boutons.RowCount = 1;
            this.Layout_Boutons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout_Boutons.Size = new System.Drawing.Size(886, 80);
            this.Layout_Boutons.TabIndex = 3;
            // 
            // Annuler
            // 
            this.Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Annuler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Annuler.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.Annuler.FlatAppearance.BorderSize = 5;
            this.Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Annuler.Font = new System.Drawing.Font("Gill Sans MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annuler.ForeColor = System.Drawing.Color.DarkViolet;
            this.Annuler.Location = new System.Drawing.Point(467, 3);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(215, 74);
            this.Annuler.TabIndex = 10;
            this.Annuler.Text = "ANNULER";
            this.Annuler.UseVisualStyleBackColor = true;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // Valider
            // 
            this.Valider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Valider.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.Valider.FlatAppearance.BorderSize = 5;
            this.Valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Valider.Font = new System.Drawing.Font("Gill Sans MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valider.ForeColor = System.Drawing.Color.DarkViolet;
            this.Valider.Location = new System.Drawing.Point(202, 3);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(215, 74);
            this.Valider.TabIndex = 9;
            this.Valider.Text = "VALIDER";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // Layout_Type
            // 
            this.Layout_Type.ColumnCount = 1;
            this.Layout_Type.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Layout_Type.Controls.Add(this.Label_Type, 0, 0);
            this.Layout_Type.Controls.Add(this.Layout_LivreFilm, 0, 1);
            this.Layout_Type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_Type.Location = new System.Drawing.Point(3, 399);
            this.Layout_Type.Name = "Layout_Type";
            this.Layout_Type.RowCount = 2;
            this.Layout_Type.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Layout_Type.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Layout_Type.Size = new System.Drawing.Size(886, 79);
            this.Layout_Type.TabIndex = 4;
            // 
            // Label_Type
            // 
            this.Label_Type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Type.ForeColor = System.Drawing.SystemColors.Control;
            this.Label_Type.Location = new System.Drawing.Point(3, 0);
            this.Label_Type.Name = "Label_Type";
            this.Label_Type.Size = new System.Drawing.Size(880, 39);
            this.Label_Type.TabIndex = 2;
            this.Label_Type.Text = "Type de média";
            this.Label_Type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Layout_LivreFilm
            // 
            this.Layout_LivreFilm.ColumnCount = 5;
            this.Layout_LivreFilm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.Layout_LivreFilm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Layout_LivreFilm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Layout_LivreFilm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Layout_LivreFilm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.Layout_LivreFilm.Controls.Add(this.Film, 3, 0);
            this.Layout_LivreFilm.Controls.Add(this.Livre, 1, 0);
            this.Layout_LivreFilm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_LivreFilm.Location = new System.Drawing.Point(3, 42);
            this.Layout_LivreFilm.Name = "Layout_LivreFilm";
            this.Layout_LivreFilm.RowCount = 1;
            this.Layout_LivreFilm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout_LivreFilm.Size = new System.Drawing.Size(880, 34);
            this.Layout_LivreFilm.TabIndex = 0;
            // 
            // Film
            // 
            this.Film.AutoSize = true;
            this.Film.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Film.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.Film.FlatAppearance.BorderSize = 5;
            this.Film.ForeColor = System.Drawing.Color.DarkViolet;
            this.Film.Location = new System.Drawing.Point(451, 3);
            this.Film.Name = "Film";
            this.Film.Size = new System.Drawing.Size(214, 28);
            this.Film.TabIndex = 8;
            this.Film.TabStop = true;
            this.Film.Text = "FILM";
            this.Film.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Film.UseVisualStyleBackColor = true;
            this.Film.CheckedChanged += new System.EventHandler(this.Film_CheckedChanged);
            // 
            // Livre
            // 
            this.Livre.AutoSize = true;
            this.Livre.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Livre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Livre.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.Livre.FlatAppearance.BorderSize = 5;
            this.Livre.ForeColor = System.Drawing.Color.DarkViolet;
            this.Livre.Location = new System.Drawing.Point(214, 3);
            this.Livre.Name = "Livre";
            this.Livre.Size = new System.Drawing.Size(214, 28);
            this.Livre.TabIndex = 7;
            this.Livre.TabStop = true;
            this.Livre.Text = "LIVRE";
            this.Livre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Livre.UseVisualStyleBackColor = true;
            this.Livre.CheckedChanged += new System.EventHandler(this.Livre_CheckedChanged);
            // 
            // Panel_Header
            // 
            this.Panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Panel_Header.Controls.Add(this.TitreFenetre);
            this.Panel_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Header.Location = new System.Drawing.Point(3, 4);
            this.Panel_Header.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(892, 115);
            this.Panel_Header.TabIndex = 0;
            // 
            // TitreFenetre
            // 
            this.TitreFenetre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitreFenetre.Font = new System.Drawing.Font("Gill Sans MT Condensed", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreFenetre.ForeColor = System.Drawing.Color.DarkViolet;
            this.TitreFenetre.Location = new System.Drawing.Point(0, 0);
            this.TitreFenetre.Name = "TitreFenetre";
            this.TitreFenetre.Size = new System.Drawing.Size(892, 115);
            this.TitreFenetre.TabIndex = 0;
            this.TitreFenetre.Text = "CREATION D\'UN MEDIA";
            this.TitreFenetre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AjoutFilm
            // 
            this.AcceptButton = this.Valider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Annuler;
            this.ClientSize = new System.Drawing.Size(898, 822);
            this.Controls.Add(this.Layout_Général);
            this.Font = new System.Drawing.Font("Gill Sans MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AjoutFilm";
            this.Text = "Médiathèque - Ajout d\'un média";
            this.Layout_Général.ResumeLayout(false);
            this.Panel_Corps.ResumeLayout(false);
            this.Layout_Corps.ResumeLayout(false);
            this.Layout_TitreRef.ResumeLayout(false);
            this.Layout_TitreRef.PerformLayout();
            this.Layout_GenreDate.ResumeLayout(false);
            this.Layout_Date.ResumeLayout(false);
            this.Layout_Date.PerformLayout();
            this.Layout_Description.ResumeLayout(false);
            this.Layout_Boutons.ResumeLayout(false);
            this.Layout_Type.ResumeLayout(false);
            this.Layout_LivreFilm.ResumeLayout(false);
            this.Layout_LivreFilm.PerformLayout();
            this.Panel_Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Layout_Général;
        private System.Windows.Forms.Panel Panel_Pied;
        private System.Windows.Forms.Panel Panel_Corps;
        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Label TitreFenetre;
        private System.Windows.Forms.TableLayoutPanel Layout_Corps;
        private System.Windows.Forms.TableLayoutPanel Layout_TitreRef;
        private System.Windows.Forms.TableLayoutPanel Layout_GenreDate;
        private System.Windows.Forms.TableLayoutPanel Layout_Description;
        private System.Windows.Forms.TableLayoutPanel Layout_Boutons;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.TextBox Titre;
        private System.Windows.Forms.Label Label_Titre;
        private System.Windows.Forms.Label Label_Reference;
        private System.Windows.Forms.TextBox Reference;
        private System.Windows.Forms.Label Label_Genre;
        private System.Windows.Forms.Label Label_Date;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Label Label_Acteurs;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.ComboBox Genre;
        private System.Windows.Forms.TableLayoutPanel Layout_Type;
        private System.Windows.Forms.Label Label_Type;
        private System.Windows.Forms.TableLayoutPanel Layout_LivreFilm;
        private System.Windows.Forms.RadioButton Film;
        private System.Windows.Forms.RadioButton Livre;
        private System.Windows.Forms.TableLayoutPanel Layout_Date;
        private System.Windows.Forms.TextBox Annee;
        private System.Windows.Forms.TextBox Mois;
        private System.Windows.Forms.TextBox Jour;
    }
}