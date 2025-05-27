namespace Interfata_WindowsForms
{
    partial class FormAfisareClienti
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
            this.dataGridViewClienti = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preferinte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InapoiA = new System.Windows.Forms.Button();
            this.btnCautareA = new System.Windows.Forms.Button();
            this.txtCautareA = new System.Windows.Forms.TextBox();
            this.BtnModifica = new System.Windows.Forms.Button();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPreferinte = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPreferinte = new System.Windows.Forms.Label();
            this.BtnAdaugaClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClienti
            // 
            this.dataGridViewClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClienti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nume,
            this.Email,
            this.Preferinte});
            this.dataGridViewClienti.Location = new System.Drawing.Point(83, 87);
            this.dataGridViewClienti.Name = "dataGridViewClienti";
            this.dataGridViewClienti.Size = new System.Drawing.Size(561, 205);
            this.dataGridViewClienti.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Nume";
            this.Nume.Name = "Nume";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Preferinte
            // 
            this.Preferinte.HeaderText = "Preferinte";
            this.Preferinte.Name = "Preferinte";
            // 
            // InapoiA
            // 
            this.InapoiA.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InapoiA.Location = new System.Drawing.Point(638, 415);
            this.InapoiA.Name = "InapoiA";
            this.InapoiA.Size = new System.Drawing.Size(75, 23);
            this.InapoiA.TabIndex = 1;
            this.InapoiA.Text = "Inapoi";
            this.InapoiA.UseVisualStyleBackColor = true;
            this.InapoiA.Click += new System.EventHandler(this.InapoiA_Click);
            // 
            // btnCautareA
            // 
            this.btnCautareA.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCautareA.Location = new System.Drawing.Point(657, 46);
            this.btnCautareA.Name = "btnCautareA";
            this.btnCautareA.Size = new System.Drawing.Size(75, 23);
            this.btnCautareA.TabIndex = 2;
            this.btnCautareA.Text = "Cautare";
            this.btnCautareA.UseVisualStyleBackColor = true;
            this.btnCautareA.Click += new System.EventHandler(this.btnCautareA_Click);
            // 
            // txtCautareA
            // 
            this.txtCautareA.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCautareA.Location = new System.Drawing.Point(517, 48);
            this.txtCautareA.Name = "txtCautareA";
            this.txtCautareA.Size = new System.Drawing.Size(100, 21);
            this.txtCautareA.TabIndex = 3;
            // 
            // BtnModifica
            // 
            this.BtnModifica.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifica.Location = new System.Drawing.Point(198, 415);
            this.BtnModifica.Name = "BtnModifica";
            this.BtnModifica.Size = new System.Drawing.Size(75, 23);
            this.BtnModifica.TabIndex = 4;
            this.BtnModifica.Text = "Modifica";
            this.BtnModifica.UseVisualStyleBackColor = true;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(128, 324);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 20);
            this.txtNume.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(128, 350);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(128, 298);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 7;
            // 
            // txtPreferinte
            // 
            this.txtPreferinte.Location = new System.Drawing.Point(128, 376);
            this.txtPreferinte.Name = "txtPreferinte";
            this.txtPreferinte.Size = new System.Drawing.Size(100, 20);
            this.txtPreferinte.TabIndex = 8;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(62, 300);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(17, 15);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "Id";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(62, 326);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(39, 15);
            this.lblNume.TabIndex = 10;
            this.lblNume.Text = "Nume";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(62, 352);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(37, 15);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // lblPreferinte
            // 
            this.lblPreferinte.AutoSize = true;
            this.lblPreferinte.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreferinte.Location = new System.Drawing.Point(62, 378);
            this.lblPreferinte.Name = "lblPreferinte";
            this.lblPreferinte.Size = new System.Drawing.Size(60, 15);
            this.lblPreferinte.TabIndex = 12;
            this.lblPreferinte.Text = "Preferinte";
            // 
            // BtnAdaugaClient
            // 
            this.BtnAdaugaClient.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdaugaClient.Location = new System.Drawing.Point(371, 415);
            this.BtnAdaugaClient.Name = "BtnAdaugaClient";
            this.BtnAdaugaClient.Size = new System.Drawing.Size(113, 23);
            this.BtnAdaugaClient.TabIndex = 13;
            this.BtnAdaugaClient.Text = "Adauga Client";
            this.BtnAdaugaClient.UseVisualStyleBackColor = true;
            this.BtnAdaugaClient.Click += new System.EventHandler(this.BtnAdaugaClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "CLIENTI";
            // 
            // FormAfisareClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAdaugaClient);
            this.Controls.Add(this.lblPreferinte);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtPreferinte);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.BtnModifica);
            this.Controls.Add(this.txtCautareA);
            this.Controls.Add(this.btnCautareA);
            this.Controls.Add(this.InapoiA);
            this.Controls.Add(this.dataGridViewClienti);
            this.Name = "FormAfisareClienti";
            this.Text = "FormAfisareClienti";
            this.Click += new System.EventHandler(this.InapoiA_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClienti;
        private System.Windows.Forms.Button InapoiA;
        private System.Windows.Forms.Button btnCautareA;
        private System.Windows.Forms.TextBox txtCautareA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preferinte;
        private System.Windows.Forms.Button BtnModifica;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPreferinte;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPreferinte;
        private System.Windows.Forms.Button BtnAdaugaClient;
        private System.Windows.Forms.Label label1;
    }
}