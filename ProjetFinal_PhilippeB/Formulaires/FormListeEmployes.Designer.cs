namespace ProjetFinal_PhilippeB
{
    partial class ListeEmployes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeEmployes));
            this.lblListeEmployes = new System.Windows.Forms.Label();
            this.listViewEmp = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblMoteurRecherche = new System.Windows.Forms.Label();
            this.cbxRecherche = new System.Windows.Forms.ComboBox();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.lblNbResultats = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblListeEmployes
            // 
            this.lblListeEmployes.AutoSize = true;
            this.lblListeEmployes.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeEmployes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblListeEmployes.Location = new System.Drawing.Point(142, 9);
            this.lblListeEmployes.Name = "lblListeEmployes";
            this.lblListeEmployes.Size = new System.Drawing.Size(530, 60);
            this.lblListeEmployes.TabIndex = 3;
            this.lblListeEmployes.Text = "Listes des employés";
            // 
            // listViewEmp
            // 
            this.listViewEmp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewEmp.HideSelection = false;
            this.listViewEmp.Location = new System.Drawing.Point(92, 167);
            this.listViewEmp.Name = "listViewEmp";
            this.listViewEmp.Size = new System.Drawing.Size(608, 244);
            this.listViewEmp.TabIndex = 4;
            this.listViewEmp.UseCompatibleStateImageBehavior = false;
            this.listViewEmp.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Prenom";
            this.columnHeader1.Width = 123;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom";
            this.columnHeader2.Width = 132;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telephone";
            this.columnHeader3.Width = 134;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sexe";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Taux horaire";
            this.columnHeader5.Width = 88;
            // 
            // lblMoteurRecherche
            // 
            this.lblMoteurRecherche.AutoSize = true;
            this.lblMoteurRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoteurRecherche.Location = new System.Drawing.Point(99, 98);
            this.lblMoteurRecherche.Name = "lblMoteurRecherche";
            this.lblMoteurRecherche.Size = new System.Drawing.Size(164, 20);
            this.lblMoteurRecherche.TabIndex = 5;
            this.lblMoteurRecherche.Text = "Moteur de recherche :";
            // 
            // cbxRecherche
            // 
            this.cbxRecherche.FormattingEnabled = true;
            this.cbxRecherche.Location = new System.Drawing.Point(269, 97);
            this.cbxRecherche.Name = "cbxRecherche";
            this.cbxRecherche.Size = new System.Drawing.Size(177, 21);
            this.cbxRecherche.TabIndex = 6;
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(269, 141);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(177, 20);
            this.txtRecherche.TabIndex = 7;
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecherche.Location = new System.Drawing.Point(98, 141);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(167, 20);
            this.lblRecherche.TabIndex = 8;
            this.lblRecherche.Text = "Donnée à rechercher :";
            // 
            // btnRechercher
            // 
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRechercher.Location = new System.Drawing.Point(484, 97);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(157, 62);
            this.btnRechercher.TabIndex = 9;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // lblNbResultats
            // 
            this.lblNbResultats.AutoSize = true;
            this.lblNbResultats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbResultats.Location = new System.Drawing.Point(92, 418);
            this.lblNbResultats.Name = "lblNbResultats";
            this.lblNbResultats.Size = new System.Drawing.Size(255, 20);
            this.lblNbResultats.TabIndex = 10;
            this.lblNbResultats.Text = "Nombre de résultats trouvées :";
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.ForeColor = System.Drawing.Color.Red;
            this.lblResultat.Location = new System.Drawing.Point(353, 419);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(0, 20);
            this.lblResultat.TabIndex = 11;
            // 
            // ListeEmployes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.lblNbResultats);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.cbxRecherche);
            this.Controls.Add(this.lblMoteurRecherche);
            this.Controls.Add(this.listViewEmp);
            this.Controls.Add(this.lblListeEmployes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListeEmployes";
            this.Text = "Liste des employés";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListeEmployes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListeEmployes;
        private System.Windows.Forms.ListView listViewEmp;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lblMoteurRecherche;
        private System.Windows.Forms.ComboBox cbxRecherche;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Label lblNbResultats;
        private System.Windows.Forms.Label lblResultat;
    }
}