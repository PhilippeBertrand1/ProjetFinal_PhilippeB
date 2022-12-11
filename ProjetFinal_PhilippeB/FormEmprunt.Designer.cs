namespace ProjetFinal_PhilippeB
{
    partial class EmpruntLivre
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
            this.lblEmprunt = new System.Windows.Forms.Label();
            this.listViewEmprunt = new System.Windows.Forms.ListView();
            this.lblEmpruntLivre = new System.Windows.Forms.Label();
            this.txtIdEmprunt = new System.Windows.Forms.TextBox();
            this.btnEmprunter = new System.Windows.Forms.Button();
            this.columnIdentifiant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAuteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAnnee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblIdClientValide = new System.Windows.Forms.Label();
            this.txtIdClient = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEmprunt
            // 
            this.lblEmprunt.AutoSize = true;
            this.lblEmprunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmprunt.Location = new System.Drawing.Point(252, 9);
            this.lblEmprunt.Name = "lblEmprunt";
            this.lblEmprunt.Size = new System.Drawing.Size(248, 31);
            this.lblEmprunt.TabIndex = 0;
            this.lblEmprunt.Text = "Emprunt d\'un livre";
            // 
            // listViewEmprunt
            // 
            this.listViewEmprunt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIdentifiant,
            this.columnNom,
            this.columnAuteur,
            this.columnAnnee});
            this.listViewEmprunt.HideSelection = false;
            this.listViewEmprunt.Location = new System.Drawing.Point(100, 181);
            this.listViewEmprunt.Name = "listViewEmprunt";
            this.listViewEmprunt.Size = new System.Drawing.Size(576, 207);
            this.listViewEmprunt.TabIndex = 1;
            this.listViewEmprunt.UseCompatibleStateImageBehavior = false;
            this.listViewEmprunt.View = System.Windows.Forms.View.Details;
            this.listViewEmprunt.SelectedIndexChanged += new System.EventHandler(this.listViewEmprunt_SelectedIndexChanged);
            // 
            // lblEmpruntLivre
            // 
            this.lblEmpruntLivre.AutoSize = true;
            this.lblEmpruntLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpruntLivre.Location = new System.Drawing.Point(95, 73);
            this.lblEmpruntLivre.Name = "lblEmpruntLivre";
            this.lblEmpruntLivre.Size = new System.Drawing.Size(199, 25);
            this.lblEmpruntLivre.TabIndex = 2;
            this.lblEmpruntLivre.Text = "Identifiant du livre : ";
            // 
            // txtIdEmprunt
            // 
            this.txtIdEmprunt.Location = new System.Drawing.Point(298, 79);
            this.txtIdEmprunt.Name = "txtIdEmprunt";
            this.txtIdEmprunt.Size = new System.Drawing.Size(202, 20);
            this.txtIdEmprunt.TabIndex = 3;
            // 
            // btnEmprunter
            // 
            this.btnEmprunter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprunter.Location = new System.Drawing.Point(553, 94);
            this.btnEmprunter.Name = "btnEmprunter";
            this.btnEmprunter.Size = new System.Drawing.Size(123, 50);
            this.btnEmprunter.TabIndex = 4;
            this.btnEmprunter.Text = "Emprunter ";
            this.btnEmprunter.UseVisualStyleBackColor = true;
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
            // lblIdClientValide
            // 
            this.lblIdClientValide.AutoSize = true;
            this.lblIdClientValide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdClientValide.Location = new System.Drawing.Point(96, 131);
            this.lblIdClientValide.Name = "lblIdClientValide";
            this.lblIdClientValide.Size = new System.Drawing.Size(243, 24);
            this.lblIdClientValide.TabIndex = 5;
            this.lblIdClientValide.Text = "Identifiant valide d\'un client :";
            // 
            // txtIdClient
            // 
            this.txtIdClient.Location = new System.Drawing.Point(345, 134);
            this.txtIdClient.Name = "txtIdClient";
            this.txtIdClient.Size = new System.Drawing.Size(182, 20);
            this.txtIdClient.TabIndex = 6;
            // 
            // EmpruntLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIdClient);
            this.Controls.Add(this.lblIdClientValide);
            this.Controls.Add(this.btnEmprunter);
            this.Controls.Add(this.txtIdEmprunt);
            this.Controls.Add(this.lblEmpruntLivre);
            this.Controls.Add(this.listViewEmprunt);
            this.Controls.Add(this.lblEmprunt);
            this.Name = "EmpruntLivre";
            this.Text = "Emprunt d\'un livre";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmprunt;
        private System.Windows.Forms.ListView listViewEmprunt;
        private System.Windows.Forms.ColumnHeader columnIdentifiant;
        private System.Windows.Forms.ColumnHeader columnNom;
        private System.Windows.Forms.ColumnHeader columnAuteur;
        private System.Windows.Forms.ColumnHeader columnAnnee;
        private System.Windows.Forms.Label lblEmpruntLivre;
        private System.Windows.Forms.TextBox txtIdEmprunt;
        private System.Windows.Forms.Button btnEmprunter;
        private System.Windows.Forms.Label lblIdClientValide;
        private System.Windows.Forms.TextBox txtIdClient;
    }
}