namespace ProjetFinal_PhilippeB
{
    partial class ListeClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeClients));
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.lblListeClients = new System.Windows.Forms.Label();
            this.btnCroissant = new System.Windows.Forms.Button();
            this.btnDecroissant = new System.Windows.Forms.Button();
            this.btnHomme = new System.Windows.Forms.Button();
            this.btnFemme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(61, 170);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(670, 232);
            this.dataGridViewClients.TabIndex = 0;
            // 
            // lblListeClients
            // 
            this.lblListeClients.AutoSize = true;
            this.lblListeClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeClients.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblListeClients.Location = new System.Drawing.Point(195, 9);
            this.lblListeClients.Name = "lblListeClients";
            this.lblListeClients.Size = new System.Drawing.Size(406, 55);
            this.lblListeClients.TabIndex = 1;
            this.lblListeClients.Text = "Listes des clients";
            // 
            // btnCroissant
            // 
            this.btnCroissant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCroissant.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCroissant.Location = new System.Drawing.Point(41, 88);
            this.btnCroissant.Name = "btnCroissant";
            this.btnCroissant.Size = new System.Drawing.Size(145, 56);
            this.btnCroissant.TabIndex = 2;
            this.btnCroissant.Text = "Ordre croissant";
            this.btnCroissant.UseVisualStyleBackColor = true;
            this.btnCroissant.Click += new System.EventHandler(this.btnCroissant_Click);
            // 
            // btnDecroissant
            // 
            this.btnDecroissant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecroissant.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDecroissant.Location = new System.Drawing.Point(228, 89);
            this.btnDecroissant.Name = "btnDecroissant";
            this.btnDecroissant.Size = new System.Drawing.Size(145, 56);
            this.btnDecroissant.TabIndex = 3;
            this.btnDecroissant.Text = "Ordre décroissant";
            this.btnDecroissant.UseVisualStyleBackColor = true;
            this.btnDecroissant.Click += new System.EventHandler(this.btnDecroissant_Click);
            // 
            // btnHomme
            // 
            this.btnHomme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomme.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnHomme.Location = new System.Drawing.Point(422, 89);
            this.btnHomme.Name = "btnHomme";
            this.btnHomme.Size = new System.Drawing.Size(145, 56);
            this.btnHomme.TabIndex = 4;
            this.btnHomme.Text = "Homme";
            this.btnHomme.UseVisualStyleBackColor = true;
            this.btnHomme.Click += new System.EventHandler(this.btnHomme_Click);
            // 
            // btnFemme
            // 
            this.btnFemme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFemme.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnFemme.Location = new System.Drawing.Point(601, 91);
            this.btnFemme.Name = "btnFemme";
            this.btnFemme.Size = new System.Drawing.Size(145, 55);
            this.btnFemme.TabIndex = 5;
            this.btnFemme.Text = "Femme";
            this.btnFemme.UseVisualStyleBackColor = true;
            this.btnFemme.Click += new System.EventHandler(this.btnFemme_Click);
            // 
            // ListeClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFemme);
            this.Controls.Add(this.btnHomme);
            this.Controls.Add(this.btnDecroissant);
            this.Controls.Add(this.btnCroissant);
            this.Controls.Add(this.lblListeClients);
            this.Controls.Add(this.dataGridViewClients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListeClients";
            this.Text = "Listes des clients";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListeClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Label lblListeClients;
        private System.Windows.Forms.Button btnCroissant;
        private System.Windows.Forms.Button btnDecroissant;
        private System.Windows.Forms.Button btnHomme;
        private System.Windows.Forms.Button btnFemme;
    }
}