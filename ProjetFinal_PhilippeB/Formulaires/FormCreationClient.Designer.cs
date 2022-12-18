namespace ProjetFinal_PhilippeB
{
    partial class CreationClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreationClient));
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdendifiantClient = new System.Windows.Forms.Label();
            this.txtIdentifiantClient = new System.Windows.Forms.TextBox();
            this.lblPrenomClient = new System.Windows.Forms.Label();
            this.lblNomClient = new System.Windows.Forms.Label();
            this.lblTelClient = new System.Windows.Forms.Label();
            this.lblDateNaissanceClient = new System.Windows.Forms.Label();
            this.lblAdresseClient = new System.Windows.Forms.Label();
            this.txtPrenomClient = new System.Windows.Forms.TextBox();
            this.txtNomClient = new System.Windows.Forms.TextBox();
            this.txtTelClient = new System.Windows.Forms.TextBox();
            this.txtAdresseClient = new System.Windows.Forms.TextBox();
            this.dateTimePickerClient = new System.Windows.Forms.DateTimePicker();
            this.btnCreerClient = new System.Windows.Forms.Button();
            this.gbxSexeClient = new System.Windows.Forms.GroupBox();
            this.lblErreurSexeClient = new System.Windows.Forms.Label();
            this.lblSexeClient = new System.Windows.Forms.Label();
            this.rbFemmeClient = new System.Windows.Forms.RadioButton();
            this.rbHommeClient = new System.Windows.Forms.RadioButton();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblErreurIDClient = new System.Windows.Forms.Label();
            this.lblErreurPrenomClient = new System.Windows.Forms.Label();
            this.lblErreurNomClient = new System.Windows.Forms.Label();
            this.lblErreurTelClient = new System.Windows.Forms.Label();
            this.lblErreurSexeClients = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMdpAdmin = new System.Windows.Forms.TextBox();
            this.btnSaveClients = new System.Windows.Forms.Button();
            this.gbxSexeClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(82, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Création d\'un nouveau client ";
            // 
            // lblIdendifiantClient
            // 
            this.lblIdendifiantClient.AutoSize = true;
            this.lblIdendifiantClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdendifiantClient.Location = new System.Drawing.Point(12, 72);
            this.lblIdendifiantClient.Name = "lblIdendifiantClient";
            this.lblIdendifiantClient.Size = new System.Drawing.Size(158, 20);
            this.lblIdendifiantClient.TabIndex = 1;
            this.lblIdendifiantClient.Text = "Numéro d\'identifiant :";
            // 
            // txtIdentifiantClient
            // 
            this.txtIdentifiantClient.Location = new System.Drawing.Point(176, 74);
            this.txtIdentifiantClient.Name = "txtIdentifiantClient";
            this.txtIdentifiantClient.Size = new System.Drawing.Size(189, 20);
            this.txtIdentifiantClient.TabIndex = 2;
            // 
            // lblPrenomClient
            // 
            this.lblPrenomClient.AutoSize = true;
            this.lblPrenomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenomClient.Location = new System.Drawing.Point(12, 124);
            this.lblPrenomClient.Name = "lblPrenomClient";
            this.lblPrenomClient.Size = new System.Drawing.Size(72, 20);
            this.lblPrenomClient.TabIndex = 3;
            this.lblPrenomClient.Text = "Prénom :";
            // 
            // lblNomClient
            // 
            this.lblNomClient.AutoSize = true;
            this.lblNomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomClient.Location = new System.Drawing.Point(12, 181);
            this.lblNomClient.Name = "lblNomClient";
            this.lblNomClient.Size = new System.Drawing.Size(50, 20);
            this.lblNomClient.TabIndex = 4;
            this.lblNomClient.Text = "Nom :";
            // 
            // lblTelClient
            // 
            this.lblTelClient.AutoSize = true;
            this.lblTelClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelClient.Location = new System.Drawing.Point(408, 74);
            this.lblTelClient.Name = "lblTelClient";
            this.lblTelClient.Size = new System.Drawing.Size(174, 20);
            this.lblTelClient.TabIndex = 5;
            this.lblTelClient.Text = "Numéro de téléphone : ";
            // 
            // lblDateNaissanceClient
            // 
            this.lblDateNaissanceClient.AutoSize = true;
            this.lblDateNaissanceClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateNaissanceClient.Location = new System.Drawing.Point(408, 124);
            this.lblDateNaissanceClient.Name = "lblDateNaissanceClient";
            this.lblDateNaissanceClient.Size = new System.Drawing.Size(154, 20);
            this.lblDateNaissanceClient.TabIndex = 6;
            this.lblDateNaissanceClient.Text = "Date de naissance : ";
            // 
            // lblAdresseClient
            // 
            this.lblAdresseClient.AutoSize = true;
            this.lblAdresseClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresseClient.Location = new System.Drawing.Point(408, 181);
            this.lblAdresseClient.Name = "lblAdresseClient";
            this.lblAdresseClient.Size = new System.Drawing.Size(80, 20);
            this.lblAdresseClient.TabIndex = 7;
            this.lblAdresseClient.Text = "Adresse : ";
            // 
            // txtPrenomClient
            // 
            this.txtPrenomClient.Location = new System.Drawing.Point(176, 126);
            this.txtPrenomClient.Name = "txtPrenomClient";
            this.txtPrenomClient.Size = new System.Drawing.Size(189, 20);
            this.txtPrenomClient.TabIndex = 9;
            // 
            // txtNomClient
            // 
            this.txtNomClient.Location = new System.Drawing.Point(176, 183);
            this.txtNomClient.Name = "txtNomClient";
            this.txtNomClient.Size = new System.Drawing.Size(189, 20);
            this.txtNomClient.TabIndex = 10;
            // 
            // txtTelClient
            // 
            this.txtTelClient.Location = new System.Drawing.Point(590, 72);
            this.txtTelClient.Name = "txtTelClient";
            this.txtTelClient.Size = new System.Drawing.Size(189, 20);
            this.txtTelClient.TabIndex = 11;
            // 
            // txtAdresseClient
            // 
            this.txtAdresseClient.Location = new System.Drawing.Point(590, 181);
            this.txtAdresseClient.Name = "txtAdresseClient";
            this.txtAdresseClient.Size = new System.Drawing.Size(189, 20);
            this.txtAdresseClient.TabIndex = 12;
            // 
            // dateTimePickerClient
            // 
            this.dateTimePickerClient.Location = new System.Drawing.Point(590, 123);
            this.dateTimePickerClient.Name = "dateTimePickerClient";
            this.dateTimePickerClient.Size = new System.Drawing.Size(191, 20);
            this.dateTimePickerClient.TabIndex = 15;
            // 
            // btnCreerClient
            // 
            this.btnCreerClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreerClient.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCreerClient.Location = new System.Drawing.Point(418, 213);
            this.btnCreerClient.Name = "btnCreerClient";
            this.btnCreerClient.Size = new System.Drawing.Size(105, 58);
            this.btnCreerClient.TabIndex = 16;
            this.btnCreerClient.Text = "Créer";
            this.btnCreerClient.UseVisualStyleBackColor = true;
            this.btnCreerClient.Click += new System.EventHandler(this.btnCreerClient_Click);
            // 
            // gbxSexeClient
            // 
            this.gbxSexeClient.Controls.Add(this.lblErreurSexeClient);
            this.gbxSexeClient.Controls.Add(this.lblSexeClient);
            this.gbxSexeClient.Controls.Add(this.rbFemmeClient);
            this.gbxSexeClient.Controls.Add(this.rbHommeClient);
            this.gbxSexeClient.Location = new System.Drawing.Point(16, 223);
            this.gbxSexeClient.Name = "gbxSexeClient";
            this.gbxSexeClient.Size = new System.Drawing.Size(389, 46);
            this.gbxSexeClient.TabIndex = 42;
            this.gbxSexeClient.TabStop = false;
            // 
            // lblErreurSexeClient
            // 
            this.lblErreurSexeClient.AutoSize = true;
            this.lblErreurSexeClient.Location = new System.Drawing.Point(16, 48);
            this.lblErreurSexeClient.Name = "lblErreurSexeClient";
            this.lblErreurSexeClient.Size = new System.Drawing.Size(0, 13);
            this.lblErreurSexeClient.TabIndex = 51;
            // 
            // lblSexeClient
            // 
            this.lblSexeClient.AutoSize = true;
            this.lblSexeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexeClient.Location = new System.Drawing.Point(8, 9);
            this.lblSexeClient.Name = "lblSexeClient";
            this.lblSexeClient.Size = new System.Drawing.Size(53, 20);
            this.lblSexeClient.TabIndex = 24;
            this.lblSexeClient.Text = "Sexe :";
            // 
            // rbFemmeClient
            // 
            this.rbFemmeClient.AutoSize = true;
            this.rbFemmeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemmeClient.Location = new System.Drawing.Point(302, 7);
            this.rbFemmeClient.Name = "rbFemmeClient";
            this.rbFemmeClient.Size = new System.Drawing.Size(81, 24);
            this.rbFemmeClient.TabIndex = 40;
            this.rbFemmeClient.TabStop = true;
            this.rbFemmeClient.Text = "Femme";
            this.rbFemmeClient.UseVisualStyleBackColor = true;
            // 
            // rbHommeClient
            // 
            this.rbHommeClient.AutoSize = true;
            this.rbHommeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHommeClient.Location = new System.Drawing.Point(213, 5);
            this.rbHommeClient.Name = "rbHommeClient";
            this.rbHommeClient.Size = new System.Drawing.Size(83, 24);
            this.rbHommeClient.TabIndex = 39;
            this.rbHommeClient.TabStop = true;
            this.rbHommeClient.Text = "Homme";
            this.rbHommeClient.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.Red;
            this.btnSupprimer.Location = new System.Drawing.Point(520, 213);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(104, 58);
            this.btnSupprimer.TabIndex = 43;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // dataGridViewClients
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewClients.Location = new System.Drawing.Point(28, 288);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(751, 150);
            this.dataGridViewClients.TabIndex = 44;
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnModifier.Location = new System.Drawing.Point(621, 213);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(104, 58);
            this.btnModifier.TabIndex = 45;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // lblErreurIDClient
            // 
            this.lblErreurIDClient.AutoSize = true;
            this.lblErreurIDClient.Location = new System.Drawing.Point(16, 96);
            this.lblErreurIDClient.Name = "lblErreurIDClient";
            this.lblErreurIDClient.Size = new System.Drawing.Size(0, 13);
            this.lblErreurIDClient.TabIndex = 46;
            // 
            // lblErreurPrenomClient
            // 
            this.lblErreurPrenomClient.AutoSize = true;
            this.lblErreurPrenomClient.Location = new System.Drawing.Point(20, 156);
            this.lblErreurPrenomClient.Name = "lblErreurPrenomClient";
            this.lblErreurPrenomClient.Size = new System.Drawing.Size(0, 13);
            this.lblErreurPrenomClient.TabIndex = 47;
            // 
            // lblErreurNomClient
            // 
            this.lblErreurNomClient.AutoSize = true;
            this.lblErreurNomClient.Location = new System.Drawing.Point(20, 207);
            this.lblErreurNomClient.Name = "lblErreurNomClient";
            this.lblErreurNomClient.Size = new System.Drawing.Size(0, 13);
            this.lblErreurNomClient.TabIndex = 48;
            // 
            // lblErreurTelClient
            // 
            this.lblErreurTelClient.AutoSize = true;
            this.lblErreurTelClient.Location = new System.Drawing.Point(415, 103);
            this.lblErreurTelClient.Name = "lblErreurTelClient";
            this.lblErreurTelClient.Size = new System.Drawing.Size(0, 13);
            this.lblErreurTelClient.TabIndex = 49;
            // 
            // lblErreurSexeClients
            // 
            this.lblErreurSexeClients.AutoSize = true;
            this.lblErreurSexeClients.Location = new System.Drawing.Point(28, 270);
            this.lblErreurSexeClients.Name = "lblErreurSexeClients";
            this.lblErreurSexeClients.Size = new System.Drawing.Size(0, 13);
            this.lblErreurSexeClients.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(477, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Mot de passe admin :";
            // 
            // txtMdpAdmin
            // 
            this.txtMdpAdmin.Location = new System.Drawing.Point(644, 26);
            this.txtMdpAdmin.Name = "txtMdpAdmin";
            this.txtMdpAdmin.Size = new System.Drawing.Size(135, 20);
            this.txtMdpAdmin.TabIndex = 52;
            // 
            // btnSaveClients
            // 
            this.btnSaveClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClients.ForeColor = System.Drawing.Color.Cyan;
            this.btnSaveClients.Location = new System.Drawing.Point(720, 213);
            this.btnSaveClients.Name = "btnSaveClients";
            this.btnSaveClients.Size = new System.Drawing.Size(129, 58);
            this.btnSaveClients.TabIndex = 53;
            this.btnSaveClients.Text = "Sauvegarder";
            this.btnSaveClients.UseVisualStyleBackColor = true;
            this.btnSaveClients.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreationClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 492);
            this.Controls.Add(this.btnSaveClients);
            this.Controls.Add(this.txtMdpAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblErreurSexeClients);
            this.Controls.Add(this.lblErreurTelClient);
            this.Controls.Add(this.lblErreurNomClient);
            this.Controls.Add(this.lblErreurPrenomClient);
            this.Controls.Add(this.lblErreurIDClient);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.dataGridViewClients);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.gbxSexeClient);
            this.Controls.Add(this.btnCreerClient);
            this.Controls.Add(this.dateTimePickerClient);
            this.Controls.Add(this.txtAdresseClient);
            this.Controls.Add(this.txtTelClient);
            this.Controls.Add(this.txtNomClient);
            this.Controls.Add(this.txtPrenomClient);
            this.Controls.Add(this.lblAdresseClient);
            this.Controls.Add(this.lblDateNaissanceClient);
            this.Controls.Add(this.lblTelClient);
            this.Controls.Add(this.lblNomClient);
            this.Controls.Add(this.lblPrenomClient);
            this.Controls.Add(this.txtIdentifiantClient);
            this.Controls.Add(this.lblIdendifiantClient);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreationClient";
            this.Text = "Création d\'un client";
            this.Load += new System.EventHandler(this.CreationClient_Load);
            this.gbxSexeClient.ResumeLayout(false);
            this.gbxSexeClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdendifiantClient;
        private System.Windows.Forms.TextBox txtIdentifiantClient;
        private System.Windows.Forms.Label lblPrenomClient;
        private System.Windows.Forms.Label lblNomClient;
        private System.Windows.Forms.Label lblTelClient;
        private System.Windows.Forms.Label lblDateNaissanceClient;
        private System.Windows.Forms.Label lblAdresseClient;
        private System.Windows.Forms.TextBox txtPrenomClient;
        private System.Windows.Forms.TextBox txtNomClient;
        private System.Windows.Forms.TextBox txtTelClient;
        private System.Windows.Forms.TextBox txtAdresseClient;
        private System.Windows.Forms.DateTimePicker dateTimePickerClient;
        private System.Windows.Forms.Button btnCreerClient;
        private System.Windows.Forms.GroupBox gbxSexeClient;
        private System.Windows.Forms.Label lblSexeClient;
        private System.Windows.Forms.RadioButton rbFemmeClient;
        private System.Windows.Forms.RadioButton rbHommeClient;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label lblErreurSexeClient;
        private System.Windows.Forms.Label lblErreurIDClient;
        private System.Windows.Forms.Label lblErreurPrenomClient;
        private System.Windows.Forms.Label lblErreurNomClient;
        private System.Windows.Forms.Label lblErreurTelClient;
        private System.Windows.Forms.Label lblErreurSexeClients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMdpAdmin;
        private System.Windows.Forms.Button btnSaveClients;
    }
}