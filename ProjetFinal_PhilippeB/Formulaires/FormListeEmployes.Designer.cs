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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblListeEmployes = new System.Windows.Forms.Label();
            this.dataGridViewEmployes = new System.Windows.Forms.DataGridView();
            this.ColumnDataIdClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataPrenomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataNomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataTelClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataSexeClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataAdresseClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListeEmployes
            // 
            this.lblListeEmployes.AutoSize = true;
            this.lblListeEmployes.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeEmployes.Location = new System.Drawing.Point(168, 69);
            this.lblListeEmployes.Name = "lblListeEmployes";
            this.lblListeEmployes.Size = new System.Drawing.Size(478, 55);
            this.lblListeEmployes.TabIndex = 3;
            this.lblListeEmployes.Text = "Listes des employés";
            // 
            // dataGridViewEmployes
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEmployes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDataIdClient,
            this.ColumnDataPrenomClient,
            this.ColumnDataNomClient,
            this.ColumnDataTelClient,
            this.ColumnDataSexeClient,
            this.ColumnDataAdresseClient});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmployes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEmployes.Location = new System.Drawing.Point(65, 151);
            this.dataGridViewEmployes.Name = "dataGridViewEmployes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEmployes.Size = new System.Drawing.Size(670, 232);
            this.dataGridViewEmployes.TabIndex = 2;
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
            // ListeEmployes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblListeEmployes);
            this.Controls.Add(this.dataGridViewEmployes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ListeEmployes";
            this.Text = "Liste des employés";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListeEmployes;
        private System.Windows.Forms.DataGridView dataGridViewEmployes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataIdClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataPrenomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataNomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataTelClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataSexeClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataAdresseClient;
    }
}