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
            this.lblEmpruntLivre = new System.Windows.Forms.Label();
            this.txtIdEmprunt = new System.Windows.Forms.TextBox();
            this.btnEmprunter = new System.Windows.Forms.Button();
            this.lblIdClientValide = new System.Windows.Forms.Label();
            this.txtIdClient = new System.Windows.Forms.TextBox();
            this.lblListeLivresDispo = new System.Windows.Forms.Label();
            this.dataGridViewLivre = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivre)).BeginInit();
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
            this.btnEmprunter.Click += new System.EventHandler(this.btnEmprunter_Click);
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
            // lblListeLivresDispo
            // 
            this.lblListeLivresDispo.AutoSize = true;
            this.lblListeLivresDispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeLivresDispo.Location = new System.Drawing.Point(222, 185);
            this.lblListeLivresDispo.Name = "lblListeLivresDispo";
            this.lblListeLivresDispo.Size = new System.Drawing.Size(339, 29);
            this.lblListeLivresDispo.TabIndex = 7;
            this.lblListeLivresDispo.Text = "Liste des livres disponibles ";
            // 
            // dataGridViewLivre
            // 
            this.dataGridViewLivre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLivre.Location = new System.Drawing.Point(88, 217);
            this.dataGridViewLivre.Name = "dataGridViewLivre";
            this.dataGridViewLivre.Size = new System.Drawing.Size(588, 204);
            this.dataGridViewLivre.TabIndex = 8;
            this.dataGridViewLivre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLivre_CellContentClick);
            // 
            // EmpruntLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewLivre);
            this.Controls.Add(this.lblListeLivresDispo);
            this.Controls.Add(this.txtIdClient);
            this.Controls.Add(this.lblIdClientValide);
            this.Controls.Add(this.btnEmprunter);
            this.Controls.Add(this.txtIdEmprunt);
            this.Controls.Add(this.lblEmpruntLivre);
            this.Controls.Add(this.lblEmprunt);
            this.Name = "EmpruntLivre";
            this.Text = "Emprunt d\'un livre";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmpruntLivre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmprunt;
        private System.Windows.Forms.Label lblEmpruntLivre;
        private System.Windows.Forms.TextBox txtIdEmprunt;
        private System.Windows.Forms.Button btnEmprunter;
        private System.Windows.Forms.Label lblIdClientValide;
        private System.Windows.Forms.TextBox txtIdClient;
        private System.Windows.Forms.Label lblListeLivresDispo;
        private System.Windows.Forms.DataGridView dataGridViewLivre;
    }
}