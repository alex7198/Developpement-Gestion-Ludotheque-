namespace AlexisGuyot_AlexandreLabrosse_CDAA
{
    partial class VisualiserMediatheque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualiserMediatheque));
            this.Layout_Général = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_Pied = new System.Windows.Forms.Panel();
            this.Panel_Corps = new System.Windows.Forms.Panel();
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.TitreFenetre = new System.Windows.Forms.Label();
            this.Arbre = new System.Windows.Forms.TreeView();
            this.Layout_Corps = new System.Windows.Forms.TableLayoutPanel();
            this.Layout_Affichage = new System.Windows.Forms.TableLayoutPanel();
            this.Affichage = new System.Windows.Forms.RichTextBox();
            this.Layout_TitreMinia = new System.Windows.Forms.TableLayoutPanel();
            this.MiniatureMedia = new System.Windows.Forms.PictureBox();
            this.TitreMedia = new System.Windows.Forms.Label();
            this.Layout_Général.SuspendLayout();
            this.Panel_Corps.SuspendLayout();
            this.Panel_Header.SuspendLayout();
            this.Layout_Corps.SuspendLayout();
            this.Layout_Affichage.SuspendLayout();
            this.Layout_TitreMinia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MiniatureMedia)).BeginInit();
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
            this.Layout_Général.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Layout_Général.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.77778F));
            this.Layout_Général.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Layout_Général.Size = new System.Drawing.Size(880, 777);
            this.Layout_Général.TabIndex = 2;
            // 
            // Panel_Pied
            // 
            this.Panel_Pied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Panel_Pied.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Pied.Location = new System.Drawing.Point(3, 696);
            this.Panel_Pied.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Panel_Pied.Name = "Panel_Pied";
            this.Panel_Pied.Size = new System.Drawing.Size(874, 75);
            this.Panel_Pied.TabIndex = 2;
            // 
            // Panel_Corps
            // 
            this.Panel_Corps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Panel_Corps.Controls.Add(this.Layout_Corps);
            this.Panel_Corps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Corps.Location = new System.Drawing.Point(3, 92);
            this.Panel_Corps.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Panel_Corps.Name = "Panel_Corps";
            this.Panel_Corps.Size = new System.Drawing.Size(874, 592);
            this.Panel_Corps.TabIndex = 1;
            // 
            // Panel_Header
            // 
            this.Panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Panel_Header.Controls.Add(this.TitreFenetre);
            this.Panel_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Header.Location = new System.Drawing.Point(3, 6);
            this.Panel_Header.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(874, 74);
            this.Panel_Header.TabIndex = 0;
            // 
            // TitreFenetre
            // 
            this.TitreFenetre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitreFenetre.Font = new System.Drawing.Font("Gill Sans MT Condensed", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreFenetre.ForeColor = System.Drawing.Color.DarkViolet;
            this.TitreFenetre.Location = new System.Drawing.Point(0, 0);
            this.TitreFenetre.Name = "TitreFenetre";
            this.TitreFenetre.Size = new System.Drawing.Size(874, 74);
            this.TitreFenetre.TabIndex = 0;
            this.TitreFenetre.Text = "VISUALISER LA MEDIATHEQUE";
            this.TitreFenetre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Arbre
            // 
            this.Arbre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Arbre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Arbre.ForeColor = System.Drawing.SystemColors.Window;
            this.Arbre.Location = new System.Drawing.Point(3, 3);
            this.Arbre.Name = "Arbre";
            this.Arbre.Size = new System.Drawing.Size(343, 586);
            this.Arbre.TabIndex = 0;
            this.Arbre.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Arbre_AfterSelect);
            // 
            // Layout_Corps
            // 
            this.Layout_Corps.ColumnCount = 2;
            this.Layout_Corps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.Layout_Corps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.Layout_Corps.Controls.Add(this.Arbre, 0, 0);
            this.Layout_Corps.Controls.Add(this.Layout_Affichage, 1, 0);
            this.Layout_Corps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_Corps.Location = new System.Drawing.Point(0, 0);
            this.Layout_Corps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Layout_Corps.Name = "Layout_Corps";
            this.Layout_Corps.RowCount = 1;
            this.Layout_Corps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout_Corps.Size = new System.Drawing.Size(874, 592);
            this.Layout_Corps.TabIndex = 0;
            // 
            // Layout_Affichage
            // 
            this.Layout_Affichage.ColumnCount = 1;
            this.Layout_Affichage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout_Affichage.Controls.Add(this.Affichage, 0, 1);
            this.Layout_Affichage.Controls.Add(this.Layout_TitreMinia, 0, 0);
            this.Layout_Affichage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_Affichage.Location = new System.Drawing.Point(352, 3);
            this.Layout_Affichage.Name = "Layout_Affichage";
            this.Layout_Affichage.RowCount = 2;
            this.Layout_Affichage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.Layout_Affichage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.Layout_Affichage.Size = new System.Drawing.Size(519, 586);
            this.Layout_Affichage.TabIndex = 1;
            // 
            // Affichage
            // 
            this.Affichage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Affichage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Affichage.ForeColor = System.Drawing.SystemColors.Window;
            this.Affichage.Location = new System.Drawing.Point(3, 178);
            this.Affichage.Name = "Affichage";
            this.Affichage.ReadOnly = true;
            this.Affichage.Size = new System.Drawing.Size(513, 405);
            this.Affichage.TabIndex = 2;
            this.Affichage.Text = "";
            // 
            // Layout_TitreMinia
            // 
            this.Layout_TitreMinia.ColumnCount = 2;
            this.Layout_TitreMinia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.Layout_TitreMinia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.Layout_TitreMinia.Controls.Add(this.MiniatureMedia, 0, 0);
            this.Layout_TitreMinia.Controls.Add(this.TitreMedia, 1, 0);
            this.Layout_TitreMinia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_TitreMinia.Location = new System.Drawing.Point(3, 3);
            this.Layout_TitreMinia.Name = "Layout_TitreMinia";
            this.Layout_TitreMinia.RowCount = 1;
            this.Layout_TitreMinia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout_TitreMinia.Size = new System.Drawing.Size(513, 169);
            this.Layout_TitreMinia.TabIndex = 3;
            // 
            // MiniatureMedia
            // 
            this.MiniatureMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MiniatureMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiniatureMedia.ErrorImage = ((System.Drawing.Image)(resources.GetObject("MiniatureMedia.ErrorImage")));
            this.MiniatureMedia.InitialImage = ((System.Drawing.Image)(resources.GetObject("MiniatureMedia.InitialImage")));
            this.MiniatureMedia.Location = new System.Drawing.Point(3, 3);
            this.MiniatureMedia.Name = "MiniatureMedia";
            this.MiniatureMedia.Size = new System.Drawing.Size(147, 163);
            this.MiniatureMedia.TabIndex = 0;
            this.MiniatureMedia.TabStop = false;
            // 
            // TitreMedia
            // 
            this.TitreMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitreMedia.Font = new System.Drawing.Font("Gill Sans MT Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreMedia.ForeColor = System.Drawing.Color.DarkViolet;
            this.TitreMedia.Location = new System.Drawing.Point(156, 0);
            this.TitreMedia.Name = "TitreMedia";
            this.TitreMedia.Size = new System.Drawing.Size(354, 169);
            this.TitreMedia.TabIndex = 1;
            this.TitreMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VisualiserMediatheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 777);
            this.Controls.Add(this.Layout_Général);
            this.Font = new System.Drawing.Font("Gill Sans MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VisualiserMediatheque";
            this.Text = "Médiathèque - Visualiser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Layout_Général.ResumeLayout(false);
            this.Panel_Corps.ResumeLayout(false);
            this.Panel_Header.ResumeLayout(false);
            this.Layout_Corps.ResumeLayout(false);
            this.Layout_Affichage.ResumeLayout(false);
            this.Layout_TitreMinia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MiniatureMedia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Layout_Général;
        private System.Windows.Forms.Panel Panel_Pied;
        private System.Windows.Forms.Panel Panel_Corps;
        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Label TitreFenetre;
        private System.Windows.Forms.TableLayoutPanel Layout_Corps;
        private System.Windows.Forms.TreeView Arbre;
        private System.Windows.Forms.TableLayoutPanel Layout_Affichage;
        private System.Windows.Forms.RichTextBox Affichage;
        private System.Windows.Forms.TableLayoutPanel Layout_TitreMinia;
        private System.Windows.Forms.PictureBox MiniatureMedia;
        private System.Windows.Forms.Label TitreMedia;
    }
}