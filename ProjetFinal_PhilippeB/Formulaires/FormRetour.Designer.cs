namespace ProjetFinal_PhilippeB
{
    partial class RetourLivre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetourLivre));
            this.lblTitreRetour = new System.Windows.Forms.Label();
            this.lblListeLivresEmprunt = new System.Windows.Forms.Label();
            this.txtIdClientRetour = new System.Windows.Forms.TextBox();
            this.lblIdClientValideRetour = new System.Windows.Forms.Label();
            this.txtIdRetour = new System.Windows.Forms.TextBox();
            this.lblRetourLivre = new System.Windows.Forms.Label();
            this.listViewRetour = new System.Windows.Forms.ListView();
            this.columnIdentifiant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAuteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAnnee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitreRetour
            // 
            this.lblTitreRetour.AutoSize = true;
            this.lblTitreRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreRetour.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitreRetour.Location = new System.Drawing.Point(272, 9);
            this.lblTitreRetour.Name = "lblTitreRetour";
            this.lblTitreRetour.Size = new System.Drawing.Size(227, 31);
            this.lblTitreRetour.TabIndex = 0;
            this.lblTitreRetour.Text = "Retour d\'un livre";
            // 
            // lblListeLivresEmprunt
            // 
            this.lblListeLivresEmprunt.AutoSize = true;
            this.lblListeLivresEmprunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeLivresEmprunt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblListeLivresEmprunt.Location = new System.Drawing.Point(237, 162);
            this.lblListeLivresEmprunt.Name = "lblListeLivresEmprunt";
            this.lblListeLivresEmprunt.Size = new System.Drawing.Size(326, 29);
            this.lblListeLivresEmprunt.TabIndex = 14;
            this.lblListeLivresEmprunt.Text = "Liste des livres empruntés ";
            // 
            // txtIdClientRetour
            // 
            this.txtIdClientRetour.Location = new System.Drawing.Point(360, 111);
            this.txtIdClientRetour.Name = "txtIdClientRetour";
            this.txtIdClientRetour.Size = new System.Drawing.Size(182, 20);
            this.txtIdClientRetour.TabIndex = 13;
            // 
            // lblIdClientValideRetour
            // 
            this.lblIdClientValideRetour.AutoSize = true;
            this.lblIdClientValideRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdClientValideRetour.Location = new System.Drawing.Point(111, 108);
            this.lblIdClientValideRetour.Name = "lblIdClientValideRetour";
            this.lblIdClientValideRetour.Size = new System.Drawing.Size(243, 24);
            this.lblIdClientValideRetour.TabIndex = 12;
            this.lblIdClientValideRetour.Text = "Identifiant valide d\'un client :";
            // 
            // txtIdRetour
            // 
            this.txtIdRetour.Location = new System.Drawing.Point(313, 56);
            this.txtIdRetour.Name = "txtIdRetour";
            this.txtIdRetour.Size = new System.Drawing.Size(202, 20);
            this.txtIdRetour.TabIndex = 10;
            // 
            // lblRetourLivre
            // 
            this.lblRetourLivre.AutoSize = true;
            this.lblRetourLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetourLivre.Location = new System.Drawing.Point(110, 50);
            this.lblRetourLivre.Name = "lblRetourLivre";
            this.lblRetourLivre.Size = new System.Drawing.Size(199, 25);
            this.lblRetourLivre.TabIndex = 9;
            this.lblRetourLivre.Text = "Identifiant du livre : ";
            // 
            // listViewRetour
            // 
            this.listViewRetour.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIdentifiant,
            this.columnNom,
            this.columnAuteur,
            this.columnAnnee});
            this.listViewRetour.HideSelection = false;
            this.listViewRetour.Location = new System.Drawing.Point(115, 194);
            this.listViewRetour.Name = "listViewRetour";
            this.listViewRetour.Size = new System.Drawing.Size(576, 207);
            this.listViewRetour.TabIndex = 8;
            this.listViewRetour.UseCompatibleStateImageBehavior = false;
            this.listViewRetour.View = System.Windows.Forms.View.Details;
           
            // 
            // columnIdentifiant
            // 
            this.columnIdentifiant.Text = "Identifiant";
            this.columnIdentifiant.Width = 124;
            // 
            // columnNom
            // 
            this.columnNom.Text = "Nom";
            this.columnNom.Width = 112;
            // 
            // columnAuteur
            // 
            this.columnAuteur.Text = "Auteur";
            this.columnAuteur.Width = 154;
            // 
            // columnAnnee
            // 
            this.columnAnnee.Text = "Année de parution";
            this.columnAnnee.Width = 110;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(585, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 53);
            this.button1.TabIndex = 15;
            this.button1.Text = "Retourner";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RetourLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblListeLivresEmprunt);
            this.Controls.Add(this.txtIdClientRetour);
            this.Controls.Add(this.lblIdClientValideRetour);
            this.Controls.Add(this.txtIdRetour);
            this.Controls.Add(this.lblRetourLivre);
            this.Controls.Add(this.listViewRetour);
            this.Controls.Add(this.lblTitreRetour);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RetourLivre";
            this.Text = "Retour d\'un livre";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RetourLivre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitreRetour;
        private System.Windows.Forms.Label lblListeLivresEmprunt;
        private System.Windows.Forms.TextBox txtIdClientRetour;
        private System.Windows.Forms.Label lblIdClientValideRetour;
        private System.Windows.Forms.TextBox txtIdRetour;
        private System.Windows.Forms.Label lblRetourLivre;
        private System.Windows.Forms.ListView listViewRetour;
        private System.Windows.Forms.ColumnHeader columnIdentifiant;
        private System.Windows.Forms.ColumnHeader columnNom;
        private System.Windows.Forms.ColumnHeader columnAuteur;
        private System.Windows.Forms.ColumnHeader columnAnnee;
        private System.Windows.Forms.Button button1;
    }
}