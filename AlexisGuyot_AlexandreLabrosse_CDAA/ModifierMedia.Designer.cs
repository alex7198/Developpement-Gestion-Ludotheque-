namespace AlexisGuyot_AlexandreLabrosse_CDAA
{
    partial class ModifierMedia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierMedia));
            this.Layout_Général = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_Pied = new System.Windows.Forms.Panel();
            this.Panel_Corps = new System.Windows.Forms.Panel();
            this.Layout_Corps = new System.Windows.Forms.TableLayoutPanel();
            this.Layout_Boutons = new System.Windows.Forms.TableLayoutPanel();
            this.Annuler = new System.Windows.Forms.Button();
            this.Valider = new System.Windows.Forms.Button();
            this.Grille = new System.Windows.Forms.DataGridView();
            this.Miniature = new System.Windows.Forms.DataGridViewImageColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mois = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Annee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.TitreFenetre = new System.Windows.Forms.Label();
            this.Layout_Général.SuspendLayout();
            this.Panel_Corps.SuspendLayout();
            this.Layout_Corps.SuspendLayout();
            this.Layout_Boutons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grille)).BeginInit();
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
            this.Layout_Général.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Layout_Général.Name = "Layout_Général";
            this.Layout_Général.RowCount = 3;
            this.Layout_Général.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Layout_Général.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.Layout_Général.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Layout_Général.Size = new System.Drawing.Size(856, 622);
            this.Layout_Général.TabIndex = 3;
            // 
            // Panel_Pied
            // 
            this.Panel_Pied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Panel_Pied.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Pied.Location = new System.Drawing.Point(3, 534);
            this.Panel_Pied.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Panel_Pied.Name = "Panel_Pied";
            this.Panel_Pied.Size = new System.Drawing.Size(850, 82);
            this.Panel_Pied.TabIndex = 2;
            // 
            // Panel_Corps
            // 
            this.Panel_Corps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Panel_Corps.Controls.Add(this.Layout_Corps);
            this.Panel_Corps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Corps.Location = new System.Drawing.Point(3, 99);
            this.Panel_Corps.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Panel_Corps.Name = "Panel_Corps";
            this.Panel_Corps.Size = new System.Drawing.Size(850, 423);
            this.Panel_Corps.TabIndex = 1;
            // 
            // Layout_Corps
            // 
            this.Layout_Corps.ColumnCount = 1;
            this.Layout_Corps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout_Corps.Controls.Add(this.Layout_Boutons, 0, 1);
            this.Layout_Corps.Controls.Add(this.Grille, 0, 0);
            this.Layout_Corps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_Corps.Location = new System.Drawing.Point(0, 0);
            this.Layout_Corps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Layout_Corps.Name = "Layout_Corps";
            this.Layout_Corps.RowCount = 2;
            this.Layout_Corps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.Layout_Corps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Layout_Corps.Size = new System.Drawing.Size(850, 423);
            this.Layout_Corps.TabIndex = 0;
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
            this.Layout_Boutons.Location = new System.Drawing.Point(3, 342);
            this.Layout_Boutons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Layout_Boutons.Name = "Layout_Boutons";
            this.Layout_Boutons.RowCount = 1;
            this.Layout_Boutons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout_Boutons.Size = new System.Drawing.Size(844, 77);
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
            this.Annuler.Location = new System.Drawing.Point(445, 4);
            this.Annuler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(205, 69);
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
            this.Valider.Location = new System.Drawing.Point(192, 4);
            this.Valider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(205, 69);
            this.Valider.TabIndex = 9;
            this.Valider.Text = "VALIDER";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // Grille
            // 
            this.Grille.AllowUserToAddRows = false;
            this.Grille.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Grille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grille.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Miniature,
            this.Reference,
            this.Titre,
            this.Description,
            this.Jour,
            this.Mois,
            this.Annee});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gill Sans MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grille.DefaultCellStyle = dataGridViewCellStyle1;
            this.Grille.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grille.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Grille.Location = new System.Drawing.Point(3, 3);
            this.Grille.Name = "Grille";
            this.Grille.RowTemplate.Height = 28;
            this.Grille.Size = new System.Drawing.Size(844, 332);
            this.Grille.TabIndex = 4;
            this.Grille.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grille_CellEndEdit);
            // 
            // Miniature
            // 
            this.Miniature.HeaderText = "Miniature";
            this.Miniature.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Miniature.Name = "Miniature";
            this.Miniature.Width = 201;
            // 
            // Reference
            // 
            this.Reference.HeaderText = "Reference";
            this.Reference.Name = "Reference";
            this.Reference.ReadOnly = true;
            // 
            // Titre
            // 
            this.Titre.HeaderText = "Titre";
            this.Titre.Name = "Titre";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Jour
            // 
            this.Jour.HeaderText = "Jour";
            this.Jour.Name = "Jour";
            // 
            // Mois
            // 
            this.Mois.HeaderText = "Mois";
            this.Mois.Name = "Mois";
            // 
            // Annee
            // 
            this.Annee.HeaderText = "Annee";
            this.Annee.Name = "Annee";
            // 
            // Panel_Header
            // 
            this.Panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Panel_Header.Controls.Add(this.TitreFenetre);
            this.Panel_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Header.Location = new System.Drawing.Point(3, 6);
            this.Panel_Header.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(850, 81);
            this.Panel_Header.TabIndex = 0;
            // 
            // TitreFenetre
            // 
            this.TitreFenetre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitreFenetre.Font = new System.Drawing.Font("Gill Sans MT Condensed", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreFenetre.ForeColor = System.Drawing.Color.DarkViolet;
            this.TitreFenetre.Location = new System.Drawing.Point(0, 0);
            this.TitreFenetre.Name = "TitreFenetre";
            this.TitreFenetre.Size = new System.Drawing.Size(850, 81);
            this.TitreFenetre.TabIndex = 0;
            this.TitreFenetre.Text = "MODIFIER UN MEDIA";
            this.TitreFenetre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModifierMedia
            // 
            this.AcceptButton = this.Valider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Annuler;
            this.ClientSize = new System.Drawing.Size(856, 622);
            this.Controls.Add(this.Layout_Général);
            this.Font = new System.Drawing.Font("Gill Sans MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ModifierMedia";
            this.Text = "Médiathèque - Modifier un média";
            this.Layout_Général.ResumeLayout(false);
            this.Panel_Corps.ResumeLayout(false);
            this.Layout_Corps.ResumeLayout(false);
            this.Layout_Boutons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grille)).EndInit();
            this.Panel_Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Layout_Général;
        private System.Windows.Forms.Panel Panel_Pied;
        private System.Windows.Forms.Panel Panel_Corps;
        private System.Windows.Forms.TableLayoutPanel Layout_Corps;
        private System.Windows.Forms.TableLayoutPanel Layout_Boutons;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Label TitreFenetre;
        private System.Windows.Forms.DataGridView Grille;
        private System.Windows.Forms.DataGridViewImageColumn Miniature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mois;
        private System.Windows.Forms.DataGridViewTextBoxColumn Annee;
    }
}