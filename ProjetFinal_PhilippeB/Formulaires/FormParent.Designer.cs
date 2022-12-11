namespace ProjetFinal_PhilippeB
{
    partial class FormParent
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emprunterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créationDunCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterSupprimerModifierUnLivreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterSupprimerModifierUnEmployéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listesDesEmployésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.employéToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emprunterToolStripMenuItem,
            this.retoToolStripMenuItem,
            this.créationDunCompteToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // emprunterToolStripMenuItem
            // 
            this.emprunterToolStripMenuItem.Name = "emprunterToolStripMenuItem";
            this.emprunterToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.emprunterToolStripMenuItem.Text = "1. Emprunter";
            this.emprunterToolStripMenuItem.Click += new System.EventHandler(this.emprunterToolStripMenuItem_Click);
            // 
            // retoToolStripMenuItem
            // 
            this.retoToolStripMenuItem.Name = "retoToolStripMenuItem";
            this.retoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.retoToolStripMenuItem.Text = "2. Retourner";
            this.retoToolStripMenuItem.Click += new System.EventHandler(this.retoToolStripMenuItem_Click);
            // 
            // créationDunCompteToolStripMenuItem
            // 
            this.créationDunCompteToolStripMenuItem.Name = "créationDunCompteToolStripMenuItem";
            this.créationDunCompteToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.créationDunCompteToolStripMenuItem.Text = "3. Création d\'un compte";
            this.créationDunCompteToolStripMenuItem.Click += new System.EventHandler(this.créationDunCompteToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.quitterToolStripMenuItem.Text = "4. Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // employéToolStripMenuItem
            // 
            this.employéToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterSupprimerModifierUnLivreToolStripMenuItem,
            this.ajouterSupprimerModifierUnEmployéToolStripMenuItem,
            this.listeDesClientsToolStripMenuItem,
            this.listesDesEmployésToolStripMenuItem,
            this.quitterToolStripMenuItem1});
            this.employéToolStripMenuItem.Name = "employéToolStripMenuItem";
            this.employéToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.employéToolStripMenuItem.Text = "Employé";
            // 
            // ajouterSupprimerModifierUnLivreToolStripMenuItem
            // 
            this.ajouterSupprimerModifierUnLivreToolStripMenuItem.Name = "ajouterSupprimerModifierUnLivreToolStripMenuItem";
            this.ajouterSupprimerModifierUnLivreToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.ajouterSupprimerModifierUnLivreToolStripMenuItem.Text = "1. Ajouter / Supprimer / Modifier un livre";
            this.ajouterSupprimerModifierUnLivreToolStripMenuItem.Click += new System.EventHandler(this.ajouterSupprimerModifierUnLivreToolStripMenuItem_Click);
            // 
            // ajouterSupprimerModifierUnEmployéToolStripMenuItem
            // 
            this.ajouterSupprimerModifierUnEmployéToolStripMenuItem.Name = "ajouterSupprimerModifierUnEmployéToolStripMenuItem";
            this.ajouterSupprimerModifierUnEmployéToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.ajouterSupprimerModifierUnEmployéToolStripMenuItem.Text = "2. Ajouter / Supprimer / Modifier un employé";
            this.ajouterSupprimerModifierUnEmployéToolStripMenuItem.Click += new System.EventHandler(this.ajouterSupprimerModifierUnEmployéToolStripMenuItem_Click);
            // 
            // listeDesClientsToolStripMenuItem
            // 
            this.listeDesClientsToolStripMenuItem.Name = "listeDesClientsToolStripMenuItem";
            this.listeDesClientsToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.listeDesClientsToolStripMenuItem.Text = "3. Liste des clients";
            this.listeDesClientsToolStripMenuItem.Click += new System.EventHandler(this.listeDesClientsToolStripMenuItem_Click);
            // 
            // listesDesEmployésToolStripMenuItem
            // 
            this.listesDesEmployésToolStripMenuItem.Name = "listesDesEmployésToolStripMenuItem";
            this.listesDesEmployésToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.listesDesEmployésToolStripMenuItem.Text = "4. Listes des employés";
            this.listesDesEmployésToolStripMenuItem.Click += new System.EventHandler(this.listesDesEmployésToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem1
            // 
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(313, 22);
            this.quitterToolStripMenuItem1.Text = "5. Quitter";
            this.quitterToolStripMenuItem1.Click += new System.EventHandler(this.quitterToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(646, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "BIENVENUE À LA BIBLIOTHÈQUE ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormParent";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emprunterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créationDunCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterSupprimerModifierUnLivreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterSupprimerModifierUnEmployéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem listeDesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listesDesEmployésToolStripMenuItem;
    }
}

