namespace ProjetFinal_PhilippeB
{
    partial class AjouterSupprimerModifierLivres
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
            this.lblParametrageLivre = new System.Windows.Forms.Label();
            this.lblIdentifiantLivre = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.lblAnneeParution = new System.Windows.Forms.Label();
            this.lblMdpAdmin = new System.Windows.Forms.Label();
            this.btnAjouterLivre = new System.Windows.Forms.Button();
            this.txtIdLivre = new System.Windows.Forms.TextBox();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.txtAuteur = new System.Windows.Forms.TextBox();
            this.txtAnneParution = new System.Windows.Forms.TextBox();
            this.txtMdpAdmin = new System.Windows.Forms.TextBox();
            this.btnModifierLivre = new System.Windows.Forms.Button();
            this.btnSupprimerLivre = new System.Windows.Forms.Button();
            this.dataGridViewLivreCreation = new System.Windows.Forms.DataGridView();
            this.btnSaveInventaire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivreCreation)).BeginInit();
            this.SuspendLayout();
            // 
            // lblParametrageLivre
            // 
            this.lblParametrageLivre.AutoSize = true;
            this.lblParametrageLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParametrageLivre.Location = new System.Drawing.Point(234, 9);
            this.lblParametrageLivre.Name = "lblParametrageLivre";
            this.lblParametrageLivre.Size = new System.Drawing.Size(314, 31);
            this.lblParametrageLivre.TabIndex = 0;
            this.lblParametrageLivre.Text = "Paramètrage des livres";
            // 
            // lblIdentifiantLivre
            // 
            this.lblIdentifiantLivre.AutoSize = true;
            this.lblIdentifiantLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentifiantLivre.Location = new System.Drawing.Point(12, 57);
            this.lblIdentifiantLivre.Name = "lblIdentifiantLivre";
            this.lblIdentifiantLivre.Size = new System.Drawing.Size(167, 20);
            this.lblIdentifiantLivre.TabIndex = 1;
            this.lblIdentifiantLivre.Text = "Numéro d\'indentifiant :";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(12, 96);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(48, 20);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Titre :";
            this.lblTitre.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuteur.Location = new System.Drawing.Point(12, 143);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(69, 20);
            this.lblAuteur.TabIndex = 3;
            this.lblAuteur.Text = "Auteur : ";
            // 
            // lblAnneeParution
            // 
            this.lblAnneeParution.AutoSize = true;
            this.lblAnneeParution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnneeParution.Location = new System.Drawing.Point(12, 182);
            this.lblAnneeParution.Name = "lblAnneeParution";
            this.lblAnneeParution.Size = new System.Drawing.Size(152, 20);
            this.lblAnneeParution.TabIndex = 4;
            this.lblAnneeParution.Text = "Année de parution : ";
            // 
            // lblMdpAdmin
            // 
            this.lblMdpAdmin.AutoSize = true;
            this.lblMdpAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdpAdmin.Location = new System.Drawing.Point(416, 54);
            this.lblMdpAdmin.Name = "lblMdpAdmin";
            this.lblMdpAdmin.Size = new System.Drawing.Size(190, 24);
            this.lblMdpAdmin.TabIndex = 5;
            this.lblMdpAdmin.Text = "Mot de passe admin :";
            // 
            // btnAjouterLivre
            // 
            this.btnAjouterLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterLivre.Location = new System.Drawing.Point(361, 105);
            this.btnAjouterLivre.Name = "btnAjouterLivre";
            this.btnAjouterLivre.Size = new System.Drawing.Size(134, 56);
            this.btnAjouterLivre.TabIndex = 6;
            this.btnAjouterLivre.Text = "Ajouter";
            this.btnAjouterLivre.UseVisualStyleBackColor = true;
            this.btnAjouterLivre.Click += new System.EventHandler(this.btnAjouterLivre_Click);
            // 
            // txtIdLivre
            // 
            this.txtIdLivre.Location = new System.Drawing.Point(198, 59);
            this.txtIdLivre.Name = "txtIdLivre";
            this.txtIdLivre.Size = new System.Drawing.Size(157, 20);
            this.txtIdLivre.TabIndex = 7;
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(198, 98);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(157, 20);
            this.txtTitre.TabIndex = 8;
            // 
            // txtAuteur
            // 
            this.txtAuteur.Location = new System.Drawing.Point(198, 143);
            this.txtAuteur.Name = "txtAuteur";
            this.txtAuteur.Size = new System.Drawing.Size(157, 20);
            this.txtAuteur.TabIndex = 9;
            // 
            // txtAnneParution
            // 
            this.txtAnneParution.Location = new System.Drawing.Point(198, 184);
            this.txtAnneParution.Name = "txtAnneParution";
            this.txtAnneParution.Size = new System.Drawing.Size(157, 20);
            this.txtAnneParution.TabIndex = 10;
            // 
            // txtMdpAdmin
            // 
            this.txtMdpAdmin.Location = new System.Drawing.Point(625, 59);
            this.txtMdpAdmin.Name = "txtMdpAdmin";
            this.txtMdpAdmin.Size = new System.Drawing.Size(145, 20);
            this.txtMdpAdmin.TabIndex = 11;
            // 
            // btnModifierLivre
            // 
            this.btnModifierLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierLivre.Location = new System.Drawing.Point(501, 105);
            this.btnModifierLivre.Name = "btnModifierLivre";
            this.btnModifierLivre.Size = new System.Drawing.Size(134, 58);
            this.btnModifierLivre.TabIndex = 12;
            this.btnModifierLivre.Text = "Modifier";
            this.btnModifierLivre.UseVisualStyleBackColor = true;
            this.btnModifierLivre.Click += new System.EventHandler(this.btnModifierLivre_Click);
            // 
            // btnSupprimerLivre
            // 
            this.btnSupprimerLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerLivre.Location = new System.Drawing.Point(641, 103);
            this.btnSupprimerLivre.Name = "btnSupprimerLivre";
            this.btnSupprimerLivre.Size = new System.Drawing.Size(158, 61);
            this.btnSupprimerLivre.TabIndex = 13;
            this.btnSupprimerLivre.Text = "Supprimer";
            this.btnSupprimerLivre.UseVisualStyleBackColor = true;
            this.btnSupprimerLivre.Click += new System.EventHandler(this.btnSupprimerLivre_Click);
            // 
            // dataGridViewLivreCreation
            // 
            this.dataGridViewLivreCreation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLivreCreation.Location = new System.Drawing.Point(97, 233);
            this.dataGridViewLivreCreation.Name = "dataGridViewLivreCreation";
            this.dataGridViewLivreCreation.Size = new System.Drawing.Size(600, 194);
            this.dataGridViewLivreCreation.TabIndex = 14;
            // 
            // btnSaveInventaire
            // 
            this.btnSaveInventaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInventaire.Location = new System.Drawing.Point(461, 184);
            this.btnSaveInventaire.Name = "btnSaveInventaire";
            this.btnSaveInventaire.Size = new System.Drawing.Size(236, 35);
            this.btnSaveInventaire.TabIndex = 15;
            this.btnSaveInventaire.Text = "Sauvegarder l\'inventaire";
            this.btnSaveInventaire.UseVisualStyleBackColor = true;
            this.btnSaveInventaire.Click += new System.EventHandler(this.btnSaveInventaire_Click);
            // 
            // AjouterSupprimerModifierLivres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveInventaire);
            this.Controls.Add(this.dataGridViewLivreCreation);
            this.Controls.Add(this.btnSupprimerLivre);
            this.Controls.Add(this.btnModifierLivre);
            this.Controls.Add(this.txtMdpAdmin);
            this.Controls.Add(this.txtAnneParution);
            this.Controls.Add(this.txtAuteur);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.txtIdLivre);
            this.Controls.Add(this.btnAjouterLivre);
            this.Controls.Add(this.lblMdpAdmin);
            this.Controls.Add(this.lblAnneeParution);
            this.Controls.Add(this.lblAuteur);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblIdentifiantLivre);
            this.Controls.Add(this.lblParametrageLivre);
            this.Name = "AjouterSupprimerModifierLivres";
            this.Text = "Ajouter / Supprimer / Modifier livres";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AjouterSupprimerModifierLivres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivreCreation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParametrageLivre;
        private System.Windows.Forms.Label lblIdentifiantLivre;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.Label lblAnneeParution;
        private System.Windows.Forms.Label lblMdpAdmin;
        private System.Windows.Forms.Button btnAjouterLivre;
        private System.Windows.Forms.TextBox txtIdLivre;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.TextBox txtAuteur;
        private System.Windows.Forms.TextBox txtAnneParution;
        private System.Windows.Forms.TextBox txtMdpAdmin;
        private System.Windows.Forms.Button btnModifierLivre;
        private System.Windows.Forms.Button btnSupprimerLivre;
        private System.Windows.Forms.DataGridView dataGridViewLivreCreation;
        private System.Windows.Forms.Button btnSaveInventaire;
    }
}