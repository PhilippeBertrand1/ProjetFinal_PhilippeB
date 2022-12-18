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
            this.ColumnDataIdClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataPrenomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataNomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataTelClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataSexeClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataAdresseClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblListeClients = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDataIdClient,
            this.ColumnDataPrenomClient,
            this.ColumnDataNomClient,
            this.ColumnDataTelClient,
            this.ColumnDataSexeClient,
            this.ColumnDataAdresseClient});
            this.dataGridViewClients.Location = new System.Drawing.Point(61, 170);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(670, 232);
            this.dataGridViewClients.TabIndex = 0;
            // 
            // ColumnDataIdClient
            // 
            this.ColumnDataIdClient.HeaderText = "Identifiant";
            this.ColumnDataIdClient.Name = "ColumnDataIdClient";
            // 
            // ColumnDataPrenomClient
            // 
            this.ColumnDataPrenomClient.HeaderText = "Prénom";
            this.ColumnDataPrenomClient.Name = "ColumnDataPrenomClient";
            // 
            // ColumnDataNomClient
            // 
            this.ColumnDataNomClient.HeaderText = "Nom";
            this.ColumnDataNomClient.Name = "ColumnDataNomClient";
            // 
            // ColumnDataTelClient
            // 
            this.ColumnDataTelClient.HeaderText = "Num. Tel";
            this.ColumnDataTelClient.Name = "ColumnDataTelClient";
            // 
            // ColumnDataSexeClient
            // 
            this.ColumnDataSexeClient.HeaderText = "Sexe";
            this.ColumnDataSexeClient.Name = "ColumnDataSexeClient";
            // 
            // ColumnDataAdresseClient
            // 
            this.ColumnDataAdresseClient.HeaderText = "Adresse";
            this.ColumnDataAdresseClient.Name = "ColumnDataAdresseClient";
            // 
            // lblListeClients
            // 
            this.lblListeClients.AutoSize = true;
            this.lblListeClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeClients.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblListeClients.Location = new System.Drawing.Point(185, 87);
            this.lblListeClients.Name = "lblListeClients";
            this.lblListeClients.Size = new System.Drawing.Size(406, 55);
            this.lblListeClients.TabIndex = 1;
            this.lblListeClients.Text = "Listes des clients";
            // 
            // ListeClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblListeClients);
            this.Controls.Add(this.dataGridViewClients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListeClients";
            this.Text = "Listes des clients";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataIdClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataPrenomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataNomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataTelClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataSexeClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataAdresseClient;
        private System.Windows.Forms.Label lblListeClients;
    }
}