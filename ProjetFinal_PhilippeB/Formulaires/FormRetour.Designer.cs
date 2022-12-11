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
            this.lblTitreRetour = new System.Windows.Forms.Label();
            this.lblListeLivresEmprunt = new System.Windows.Forms.Label();
            this.txtIdClientRetour = new System.Windows.Forms.TextBox();
            this.lblIdClientValideRetour = new System.Windows.Forms.Label();
            this.btnRetourner = new System.Windows.Forms.Button();
            this.txtIdRetour = new System.Windows.Forms.TextBox();
            this.lblRetourLivre = new System.Windows.Forms.Label();
            this.listViewRetour = new System.Windows.Forms.ListView();
            this.columnIdentifiant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAuteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAnnee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAfficherListe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitreRetour
            // 
            this.lblTitreRetour.AutoSize = true;
            this.lblTitreRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblListeLivresEmprunt.Location = new System.Drawing.Point(237, 162);
            this.lblListeLivresEmprunt.Name = "lblListeLivresEmprunt";
            this.lblListeLivresEmprunt.Size = new System.Drawing.Size(326, 29);
            this.lblListeLivresEmprunt.TabIndex = 14;
            this.lblListeLivresEmprunt.Text = "Liste des livres empruntés ";
            this.lblListeLivresEmprunt.Click += new System.EventHandler(this.lblListeLivresDispo_Click);
            // 
            // txtIdClientRetour
            // 
            this.txtIdClientRetour.Location = new System.Drawing.Point(360, 111);
            this.txtIdClientRetour.Name = "txtIdClientRetour";
            this.txtIdClientRetour.Size = new System.Drawing.Size(182, 20);
            this.txtIdClientRetour.TabIndex = 13;
            this.txtIdClientRetour.TextChanged += new System.EventHandler(this.txtIdClient_TextChanged);
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
            this.lblIdClientValideRetour.Click += new System.EventHandler(this.lblIdClientValide_Click);
            // 
            // btnRetourner
            // 
            this.btnRetourner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetourner.Location = new System.Drawing.Point(599, 50);
            this.btnRetourner.Name = "btnRetourner";
            this.btnRetourner.Size = new System.Drawing.Size(123, 50);
            this.btnRetourner.TabIndex = 11;
            this.btnRetourner.Text = "Retourner";
            this.btnRetourner.UseVisualStyleBackColor = true;
            this.btnRetourner.Click += new System.EventHandler(this.btnEmprunter_Click);
            // 
            // txtIdRetour
            // 
            this.txtIdRetour.Location = new System.Drawing.Point(313, 56);
            this.txtIdRetour.Name = "txtIdRetour";
            this.txtIdRetour.Size = new System.Drawing.Size(202, 20);
            this.txtIdRetour.TabIndex = 10;
            this.txtIdRetour.TextChanged += new System.EventHandler(this.txtIdEmprunt_TextChanged);
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
            this.lblRetourLivre.Click += new System.EventHandler(this.lblEmpruntLivre_Click);
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
            this.listViewRetour.SelectedIndexChanged += new System.EventHandler(this.listViewEmprunt_SelectedIndexChanged);
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
            // btnAfficherListe
            // 
            this.btnAfficherListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficherListe.Location = new System.Drawing.Point(599, 111);
            this.btnAfficherListe.Name = "btnAfficherListe";
            this.btnAfficherListe.Size = new System.Drawing.Size(145, 64);
            this.btnAfficherListe.TabIndex = 15;
            this.btnAfficherListe.Text = "Afficher la liste de vos livres";
            this.btnAfficherListe.UseVisualStyleBackColor = true;
            // 
            // RetourLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAfficherListe);
            this.Controls.Add(this.lblListeLivresEmprunt);
            this.Controls.Add(this.txtIdClientRetour);
            this.Controls.Add(this.lblIdClientValideRetour);
            this.Controls.Add(this.btnRetourner);
            this.Controls.Add(this.txtIdRetour);
            this.Controls.Add(this.lblRetourLivre);
            this.Controls.Add(this.listViewRetour);
            this.Controls.Add(this.lblTitreRetour);
            this.Name = "RetourLivre";
            this.Text = "Retour d\'un livre";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitreRetour;
        private System.Windows.Forms.Label lblListeLivresEmprunt;
        private System.Windows.Forms.TextBox txtIdClientRetour;
        private System.Windows.Forms.Label lblIdClientValideRetour;
        private System.Windows.Forms.Button btnRetourner;
        private System.Windows.Forms.TextBox txtIdRetour;
        private System.Windows.Forms.Label lblRetourLivre;
        private System.Windows.Forms.ListView listViewRetour;
        private System.Windows.Forms.ColumnHeader columnIdentifiant;
        private System.Windows.Forms.ColumnHeader columnNom;
        private System.Windows.Forms.ColumnHeader columnAuteur;
        private System.Windows.Forms.ColumnHeader columnAnnee;
        private System.Windows.Forms.Button btnAfficherListe;
    }
}